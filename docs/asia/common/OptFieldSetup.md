# OptFieldSetup.dll - Optional Field Setup

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common (Field Configuration) |
| **Loai** | Windows Forms Class Library |
| **Chuc nang** | Form cau hinh truong tuy chon (optional fields) cho chung tu - cho phep chon hien thi truong o phan thong tin chung (Master) va phan chi tiet (Detail) |
| **Assembly** | OptFieldSetup v1.0.0.0 |
| **Framework** | .NET Framework 3.5 |
| **Namespace** | AsiaErp.UserInterface, AsiaErp.DataAccess |
| **GUID** | 9b304409-4ff6-4cbc-8537-d3c362024ff9 |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| AsiaErp.Framework | Framework base (frmAsiaRoot, AsDataGridView, AsComboBox) |
| AsiaErp.Helper | Helper utilities |
| System.Data | Data access |
| Microsoft.VisualBasic | VB runtime support |

## File Structure

```
OptFieldSetup.dll/
├── OptFieldSetup.csproj
├── app.ico
├── Properties/
│   └── AssemblyInfo.cs
├── AsiaErp.UserInterface/
│   └── frmOptFieldSetup.cs     # Main form
├── AsiaErp.DataAccess/
│   ├── FieldSetupDAO.cs        # DAO Interface
│   └── MsSqlFieldSetupDAO.cs   # SQL Server implementation
└── My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

## Forms

### frmOptFieldSetup

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | frmAsiaRoot |
| **Muc dich** | Form cau hinh hien thi truong tuy chon cho tung loai chung tu |

**Controls:**

| Control | Loai | Muc dich |
|---------|------|----------|
| cboChung_tu | AsComboBox | Chon loai chung tu |
| dgvOpt | AsDataGridView | Grid hien thi va cau hinh truong |
| cmdOk | Button | Luu cau hinh |
| cmdExit | Button | Thoat |
| cmdSua | Button | Chuyen sang che do sua |
| cmdHuy | Button | Huy thay doi |
| Label1 | Label | Nhan "Chung tu" |

**DataGridView Columns:**

| Column | DataPropertyName | HeaderText | Type | ReadOnly | Mieu ta |
|--------|------------------|------------|------|----------|---------|
| Column5 | Stt | Stt | TextBox | Yes | So thu tu (hidden) |
| Column8 | Caption | Tieu de | TextBox | Yes | Tieu de truong |
| Column4 | Field | Ten truong | TextBox | Yes | Ten truong du lieu |
| Column6 | descrpt | - | TextBox | Yes | Dien giai (hidden) |
| Column7 | length | - | TextBox | Yes | Do dai (hidden) |
| Column9 | LUser | - | TextBox | Yes | Nguoi dung (hidden) |
| Column1 | Voucher_code | - | TextBox | Yes | Ma chung tu (hidden) |
| Column2 | Master | Thong tin chung | CheckBox | **No** | Hien thi o phan Master |
| Column3 | Detail | Chi tiet | CheckBox | **No** | Hien thi o phan Detail |

**Fields:**

| Field | Kieu | Muc dich |
|-------|------|----------|
| f_dmopt | DataTable | Danh sach truong tuy chon |
| f_oTblCbo | DataTable | Danh muc chung tu (cho combobox) |
| a_blnIsSysDB | bool | Ket noi system database |

## DataAccess Classes

### FieldSetupDAO (Interface)

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetFieldSetup | pVoucher_code | DataTable | Lay cau hinh truong cho chung tu |
| GetFieldInfo | - | DataTable | Lay danh sach truong tuy chon |
| GetCt | pMa_cty, pMa_ct | DataTable | Lay danh muc chung tu |
| UpdFieldSetup | pVoucher_code, pField, pMaster, pDetail | int | Cap nhat cau hinh |
| InsFieldSetup | pVoucher_code, pField, pMaster, pDetail | int | Them cau hinh moi |
| DelFieldSetup | pVoucher_code, pField | int | Xoa cau hinh |

### MsSqlFieldSetupDAO

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetFieldSetup | pVoucher_code | DataTable | Goi SP asGetOptFieldSetup |
| GetFieldInfo | - | DataTable | Goi SP asGetOptFieldInfo |
| GetCt | pMa_cty, pMa_ct | DataTable | Goi SP asSIGetDMCT |
| UpdFieldSetup | ... | int | Goi SP asUpdOptFieldSetup |
| InsFieldSetup | ... | int | Goi SP asInsOptFieldSetup |
| DelFieldSetup | ... | int | Goi SP asDelOptFieldSetup |

**Stored Procedures su dung:**

| SP Name | Muc dich |
|---------|----------|
| asGetOptFieldInfo | Lay thong tin cac truong tuy chon |
| asGetOptFieldSetup | Lay cau hinh hien tai cho chung tu |
| asSIGetDMCT | Lay danh muc chung tu |
| asUpdOptFieldSetup | Cap nhat cau hinh truong |
| asInsOptFieldSetup | Them cau hinh truong moi |
| asDelOptFieldSetup | Xoa cau hinh truong |

## Business Logic

1. **Form Load**:
   - Goi GetFieldInfo() -> lay danh sach truong vao f_dmopt
   - Goi GetCt() -> load danh muc chung tu vao cboChung_tu
   - Hien thi o che do chi doc (ReadOnly)

2. **Chung tu Selection (cboChung_tu.SelectedIndexChanged)**:
   - Lay cau hinh hien tai: GetFieldSetup(voucher_code)
   - Merge voi danh sach truong de hien thi trang thai checkboxes
   - Hien thi len dgvOpt

3. **Che do sua (cmdSua_Click)**:
   - An cmdSua, hien cmdOk + cmdHuy
   - cboChung_tu.ReadOnly = true
   - dgvOpt cho phep chinh sửa checkboxes Master/Detail

4. **Luu (cmdOk_Click)**:
   - Voi moi row co Master hoac Detail = true:
     - Goi InsFieldSetup(voucher_code, field, master, detail)
   - Hien thong bao thanh cong
   - Tro ve che do xem

5. **Huy (cmdHuy_Click)**:
   - Hien lai cmdSua, an cmdOk + cmdHuy
   - cboChung_tu.ReadOnly = false
   - Reload du lieu

## Ket luan

OptFieldSetup.dll la module **cau hinh truong tuy chon** cho phep admin cau hinh hien thi cua cac optional fields tren form chung tu. Moi chung tu co the co cau hinh rieng, voi 2 vi tri hien thi: Master (thong tin chung) va Detail (chi tiet). Day la module quan trong trong he thong tuy bien cua Asia ERP, cho phep linh hoat hien thi cac truong mo ma.
