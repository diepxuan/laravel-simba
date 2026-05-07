# asARGetDMKH - Lấy danh mục khách hàng

## 1. Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| **Tên SP** | `asARGetDMKH` |
| **Module** | AR (Accounts Receivable) |
| **Chức năng** | Lấy danh sách khách hàng theo điều kiện lọc |
| **Author** | TRANGNT |
| **Created** | Dec 17 2009 |
| **Loại** | Dynamic SQL (sp_executesql) |

---

## 2. Mục đích

Stored Procedure trả về danh sách khách hàng (danh mục khách hàng) từ bảng `ARDMKH`, kết hợp với các bảng danh mục liên quan để lấy đầy đủ thông tin mô tả.

**Được gọi bởi:** Form `ARDMKH.dll` (frmARDMKH) - màn hình Danh mục khách hàng trong module AR.

---

## 3. Parameters

| Parameter | Kiểu | Default | Mô tả |
|-----------|------|---------|-------|
| `@pMa_cty` | `NVARCHAR(3)` | `NULL` | Mã công ty. Nếu NULL → lấy tất cả (`%`) |
| `@pMa_kh` | `NVARCHAR(20)` | `NULL` | Mã khách hàng. Nếu NULL → lấy tất cả (`%`). Lọc theo prefix (LIKE `@pMa_kh + '%'`) |
| `@pStruct` | `NVARCHAR(1)` | `'0'` | Cấu trúc phân cấp. Giá trị `'0'` = không phân cấp, lấy phẳng |
| `@pModuleId` | `NVARCHAR(2)` | `''` | Module gọi. Dùng để lọc theo loại đối tượng: `AR`, `AP`, `CA` |

### Giá trị @pModuleId

| Giá trị | Ý nghĩa | Điều kiện thêm vào WHERE |
|---------|---------|---------------------------|
| `AR` | Khách hàng bán | `iskh = 1` |
| `AP` | Nhà cung cấp | `isNcc = 1` |
| `CA` | Nhân viên / đối tượng tiền mặt | `isnv = 1` |
| `''` (rỗng) | Tất cả | Không thêm điều kiện |

---

## 4. Tables liên quan

### 4.1 Bảng chính

| Table | Alias | Mô tả |
|-------|-------|-------|
| `ARDMKH` | `a` | Danh mục khách hàng (bảng chính) |

### 4.2 Bảng JOIN

| Table | Alias | Kiểu JOIN | Điều kiện JOIN | Mô tả |
|-------|-------|-----------|----------------|-------|
| `ARDMNHKH` | `b` | LEFT JOIN | `ma_cty` + `ma_nhkh` | Nhóm khách hàng → lấy `ten_nhkh` |
| `ARDMKHNH` | `nh` | LEFT JOIN | `ma_cty` + `ma_kh` + `ngam_dinh = 1` | Ngân hàng mặc định của khách hàng → lấy `ten_nh` |
| `ARDMPLKH` | `pl1, pl2, pl3` | LEFT JOIN × 3 | `ma_cty` + `ma_plkh[1/2/3]` + `loai = '1/2/3'` | Phân loại khách hàng (3 cấp) → lấy `ten_plkh` |
| `GLDMTK` | `tk` | LEFT JOIN | `ma_cty` + `tk` | Danh mục tài khoản GL → lấy `ten_tk` |
| `SIDMHTTT` | `ht` | LEFT JOIN | `ma_cty` + `ma_httt` + `moduleid = 'SO'` | Hình thức thanh toán bán hàng → lấy `ten_httt` |
| `SIDMHTTT` | `ht1` | LEFT JOIN | `ma_cty` + `ma_httt_po` + `moduleid = 'PO'` | Hình thức thanh toán mua hàng → lấy `ten_httt_po` |
| `SODMTT` | `ar` | LEFT JOIN | `ma_cty` + `ma_tt` | Danh mục điều khoản thanh toán → lấy `mo_ta` |

---

## 5. Output Columns

SP trả về **48 cột**, chia theo nhóm:

### 5.1 Thông tin cơ bản

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `ma_cty` | NVARCHAR(3) | a.ma_cty | Mã công ty |
| `ma_kh` | NVARCHAR(20) | a.ma_kh | Mã khách hàng |
| `loai` | NVARCHAR(1) | a.loai | Loại khách hàng |
| `ten_kh` | NVARCHAR(100) | a.ten_kh | Tên khách hàng |
| `ma_so_thue` | NVARCHAR(20) | a.ma_so_thue | Mã số thuế |
| `dia_chi` | NVARCHAR(255) | a.dia_chi | Địa chỉ |
| `tel` | NVARCHAR(30) | a.tel | Điện thoại |
| `fax` | NVARCHAR(30) | a.fax | Fax |
| `email` | NVARCHAR(30) | a.email | Email |
| `home_page` | NVARCHAR(30) | a.home_page | Website |
| `nguoi_gd` | NVARCHAR(30) | a.nguoi_gd | Người giao dịch |

### 5.2 Ngân hàng

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `so_tk_nh` | NVARCHAR(20) | a.so_tk_nh | Số tài khoản ngân hàng |
| `ten_nh` | NVARCHAR(50) | nh.ten_ngh | Tên ngân hàng (từ ARDMKHNH, ngân hàng mặc định) |
| `tinh_tp_nh` | NVARCHAR(50) | a.tinh_tp_nh | Tỉnh/thành phố ngân hàng |

### 5.3 Tài khoản kế toán

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `tk` | NVARCHAR(20) | a.tk | Mã tài khoản GL |
| `ten_tk` | VARCHAR | tk.ten_tk | Tên tài khoản GL |

### 5.4 Phân loại khách hàng

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `ma_plkh1` | NVARCHAR(8) | a.ma_plkh1 | Mã phân loại 1 |
| `ten_plkh1` | VARCHAR | pl1.ten_plkh | Tên phân loại 1 (loại = '1') |
| `ma_plkh2` | NVARCHAR(8) | a.ma_plkh2 | Mã phân loại 2 |
| `ten_plkh2` | VARCHAR | pl2.ten_plkh | Tên phân loại 2 (loại = '2') |
| `ma_plkh3` | NVARCHAR(8) | a.ma_plkh3 | Mã phân loại 3 |
| `ten_plkh3` | VARCHAR | pl3.ten_plkh | Tên phân loại 3 (loại = '3') |

### 5.5 Nhóm & điều khoản

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `ma_nhkh` | NVARCHAR(8) | a.ma_nhkh | Mã nhóm khách hàng |
| `ten_nhkh` | VARCHAR | b.ten_nhkh | Tên nhóm khách hàng |
| `ma_tt` | NVARCHAR(8) | a.ma_tt | Mã điều khoản thanh toán |
| `ten_tt` | VARCHAR | ar.mo_ta | Mô tả điều khoản thanh toán |

### 5.6 Hình thức thanh toán

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `ma_httt` | NVARCHAR(20) | a.ma_httt | Mã HTT thanh toán (SO) |
| `ten_httt` | VARCHAR | ht.ten_httt | Tên HTT thanh toán bán hàng |
| `ma_httt_po` | NVARCHAR(20) | a.ma_httt_po | Mã HTT thanh toán (PO) |
| `ten_httt_po` | VARCHAR | ht1.ten_httt | Tên HTT thanh toán mua hàng |

### 5.7 Tín dụng & công nợ

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `gh_no` | DECIMAL(19,4) | a.gh_no | Giới hạn nợ (credit limit) |
| `han_ck` | DECIMAL(19,4) | a.han_ck | Hạn chiết khấu |
| `tl_ck` | DECIMAL(19,4) | a.tl_ck | Tỷ lệ chiết khấu |
| `han_tt` | DECIMAL(19,4) | a.han_tt | Hạn thanh toán |
| `ls_qh` | DECIMAL(19,4) | a.ls_qh | Lãi suất quá hạn |

### 5.8 Flags & audit

| Cột | Kiểu | Nguồn | Mô tả |
|-----|------|-------|-------|
| `ghi_chu` | NVARCHAR(255) | a.ghi_chu | Ghi chú |
| `tinh_dt_nb` | BIT | a.tinh_dt_nb | Tính điện tử nội bộ |
| `iskh` | BIT | a.iskh | Flag: là khách hàng |
| `isncc` | BIT | a.isncc | Flag: là nhà cung cấp |
| `isnv` | BIT | a.isnv | Flag: là nhân viên |
| `ksd` | BIT | a.ksd | Khóa sử dụng |
| `cdate` | SMALLDATETIME | a.cdate | Ngày tạo |
| `cuser` | NVARCHAR(20) | a.cuser | Người tạo |
| `ldate` | SMALLDATETIME | a.ldate | Ngày sửa |
| `luser` | NVARCHAR(20) | a.luser | Người sửa |

---

## 6. Logic thực thi

### 6.1 Xử lý tham số

```
NULL → '%'    (wildcard, lấy tất cả)
```

### 6.2 Dynamic SQL

SP sử dụng **dynamic SQL** với `sp_executesql`:

1. Xây dựng câu query cơ bản với 8 LEFT JOIN
2. Thêm điều kiện lọc theo `@pModuleId`:
   - `@pModuleId = 'CA'` → `AND isnv = 1`
   - `@pModuleId = 'AR'` → `AND iskh = 1`
   - `@pModuleId = 'AP'` → `AND isNcc = 1`
3. Thực thi bằng `sp_executesql` với parameterized query

### 6.3 WHERE clause cuối cùng

```sql
WHERE a.ma_cty LIKE @pMa_cty + '%'
  AND a.ma_kh  LIKE @pMa_kh + '%'
  AND @pStruct = '0'
  [AND iskh = 1 | AND isncc = 1 | AND isnv = 1]  ← tùy @pModuleId
```

---

## 7. Workflow position

```
[User mở form ARDMKH]
        ↓
[Form gọi asARGetDMKH]
        ↓
  ┌─────────────────┐
  │  @pModuleId     │
  │  = 'AR' → khách│
  │  = 'AP' → NCC  │
  │  = 'CA' → NV   │
  └────────┬────────┘
           ↓
  [LEFT JOIN 8 tables]
           ↓
  [WHERE: ma_cty, ma_kh, module filter]
           ↓
  [Trả về dataset → DataGridView]
```

---

## 8. Caller / Được gọi bởi

| Caller | Loại | Mô tả |
|--------|------|-------|
| `ARDMKH.dll` (frmARDMKH) | Windows Form | Form Danh mục khách hàng, module AR |
| Các form lookup khách hàng | Windows Form | Tìm kiếm khách hàng từ module khác |

---

## 9. Dependencies

### Tables
- `ARDMKH` - Danh mục khách hàng
- `ARDMNHKH` - Danh mục nhóm khách hàng
- `ARDMKHNH` - Danh mục ngân hàng khách hàng
- `ARDMPLKH` - Danh mục phân loại khách hàng
- `GLDMTK` - Danh mục tài khoản GL
- `SIDMHTTT` - Danh mục hình thức thanh toán
- `SODMTT` - Danh mục điều khoản thanh toán

### SP liên quan
- `asARGetDMKH` → không gọi SP con nào (trả về trực tiếp)

---

## 10. Ghi chú kỹ thuật

- **Dynamic SQL**: Dùng `sp_executesql` để parameterized query, tránh SQL injection
- **LEFT JOIN**: Tất cả JOIN đều là LEFT JOIN → customer vẫn trả về ngay cả khi thiếu dữ liệu ở bảng phụ
- **ARDMKHNH JOIN**: Chỉ lấy ngân hàng mặc định (`ngam_dinh = 1`)
- **ARDMPLKH JOIN**: Join 3 lần với điều kiện `loai = '1/2/3'` để lấy tên phân loại theo cấp
- **SIDMHTTT JOIN**: Join 2 lần - 1 cho SO (`moduleid = 'SO'`), 1 cho PO (`moduleid = 'PO'`)
- **ISNULL**: `ten_httt` và `ten_httt_po` dùng ISNULL để tránh NULL khi không có hình thức thanh toán
- **Bug tiềm ẩn**: Trong query JOIN `pl2` và `pl3`, điều kiện kiểm tra `pl1.loai = '2'` và `pl1.loai = '3'` (đáng lẽ nên là `pl2.loai` và `pl3.loai`). Đây là bug copy-paste trong code gốc.

---

## 11. Ví dụ sử dụng

### Lấy tất cả khách hàng
```sql
EXEC asARGetDMKH @pMa_cty = NULL, @pMa_kh = NULL, @pStruct = '0', @pModuleId = 'AR'
```

### Tìm khách hàng theo mã
```sql
EXEC asARGetDMKH @pMa_cty = 'A07', @pMa_kh = 'KH001', @pStruct = '0', @pModuleId = 'AR'
```

### Lấy nhà cung cấp (dùng cho module AP)
```sql
EXEC asARGetDMKH @pMa_cty = 'A07', @pMa_kh = '', @pStruct = '0', @pModuleId = 'AP'
```

### Lấy nhân viên (dùng cho module CA)
```sql
EXEC asARGetDMKH @pMa_cty = 'A07', @pMa_kh = '', @pStruct = '0', @pModuleId = 'CA'
```
