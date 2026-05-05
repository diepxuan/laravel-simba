# OptFieldInfo.dll - Optional Field Information

## Tong quan

| Thuoc tinh | Gia tri |
|------------|---------|
| **Module** | Common (Field Configuration) |
| **Loai** | Windows Forms Class Library |
| **Chuc nang** | Form xem danh sach cac truong tuy chon (optional fields) - hien thi thong tin ten truong, dien giai, do dai, tieu de |
| **Assembly** | OptFieldInfo v1.0.0.0 |
| **Framework** | .NET Framework 3.5 |
| **Namespace** | AsiaErp.UserInterface, AsiaErp.DataAccess |
| **GUID** | 9b304409-4ff6-4cbc-8537-d3c362024ff9 |

## Dependencies

| Assembly | Muc dich |
|----------|----------|
| AsiaErp.Framework | Framework base (frmAsiaRoot, AsDataGridView) |
| AsiaErp.Helper | Helper utilities |
| System.Data | Data access |
| Microsoft.VisualBasic | VB runtime support |

## File Structure

```
OptFieldInfo.dll/
├── OptFieldInfo.csproj
├── app.ico
├── Properties/
│   └── AssemblyInfo.cs
├── AsiaErp.UserInterface/
│   └── frmOptFieldInfo.cs      # Main form
├── AsiaErp.DataAccess/
│   ├── OptFieldDAO.cs          # DAO Interface
│   └── MsSqlOptFieldDAO.cs     # SQL Server implementation
└── My/
    ├── MyApplication.cs
    ├── MyComputer.cs
    ├── MyProject.cs
    ├── MySettings.cs
    └── MySettingsProperty.cs
```

## Forms

### frmOptFieldInfo

| Thuoc tinh | Chi tiet |
|------------|----------|
| **Ke thua** | frmAsiaRoot |
| **Muc dich** | Form hien thi danh sach truong tuy chon (optional fields) |

**Controls:**

| Control | Loai | Muc dich |
|---------|------|----------|
| dgvOpt | AsDataGridView | Grid hien thi danh sach truong |
| cmdOk | Button | OK / Thoat |
| cmdExit | Button | Thoat |

**DataGridView Columns:**

| Column | DataPropertyName | HeaderText | ReadOnly | Mieu ta |
|--------|------------------|------------|----------|---------|
| Column5 | Stt | STT | Yes | So thu tu (hidden) |
| Column1 | Field | Ten truong | Yes | Ten truong du lieu |
| Column2 | descrpt | Dien giai | Yes | Mo ta truong |
| Column3 | length | Do dai | Yes | Do dai truong |
| Column4 | caption | Tieu de | Yes | Tieu de hien thi |
| Column6 | - | Column6 | Yes | Phu (hidden) |

**Fields:**

| Field | Kieu | Muc dich |
|-------|------|----------|
| f_dmopt | DataTable | Du lieu danh muc optional fields |
| a_blnIsSysDB | bool | Ket noi voi system database |

## DataAccess Classes

### OptFieldDAO (Interface)

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetOptField | - | DataTable | Lay danh sach optional fields |

### MsSqlOptFieldDAO

| Method | Input | Output | Muc dich |
|--------|-------|--------|----------|
| GetOptField | - | DataTable | Goi store procedure lay danh sach truong tuy chon |

**Stored Procedures su dung:**

| SP Name | Muc dich |
|---------|----------|
| asGetOptFieldInfo | Lay thong tin cac truong tuy chon |

## Business Logic

1. **Form Load**:
   - Goi MsSqlOptFieldDAO.GetOptField()
   - Bind du lieu vao dgvOpt
   - Hien thi cac cot: STT, Ten truong, Dien giai, Do dai, Tieu de
2. **User Interaction**:
   - Xem danh sach truong tuy chon
   - Khong co chuc nang sua (chi doc)
3. **Exit**: Dong form

## Ket luan

OptFieldInfo.dll la module **chi doc** de xem danh sach cac truong tuy chon (optional fields) trong he thong. Khong co chuc nang cap nhat - chi hien thi thong tin. Day la module ho tro cho OptFieldSetup.dll (module cau hinh truong tuy chon).
