# SMFFY.dll - Thiết lập Ngày Đầu Năm Tài Chính

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Module | SMFFY |
| Loại | System/Infrastructure (SI) |
| Chức năng | Thiết lập ngày đầu năm tài chính |
| Assembly | SMFFY.dll |
| Namespace | AsiaERP.UserInterface, AsiaERP.DataAccess |
| Base class | `frmCalc` (UI), `MsSqlDAO` (DataAccess) |
| Framework | .NET Framework |

## Mô tả

Module cho phép người dùng thiết lập **ngày đầu năm tài chính mới** (`Ngay_DnTc`). Khi khóa số liệu cuối năm, hệ thống cần biết ngày bắt đầu của năm tài chính tiếp theo để mở kỳ kế toán mới.

## Forms

### frmSMFFY

Form chính để nhập ngày đầu năm tài chính.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `txtNgay_dntc` | AsMaskedTextBox | Nhập ngày đầu năm (mask: `dd/MM/yyyy`) |
| `cmdOK` | Button | Xác nhận lưu |
| `cmdCancel` | Button | Hủy |

#### Properties

| Property | Giá trị |
|----------|---------|
| `Text` | "Khóa số liệu" |
| `FormBorderStyle` | FixedDialog |
| `MaximizeBox` | false |
| `MinimizeBox` | false |

#### Business Logic

| Method | Mô tả |
|--------|-------|
| `InitComponents()` | Load `Ngay_DnTc` từ `Environment.GetSIConfiguration()` |
| `cmdOK_Click()` | Validate và gọi SP `asSiUpd_Ngay_dntc` để cập nhật |

## DataAccess

### Interface: SMFFYDAO

| Method | Tham số | Return | Stored Procedure |
|--------|---------|--------|------------------|
| `Update` | `ngay_ks` (DateTime) | int | `asSiUpdFirstFinancialYear` |

### MsSqlSMFFYDAO

Implementation của `SMFFYDAO`, kế thừa `MsSqlDAO`.

| Method | Mô tả |
|--------|-------|
| `Update(DateTime ngay_ks)` | Gọi SP `asSiUpdFirstFinancialYear` với param `@pNgay_ks` |

## Luồng xử lý

```
1. Mở frmSMFFY → Load ngay_ks từ SIConfiguration
2. Người dùng nhập ngày đầu năm tài chính mới
3. Click OK → Gọi Commons.ExecuteStoredProcedure("asSiUpd_Ngay_dntc")
4. Cập nhật Environment.GetSIConfiguration().Ngay_DnTc
5. Đóng form
```

## Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework.dll | Base classes (frmCalc, Environment, Commons) |
| Helper.dll | Utility functions |

## Ghi chú

- Module này **không** sử dụng DAO pattern như SMKS, mà gọi trực tiếp `Commons.ExecuteStoredProcedure`
- SP `asSiUpdFirstFinancialYear` được định nghĩa trong MsSqlSMFFYDAO nhưng thực tế form gọi `asSiUpd_Ngay_dntc` qua Commons
- Form kế thừa từ `frmCalc` - base class cho các form tính toán/xử lý đặc biệt
