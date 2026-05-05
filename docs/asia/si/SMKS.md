# SMKS.dll - Khóa Số Liệu

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Module | SMKS |
| Loại | System/Infrastructure (SI) |
| Chức năng | Khóa số liệu kế toán đến ngày chỉ định |
| Assembly | SMKS.dll |
| Namespace | AsiaERP.UserInterface, AsiaERP.DataAccess |
| Base class | `frmCalc` (UI), `MsSqlDAO` (DataAccess) |
| Framework | .NET Framework |

## Mô tả

Module cho phép **khóa số liệu kế toán** đến một ngày cụ thể. Sau khi khóa, các chứng từ có ngày <= ngày khóa sẽ không thể sửa/xóa. Đây là chức năng quan trọng để chốt sổ kế toán theo kỳ.

## Forms

### frmSMKS

Form chính để thiết lập ngày khóa số liệu.

| Control | Kiểu | Mô tả |
|---------|------|-------|
| `txtNgay_ks` | AsMaskedTextBox | Nhập ngày khóa sổ (mask: `dd/MM/yyyy`) |
| `txtFinancialYear` | TextBox | Hiển thị năm tài chính hiện tại (readonly) |
| `lblNgay_ks` | Label | "Khóa sổ đến ngày" |
| `lblFinancialYear` | Label | "Năm tài chính" |
| `cmdOK` | Button | Xác nhận khóa |
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
| `InitComponents()` | Load FinancialYear từ `SystemInformations`, ngay_ks từ `SIConfiguration` |
| `cmdOK_Click()` | Gọi `SMKSDAO.Update(CompanyID, ngay_ks)` để khóa số liệu |

## DataAccess

### Interface: SMKSDAO

| Method | Tham số | Return | Stored Procedure |
|--------|---------|--------|------------------|
| `Update` | `ma_cty` (string), `ngay_ks` (DateTime) | int | `assiUpd_ks` |

### MsSqlSMKSDAO

Implementation của `SMKSDAO`, kế thừa `MsSqlDAO`.

| Method | Mô tả |
|--------|-------|
| `Update(string ma_cty, DateTime ngay_ks)` | Gọi SP `assiUpd_ks` với params `@pMa_cty`, `@pNgay_ks`, output `@pRet` |

#### Stored Procedure: assiUpd_ks

| Parameter | Direction | Mô tả |
|-----------|-----------|-------|
| `@pMa_cty` | Input | Mã công ty |
| `@pNgay_ks` | Input | Ngày khóa số liệu |
| `@pRet` | Output | Kết quả (0 = thành công) |

## Luồng xử lý

```
1. Mở frmSMKS → Load FinancialYear + ngay_ks từ cấu hình
2. Người dùng nhập ngày khóa số liệu
3. Click OK → Tạo SMKSDAO instance qua DAOFactory
4. Gọi Update(CompanyID, ngay_ks)
5. Nếu thành công (ret=0) → Refresh configuration, đóng form
6. Nếu thất bại → Hiển thị lỗi
```

## Dependencies

| Assembly | Mục đích |
|----------|----------|
| Framework.dll | Base classes (frmCalc, Environment, DAOFactory) |
| Helper.dll | Utility functions |

## Ghi chú

- Sử dụng **DAO pattern** với factory: `DAOFactory.CreateDAOInstance("SMKSDAO", "SMKS")`
- Form kế thừa từ `frmCalc` - base class cho các form tính toán/xử lý đặc biệt
- Module làm việc theo công ty (`ma_cty`), hỗ trợ multi-tenant
