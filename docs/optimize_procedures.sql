-- Script tối ưu hóa SimbaSql Stored Procedures
-- Tập trung vào các vấn đề performance và security

-- ============================================
-- 1. THAY THẾ SELECT * BẰNG COLUMN LIST CỤ THỂ
-- ============================================

-- Ví dụ: Tối ưu hóa procedure sử dụng SELECT *
-- Procedure gốc có thể trông như thế này:
/*
CREATE PROCEDURE asExampleProc
    @pParam1 NVARCHAR(10)
AS
BEGIN
    SELECT * FROM SomeTable WHERE Column1 = @pParam1
END
*/

-- Phiên bản tối ưu:
/*
CREATE PROCEDURE asExampleProc_Optimized
    @pParam1 NVARCHAR(10)
AS
BEGIN
    SELECT 
        Column1,
        Column2,
        Column3,
        -- Chỉ liệt kê các column cần thiết
        Column4
    FROM SomeTable 
    WHERE Column1 = @pParam1
END
*/

-- ============================================
-- 2. TỐI ƯU HÓA CURSOR BẰNG SET-BASED OPERATIONS
-- ============================================

-- Ví dụ: Procedure sử dụng CURSOR
/*
CREATE PROCEDURE asProcessWithCursor
    @pCompanyCode NVARCHAR(3)
AS
BEGIN
    DECLARE @id INT
    DECLARE cursor1 CURSOR FOR 
        SELECT ID FROM SomeTable WHERE CompanyCode = @pCompanyCode
    
    OPEN cursor1
    FETCH NEXT FROM cursor1 INTO @id
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Xử lý từng record
        UPDATE AnotherTable SET Status = 1 WHERE RefID = @id
        
        FETCH NEXT FROM cursor1 INTO @id
    END
    
    CLOSE cursor1
    DEALLOCATE cursor1
END
*/

-- Phiên bản tối ưu sử dụng UPDATE set-based:
/*
CREATE PROCEDURE asProcessWithCursor_Optimized
    @pCompanyCode NVARCHAR(3)
AS
BEGIN
    UPDATE AnotherTable 
    SET Status = 1
    WHERE RefID IN (
        SELECT ID 
        FROM SomeTable 
        WHERE CompanyCode = @pCompanyCode
    )
END
*/

-- ============================================
-- 3. THÊM INDEX CHO CÁC QUERY THƯỜNG XUYÊN
-- ============================================

-- Index cho bảng GlCt (chứng từ kế toán)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_GlCt_MaCty_NgayCt')
BEGIN
    CREATE NONCLUSTERED INDEX IX_GlCt_MaCty_NgayCt 
    ON dbo.GlCt (ma_cty, ngay_ct)
    INCLUDE (tk, ps_no, ps_co, ma_kh)
END

-- Index cho bảng ArDmKh (danh mục khách hàng)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_ArDmKh_MaCty_TenKh')
BEGIN
    CREATE NONCLUSTERED INDEX IX_ArDmKh_MaCty_TenKh 
    ON dbo.ArDmKh (ma_cty, ten_kh)
    INCLUDE (ma_kh, dia_chi, tel)
END

-- Index cho bảng GlDmTk (danh mục tài khoản)
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_GlDmTk_MaCty_Tk')
BEGIN
    CREATE NONCLUSTERED INDEX IX_GlDmTk_MaCty_Tk 
    ON dbo.GlDmTk (ma_cty, tk)
    INCLUDE (ten_tk, tk_me, bac_tk)
END

-- ============================================
-- 4. TỐI ƯU HÓA DYNAMIC SQL
-- ============================================

-- Ví dụ: Dynamic SQL không an toàn
/*
CREATE PROCEDURE asUnsafeDynamicSQL
    @pTableName NVARCHAR(50),
    @pColumnName NVARCHAR(50),
    @pValue NVARCHAR(100)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)
    SET @sql = 'SELECT * FROM ' + @pTableName + ' WHERE ' + @pColumnName + ' = ''' + @pValue + ''''
    EXEC(@sql)
END
*/

-- Phiên bản an toàn hơn với QUOTENAME và parameterized query:
/*
CREATE PROCEDURE asUnsafeDynamicSQL_Optimized
    @pTableName NVARCHAR(50),
    @pColumnName NVARCHAR(50),
    @pValue NVARCHAR(100)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)
    
    -- Sử dụng QUOTENAME để tránh SQL injection
    SET @sql = 'SELECT * FROM ' + QUOTENAME(@pTableName) + 
               ' WHERE ' + QUOTENAME(@pColumnName) + ' = @value'
    
    EXEC sp_executesql @sql, N'@value NVARCHAR(100)', @value = @pValue
END
*/

-- ============================================
-- 5. THÊM ERROR HANDLING
-- ============================================

-- Template cho stored procedure với error handling
/*
CREATE PROCEDURE asTemplateWithErrorHandling
    @pParam1 NVARCHAR(10),
    @pRet INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    SET XACT_ABORT ON
    
    BEGIN TRY
        BEGIN TRANSACTION
        
        -- Business logic here
        
        SET @pRet = 0 -- Success
        
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
        
        SET @pRet = ERROR_NUMBER()
        
        -- Log error (giả sử có bảng ErrorLog)
        INSERT INTO ErrorLog (ErrorNumber, ErrorMessage, ProcedureName, ErrorTime)
        VALUES (ERROR_NUMBER(), ERROR_MESSAGE(), 'asTemplateWithErrorHandling', GETDATE())
        
        -- Có thể re-throw error nếu cần
        -- THROW
    END CATCH
END
*/

-- ============================================
-- 6. TỐI ƯU HÓA JOIN VÀ WHERE CLAUSE
-- ============================================

-- Ví dụ: Tránh hàm trên cột trong WHERE
-- Không tốt: WHERE YEAR(ngay_ct) = 2023
-- Tốt hơn: WHERE ngay_ct >= '2023-01-01' AND ngay_ct < '2024-01-01'

-- Ví dụ: Sử dụng EXISTS thay vì IN cho subqueries lớn
/*
-- Không tốt cho large datasets:
SELECT * FROM Table1 WHERE ID IN (SELECT ID FROM LargeTable WHERE Condition = 1)

-- Tốt hơn:
SELECT * FROM Table1 t1 
WHERE EXISTS (SELECT 1 FROM LargeTable lt WHERE lt.ID = t1.ID AND lt.Condition = 1)
*/

-- ============================================
-- 7. TẠO TEMPLATE CHO CÁC LOẠI PROCEDURE
-- ============================================

-- Template cho procedure GET (lấy dữ liệu)
/*
CREATE PROCEDURE asGet[TableName]
    @pMa_cty NVARCHAR(3),
    @pFilter1 NVARCHAR(50) = '',
    @pFilter2 NVARCHAR(50) = ''
AS
BEGIN
    SET NOCOUNT ON
    
    SELECT 
        -- Liệt kê cụ thể các column
        column1,
        column2,
        column3
    FROM [TableName]
    WHERE ma_cty = @pMa_cty
        AND (column1 LIKE @pFilter1 + '%' OR @pFilter1 = '')
        AND (column2 LIKE @pFilter2 + '%' OR @pFilter2 = '')
    ORDER BY ngay_ct DESC, so_ct DESC
END
*/

-- Template cho procedure INSERT
/*
CREATE PROCEDURE asIns[TableName]
    @pMa_cty NVARCHAR(3),
    @pColumn1 NVARCHAR(50),
    @pColumn2 DECIMAL(19,4),
    @pLUser NVARCHAR(20),
    @pRet INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON
    SET XACT_ABORT ON
    
    BEGIN TRY
        INSERT INTO [TableName] (
            ma_cty,
            column1,
            column2,
            cuser,
            cdate,
            luser,
            ldate
        ) VALUES (
            @pMa_cty,
            @pColumn1,
            @pColumn2,
            @pLUser,
            GETDATE(),
            @pLUser,
            GETDATE()
        )
        
        SET @pRet = 0
    END TRY
    BEGIN CATCH
        SET @pRet = ERROR_NUMBER()
        -- Log error
    END CATCH
END
*/

-- ============================================
-- 8. SCRIPT TÌM PROCEDURE CẦN TỐI ƯU HÓA
-- ============================================

-- Tìm procedure sử dụng SELECT *
SELECT 
    OBJECT_NAME(object_id) AS ProcedureName,
    definition
FROM sys.sql_modules 
WHERE definition LIKE '%SELECT *%'
    AND OBJECT_NAME(object_id) LIKE 'as%'
ORDER BY ProcedureName

-- Tìm procedure sử dụng CURSOR
SELECT 
    OBJECT_NAME(object_id) AS ProcedureName,
    definition
FROM sys.sql_modules 
WHERE definition LIKE '%CURSOR FOR%'
    AND OBJECT_NAME(object_id) LIKE 'as%'
ORDER BY ProcedureName

-- Tìm procedure sử dụng dynamic SQL
SELECT 
    OBJECT_NAME(object_id) AS ProcedureName,
    definition
FROM sys.sql_modules 
WHERE (definition LIKE '%EXEC(%' OR definition LIKE '%EXECUTE(%' OR definition LIKE '%sp_executesql%')
    AND OBJECT_NAME(object_id) LIKE 'as%'
ORDER BY ProcedureName

-- ============================================
-- 9. UPDATE STATISTICS
-- ============================================

-- Update statistics cho các bảng quan trọng
EXEC sp_updatestats

-- Update statistics cụ thể
UPDATE STATISTICS dbo.GlCt WITH FULLSCAN
UPDATE STATISTICS dbo.ArDmKh WITH FULLSCAN
UPDATE STATISTICS dbo.GlDmTk WITH FULLSCAN

-- ============================================
-- 10. CLEANUP UNUSED PROCEDURES
-- ============================================

-- Xóa các procedure bắt đầu bằng 'z_' (tạm/sao lưu) nếu không cần
/*
DECLARE @procName NVARCHAR(200)
DECLARE procCursor CURSOR FOR
    SELECT name FROM sys.procedures WHERE name LIKE 'z_%'

OPEN procCursor
FETCH NEXT FROM procCursor INTO @procName

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Kiểm tra xem procedure có được sử dụng không
    IF NOT EXISTS (
        SELECT 1 FROM sys.sql_expression_dependencies 
        WHERE referenced_entity_name = @procName
    )
    BEGIN
        EXEC('DROP PROCEDURE ' + @procName)
        PRINT 'Dropped procedure: ' + @procName
    END
    
    FETCH NEXT FROM procCursor INTO @procName
END

CLOSE procCursor
DEALLOCATE procCursor
*/

-- ============================================
-- KẾT LUẬN
-- ============================================

/*
Các bước tối ưu hóa nên thực hiện theo thứ tự:
1. Fix security issues (dynamic SQL injection)
2. Optimize high-impact procedures (thường xuyên được gọi)
3. Add missing indexes
4. Replace SELECT * với column list
5. Replace CURSOR với set-based operations
6. Add error handling
7. Cleanup unused code
8. Regular maintenance (update statistics, rebuild indexes)

Lưu ý: Luôn test kỹ trước khi áp dụng vào production.
*/