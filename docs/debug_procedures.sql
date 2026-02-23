-- Script debug SimbaSql Stored Procedures
-- Cung cấp các công cụ để debug và troubleshoot

-- ============================================
-- 1. SCRIPT DEBUG CƠ BẢN
-- ============================================

-- Template debug procedure
CREATE PROCEDURE spDebug_ExecuteProcedure
    @pProcedureName NVARCHAR(200),
    @pParameters NVARCHAR(MAX) = ''
AS
BEGIN
    SET NOCOUNT ON
    
    DECLARE @sql NVARCHAR(MAX)
    DECLARE @startTime DATETIME
    DECLARE @endTime DATETIME
    DECLARE @duration INT
    
    SET @startTime = GETDATE()
    
    -- Build dynamic SQL
    SET @sql = 'EXEC ' + QUOTENAME(@pProcedureName) + ' ' + @pParameters
    
    PRINT 'Executing: ' + @sql
    PRINT 'Start time: ' + CONVERT(NVARCHAR, @startTime, 120)
    PRINT '--------------------------------------------------'
    
    BEGIN TRY
        EXEC sp_executesql @sql
        
        SET @endTime = GETDATE()
        SET @duration = DATEDIFF(MILLISECOND, @startTime, @endTime)
        
        PRINT '--------------------------------------------------'
        PRINT 'End time: ' + CONVERT(NVARCHAR, @endTime, 120)
        PRINT 'Duration: ' + CAST(@duration AS NVARCHAR) + ' ms'
        PRINT 'Success!'
    END TRY
    BEGIN CATCH
        SET @endTime = GETDATE()
        SET @duration = DATEDIFF(MILLISECOND, @startTime, @endTime)
        
        PRINT '--------------------------------------------------'
        PRINT 'End time: ' + CONVERT(NVARCHAR, @endTime, 120)
        PRINT 'Duration: ' + CAST(@duration AS NVARCHAR) + ' ms'
        PRINT 'ERROR: ' + ERROR_MESSAGE()
        PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS NVARCHAR)
        PRINT 'Error Line: ' + CAST(ERROR_LINE() AS NVARCHAR)
    END CATCH
END
GO

-- ============================================
-- 2. THEO DÕI PERFORMANCE
-- ============================================

-- Procedure để log performance
CREATE TABLE ProcedurePerformanceLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    ProcedureName NVARCHAR(200),
    Parameters NVARCHAR(MAX),
    StartTime DATETIME,
    EndTime DATETIME,
    DurationMs INT,
    RowsAffected INT,
    ErrorMessage NVARCHAR(MAX),
    LogTime DATETIME DEFAULT GETDATE()
)
GO

CREATE PROCEDURE spDebug_LogProcedurePerformance
    @pProcedureName NVARCHAR(200),
    @pParameters NVARCHAR(MAX) = '',
    @pRowsAffected INT = NULL,
    @pErrorMessage NVARCHAR(MAX) = NULL
AS
BEGIN
    INSERT INTO ProcedurePerformanceLog (
        ProcedureName,
        Parameters,
        StartTime,
        EndTime,
        DurationMs,
        RowsAffected,
        ErrorMessage
    ) VALUES (
        @pProcedureName,
        @pParameters,
        DATEADD(MILLISECOND, -100, GETDATE()), -- Giả sử start time là 100ms trước
        GETDATE(),
        100, -- Giả sử duration
        @pRowsAffected,
        @pErrorMessage
    )
END
GO

-- View để xem performance report
CREATE VIEW vwProcedurePerformance
AS
SELECT 
    ProcedureName,
    COUNT(*) AS ExecutionCount,
    AVG(DurationMs) AS AvgDurationMs,
    MIN(DurationMs) AS MinDurationMs,
    MAX(DurationMs) AS MaxDurationMs,
    SUM(DurationMs) AS TotalDurationMs,
    MIN(LogTime) AS FirstExecution,
    MAX(LogTime) AS LastExecution,
    SUM(CASE WHEN ErrorMessage IS NULL THEN 1 ELSE 0 END) AS SuccessCount,
    SUM(CASE WHEN ErrorMessage IS NOT NULL THEN 1 ELSE 0 END) AS ErrorCount
FROM ProcedurePerformanceLog
GROUP BY ProcedureName
GO

-- ============================================
-- 3. PHÂN TÍCH DEPENDENCIES
-- ============================================

-- Xem dependencies của một procedure
CREATE PROCEDURE spDebug_GetProcedureDependencies
    @pProcedureName NVARCHAR(200)
AS
BEGIN
    -- Objects that this procedure depends on
    SELECT 
        OBJECT_NAME(referencing_id) AS ReferencingProcedure,
        referenced_entity_name AS ReferencedObject,
        referenced_database_name AS DatabaseName,
        referenced_schema_name AS SchemaName
    FROM sys.sql_expression_dependencies
    WHERE referencing_id = OBJECT_ID(@pProcedureName)
    
    -- Objects that depend on this procedure
    SELECT 
        OBJECT_NAME(referencing_id) AS DependentProcedure,
        referenced_entity_name AS ReferencedProcedure,
        referenced_database_name AS DatabaseName,
        referenced_schema_name AS SchemaName
    FROM sys.sql_expression_dependencies
    WHERE referenced_entity_name = @pProcedureName
        AND referenced_database_name IS NULL -- Same database
END
GO

-- ============================================
-- 4. PHÂN TÍCH EXECUTION PLAN
-- ============================================

-- Procedure để capture execution plan
CREATE PROCEDURE spDebug_GetProcedureExecutionPlan
    @pProcedureName NVARCHAR(200),
    @pParameters NVARCHAR(MAX) = ''
AS
BEGIN
    SET NOCOUNT ON
    
    DECLARE @sql NVARCHAR(MAX)
    DECLARE @plan_handle VARBINARY(64)
    
    -- Build dynamic SQL với SET STATISTICS XML ON
    SET @sql = '
        SET STATISTICS XML ON;
        EXEC ' + QUOTENAME(@pProcedureName) + ' ' + @pParameters + ';
        SET STATISTICS XML OFF;
    '
    
    BEGIN TRY
        -- Create a temporary table to store results
        CREATE TABLE #ExecutionPlans (
            EventType NVARCHAR(100),
            Parameters NVARCHAR(MAX),
            ExecutionPlan XML
        )
        
        -- Insert execution plan
        INSERT INTO #ExecutionPlans (EventType, Parameters)
        VALUES ('Procedure Execution', @pParameters)
        
        -- Execute and get plan
        EXEC sp_executesql @sql
        
        -- Note: Trong thực tế, cần capture execution plan từ SSMS hoặc query DMVs
        SELECT * FROM #ExecutionPlans
        
        DROP TABLE #ExecutionPlans
        
    END TRY
    BEGIN CATCH
        PRINT 'Error capturing execution plan: ' + ERROR_MESSAGE()
    END CATCH
END
GO

-- ============================================
-- 5. KIỂM TRA PARAMETERS
-- ============================================

-- Xem parameters của procedure
CREATE PROCEDURE spDebug_GetProcedureParameters
    @pProcedureName NVARCHAR(200)
AS
BEGIN
    SELECT 
        p.name AS ParameterName,
        TYPE_NAME(p.user_type_id) AS DataType,
        p.max_length AS MaxLength,
        p.precision AS Precision,
        p.scale AS Scale,
        p.is_output AS IsOutput,
        p.has_default_value AS HasDefaultValue,
        p.default_value AS DefaultValue
    FROM sys.parameters p
    WHERE p.object_id = OBJECT_ID(@pProcedureName)
    ORDER BY p.parameter_id
END
GO

-- ============================================
-- 6. TEST PROCEDURE VỚI DỮ LIỆU MẪU
-- ============================================

-- Procedure để test với các bộ parameters khác nhau
CREATE PROCEDURE spDebug_TestProcedure
    @pProcedureName NVARCHAR(200),
    @pTestCases NVARCHAR(MAX) -- JSON format: [{"params": "value1, value2", "expectedRows": 10}, ...]
AS
BEGIN
    SET NOCOUNT ON
    
    DECLARE @testCases TABLE (
        TestCaseID INT IDENTITY(1,1),
        Parameters NVARCHAR(MAX),
        ExpectedRows INT,
        ActualRows INT NULL,
        Status NVARCHAR(20) NULL,
        ErrorMessage NVARCHAR(MAX) NULL,
        DurationMs INT NULL
    )
    
    -- Parse test cases từ JSON (giả sử SQL Server 2016+)
    -- Trong thực tế, có thể dùng OPENJSON hoặc parse thủ công
    
    DECLARE @testCaseID INT
    DECLARE @parameters NVARCHAR(MAX)
    DECLARE @expectedRows INT
    DECLARE @sql NVARCHAR(MAX)
    DECLARE @startTime DATETIME
    DECLARE @endTime DATETIME
    DECLARE @duration INT
    DECLARE @rowCount INT
    
    -- Giả sử có 1 test case đơn giản
    INSERT INTO @testCases (Parameters, ExpectedRows)
    VALUES ('@pMa_cty = ''001'', @pMa_ct = ''PTT''', 10)
    
    SELECT @testCaseID = MIN(TestCaseID) FROM @testCases
    
    WHILE @testCaseID IS NOT NULL
    BEGIN
        SELECT @parameters = Parameters, @expectedRows = ExpectedRows
        FROM @testCases WHERE TestCaseID = @testCaseID
        
        SET @sql = 'EXEC ' + QUOTENAME(@pProcedureName) + ' ' + @parameters
        
        SET @startTime = GETDATE()
        
        BEGIN TRY
            -- Create temp table để capture results
            CREATE TABLE #TempResults (ID INT IDENTITY(1,1), Data NVARCHAR(MAX))
            
            -- Execute và insert results vào temp table
            INSERT INTO #TempResults (Data)
            EXEC sp_executesql @sql
            
            SET @rowCount = @@ROWCOUNT
            
            SET @endTime = GETDATE()
            SET @duration = DATEDIFF(MILLISECOND, @startTime, @endTime)
            
            UPDATE @testCases
            SET ActualRows = @rowCount,
                DurationMs = @duration,
                Status = CASE WHEN @rowCount = @expectedRows THEN 'PASS' ELSE 'FAIL' END
            WHERE TestCaseID = @testCaseID
            
            DROP TABLE #TempResults
            
        END TRY
        BEGIN CATCH
            SET @endTime = GETDATE()
            SET @duration = DATEDIFF(MILLISECOND, @startTime, @endTime)
            
            UPDATE @testCases
            SET DurationMs = @duration,
                Status = 'ERROR',
                ErrorMessage = ERROR_MESSAGE()
            WHERE TestCaseID = @testCaseID
        END CATCH
        
        SELECT @testCaseID = MIN(TestCaseID) FROM @testCases WHERE TestCaseID > @testCaseID
    END
    
    -- Report kết quả
    SELECT * FROM @testCases
END
GO

-- ============================================
-- 7. THEO DÕI BLOCKING VÀ DEADLOCKS
-- ============================================

-- Procedure để check blocking
CREATE PROCEDURE spDebug_CheckBlocking
AS
BEGIN
    SELECT 
        blocking.session_id AS BlockingSessionID,
        blocked.session_id AS BlockedSessionID,
        blocking_text.text AS BlockingQuery,
        blocked_text.text AS BlockedQuery,
        DB_NAME(blocked.database_id) AS DatabaseName,
        blocked.wait_type AS WaitType,
        blocked.wait_time AS WaitTimeMs
    FROM sys.dm_exec_requests blocked
    INNER JOIN sys.dm_exec_requests blocking 
        ON blocked.blocking_session_id = blocking.session_id
    OUTER APPLY sys.dm_exec_sql_text(blocked.sql_handle) blocked_text
    OUTER APPLY sys.dm_exec_sql_text(blocking.sql_handle) blocking_text
    WHERE blocked.blocking_session_id > 0
END
GO

-- ============================================
-- 8. KIỂM TRA INDEX USAGE
-- ============================================

-- Xem index usage cho các bảng được procedure sử dụng
CREATE PROCEDURE spDebug_GetProcedureIndexUsage
    @pProcedureName NVARCHAR(200)
AS
BEGIN
    -- Lấy các bảng được procedure reference
    DECLARE @tables TABLE (TableName NVARCHAR(200))
    
    INSERT INTO @tables (TableName)
    SELECT referenced_entity_name
    FROM sys.sql_expression_dependencies
    WHERE referencing_id = OBJECT_ID(@pProcedureName)
        AND referenced_class = 1 -- Object
    
    -- Xem index usage cho các bảng này
    SELECT 
        t.TableName,
        i.name AS IndexName,
        i.type_desc AS IndexType,
        s.user_seeks,
        s.user_scans,
        s.user_lookups,
        s.user_updates,
        s.last_user_seek,
        s.last_user_scan,
        s.last_user_lookup,
        s.last_user_update
    FROM @tables t
    INNER JOIN sys.indexes i ON OBJECT_ID(t.TableName) = i.object_id
    LEFT JOIN sys.dm_db_index_usage_stats s ON i.object_id = s.object_id 
        AND i.index_id = s.index_id
    WHERE i.name IS NOT NULL
    ORDER BY t.TableName, i.name
END
GO

-- ============================================
-- 9. DEBUG LOGGING FRAMEWORK
-- ============================================

-- Bảng log chi tiết
CREATE TABLE DebugLog (
    LogID BIGINT IDENTITY(1,1) PRIMARY KEY,
    LogTime DATETIME DEFAULT GETDATE(),
    ProcedureName NVARCHAR(200),
    StepName NVARCHAR(100),
    Message NVARCHAR(MAX),
    Parameters NVARCHAR(MAX),
    ExecutionTimeMs INT NULL,
    RowCount INT NULL,
    ErrorMessage NVARCHAR(MAX) NULL,
    Severity INT DEFAULT 1 -- 1: Info, 2: Warning, 3: Error
)
GO

-- Procedure để log debug information
CREATE PROCEDURE spDebug_Log
    @pProcedureName NVARCHAR(200),
    @pStepName NVARCHAR(100),
    @pMessage NVARCHAR(MAX),
    @pParameters NVARCHAR(MAX) = NULL,
    @pExecutionTimeMs INT = NULL,
    @pRowCount INT = NULL,
    @pErrorMessage NVARCHAR(MAX) = NULL,
    @pSeverity INT = 1
AS
BEGIN
    INSERT INTO DebugLog (
        ProcedureName,
        StepName,
        Message,
        Parameters,
        ExecutionTimeMs,
        RowCount,
        ErrorMessage,
        Severity
    ) VALUES (
        @pProcedureName,
        @pStepName,
        @pMessage,
        @pParameters,
        @pExecutionTimeMs,
        @pRowCount,
        @pErrorMessage,
        @pSeverity
    )
END
GO

-- View để xem debug log
CREATE VIEW vwDebugLog
AS
SELECT 
    LogTime,
    ProcedureName,
    StepName,
    Message,
    Parameters,
    ExecutionTimeMs,
    RowCount,
    ErrorMessage,
    CASE Severity
        WHEN 1 THEN 'INFO'
        WHEN 2 THEN 'WARNING'
        WHEN 3 THEN 'ERROR'
        ELSE 'UNKNOWN'
    END AS SeverityText
FROM DebugLog
GO

-- ============================================
-- 10. VÍ DỤ SỬ DỤNG
-- ============================================

/*
-- 1. Debug một procedure cụ thể
EXEC spDebug_ExecuteProcedure 'asAPGetTT', '@pMa_cty = ''001'', @pMa_ct = '''''

-- 2. Xem parameters của procedure
EXEC spDebug_GetProcedureParameters 'asAPGetTT'

-- 3. Xem dependencies
EXEC spDebug_GetProcedureDependencies 'asAPGetTT'

-- 4. Test procedure với các bộ parameters
EXEC spDebug_TestProcedure 'asAPGetTT', '[{"params": "@pMa_cty = ''001'', @pMa_ct = ''''", "expectedRows": 5}]'

-- 5. Check blocking
EXEC spDebug_CheckBlocking

-- 6. Xem index usage
EXEC spDebug_GetProcedureIndexUsage 'asAPGetTT'

-- 7. Sử dụng debug logging trong procedure
CREATE PROCEDURE asExampleWithDebug
    @pParam1 NVARCHAR(10)
AS
BEGIN
    EXEC spDebug_Log 'asExampleWithDebug', 'Start', 'Procedure started', @pParam1
    
    -- Business logic
    SELECT * FROM SomeTable WHERE Column1 = @pParam1
    
    EXEC spDebug_Log 'asExampleWithDebug', 'End', 'Procedure completed', @pParam1, NULL, @@ROWCOUNT
END
*/

-- ============================================
-- CLEANUP (nếu cần)
-- ============================================
/*
-- Xóa các debug objects
DROP PROCEDURE IF EXISTS spDebug_ExecuteProcedure
DROP PROCEDURE IF EXISTS spDebug_LogProcedurePerformance
DROP TABLE IF EXISTS ProcedurePerformanceLog
DROP VIEW IF EXISTS vwProcedurePerformance
DROP PROCEDURE IF EXISTS spDebug_GetProcedureDependencies
DROP PROCEDURE IF EXISTS spDebug_GetProcedureExecutionPlan
DROP PROCEDURE IF EXISTS spDebug_GetProcedureParameters
DROP PROCEDURE IF EXISTS spDebug_TestProcedure
DROP PROCEDURE IF EXISTS spDebug_CheckBlocking
DROP PROCEDURE IF EXISTS spDebug_GetProcedureIndexUsage
DROP PROCEDURE IF EXISTS spDebug_Log
DROP TABLE IF EXISTS DebugLog
DROP VIEW IF EXISTS vwDebugLog
*/