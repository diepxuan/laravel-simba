# FA (Fixed Asset) - Tài Sản Cố Định

Module quản lý tài sản cố định (TSCĐ) và công cụ dụng cụ (CCDC).

---

## Chức năng chính

1. **Quản lý TSCĐ** (DmTs)
   - Ghi tăng TSCĐ
   - Điều chỉnh TSCĐ
   - Thanh lý TSCĐ

2. **Quản lý CCDC** (DmCc)
   - Ghi nhận CCDC
   - Phân bổ CCDC

3. **Khấu hao TSCĐ** (KhTs)
   - Tính khấu hao định kỳ
   - Thôi khấu hao

4. **Báo cáo**
   - Báo cáo khấu hao
   - Báo cáo tài sản

---

## Tables chính

| Table | Mô tả |
|-------|-------|
| FaDmTs | Danh mục TSCĐ |
| FaDmCc | Danh mục CCDC |
| FaDmNhts | Danh mục nhóm TSCĐ |
| FaDmBpsd | Bộ phận sử dụng |
| FaDmLk | Liên kết TSCĐ |
| FaDmNv | Nguyên nhân |
| FaKhTs | Khấu hao TSCĐ |
| FaDtsd | Điều chỉnh TSCĐ |
| FaGiamTs | Giảm TSCĐ |
| FaThoiKhTs | Thôi khấu hao |

---

## Stored Procedures (57 SPs)

### Danh mục TSCĐ (DmTs)
| SP | Chức năng |
|----|-----------|
| asFAGetDMTS | Lấy danh mục TSCĐ |
| asFAInsDMTS | Thêm TSCĐ |
| asFAUpdDMTS | Cập nhật TSCĐ |
| asFADelDMTS | Xóa TSCĐ |
| asFAChkDMTS | Kiểm tra TSCĐ |

### Danh mục CCDC (DmCc)
| SP | Chức năng |
|----|-----------|
| asFAGetDMCC | Lấy danh mục CCDC |
| asFAInsDMCC | Thêm CCDC |
| asFAUpdDMCC | Cập nhật CCDC |
| asFADelDMCC | Xóa CCDC |

### Danh mục nhóm TSCĐ (DmNhts)
| SP | Chức năng |
|----|-----------|
| asFAGetDMNHTS | Lấy nhóm TSCĐ |
| asFAInsDMNHTS | Thêm nhóm TSCĐ |
| asFAUpdDMNHTS | Cập nhật nhóm TSCĐ |
| asFADelDMNHTS | Xóa nhóm TSCĐ |

### Khấu hao TSCĐ (KhTs)
| SP | Chức năng |
|----|-----------|
| asFAGetKHTS | Lấy khấu hao |
| asFAInsKHTS | Thêm khấu hao |
| asFAUpdKHTS | Cập nhật khấu hao |
| asFADelKHTS | Xóa khấu hao |
| asFACalKHTS | Tính khấu hao |
| asFAPostKHTS | Post khấu hao sang GL |

### Điều chỉnh TSCĐ (Dtsd)
| SP | Chức năng |
|----|-----------|
| asFAGetDTSD | Lấy điều chỉnh |
| asFAInsDTSD | Thêm điều chỉnh |
| asFAUpdDTSD | Cập nhật điều chỉnh |
| asFADelDTSD | Xóa điều chỉnh |
| asFAChkDTSD | Kiểm tra điều chỉnh |

### Giảm TSCĐ (GiamTs)
| SP | Chức năng |
|----|-----------|
| asFAGetGiamTS | Lấy giảm TSCĐ |
| asFAInsGiamTS | Thêm giảm TSCĐ |
| asFAUpdGiamTS | Cập nhật giảm TSCĐ |
| asFADelGiamTS | Xóa giảm TSCĐ |
| asFAChkGiamTs | Kiểm tra giảm TSCĐ |

### Thôi khấu hao (ThoiKhTs)
| SP | Chức năng |
|----|-----------|
| asFAGetThoiKHTS | Lấy thôi khấu hao |
| asFAInsThoiKHTS | Thêm thôi khấu hao |
| asFAUpdThoiKHTS | Cập nhật thôi khấu hao |
| asFADelThoiKHTS | Xóa thôi khấu hao |
| asFAChkThoiKHTS | Kiểm tra thôi khấu hao |

### Báo cáo
| SP | Chức năng |
|----|-----------|
| asFARptKHTS | Báo cáo khấu hao |
| asFARptTSCD | Báo cáo TSCĐ |
| asFARptCCDC | Báo cáo CCDC |

---

## Luồng xử lý

### 1. Ghi tăng TSCĐ
```
Nhập thông tin TSCĐ mới
    ↓
asFAInsDMTS (Thêm vào danh mục)
    ↓
Tính khấu hao lần đầu → asFACalKHTS
    ↓
Post sang GL → asFAPostKHTS
```

### 2. Tính khấu hao định kỳ
```
Chọn kỳ tính khấu hao
    ↓
asFACalKHTS (Tính cho tất cả TSCĐ)
    ↓
Duyệt và post → asFAPostKHTS
    ↓
Cập nhật GL
```

### 3. Thanh lý TSCĐ
```
Chọn TSCĐ thanh lý
    ↓
asFAInsGiamTS (Ghi nhận giảm)
    ↓
Tính giá trị còn lại
    ↓
Post sang GL → asFAPostGiamTS
    ↓
Cập nhật trạng thái TSCĐ
```

---

## Liên kết module

- **GL**: Post khấu hao, giảm TSCĐ sang sổ cái
- **CO**: Tính giá thành có sử dụng TSCĐ

---

## Technical Reference

| Document | Description |
|----------|-------------|
| [Stored Procedures](./procedures.md) | Chi tiết tất cả stored procedures |
| [Database Schema](../../dbo/Tables/) | Cấu trúc bảng dữ liệu |
| [Module Index](../../catalog/PROCEDURES.md) | Danh mục procedures |

## Related Modules

| Module | Description |
|--------|-------------|
| [GL](../GL/) | General Ledger - Sổ cái |
| [CO](../CO/) | Manufacturing - Sản xuất |

---

## Xem thêm

- [procedures/procedures-fa.md](../procedures/procedures-fa.md) - Chi tiết SP
- [WORKFLOWS.md](../WORKFLOWS.md) - Luồng tài sản
