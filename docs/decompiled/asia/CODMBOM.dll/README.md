# Báo cáo Phân tích DLL: CODMBOM.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |
| AllowUnsafeBlocks | True |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | CODMBOM |
| Assembly Title | Định mức nguyên vật liệu |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaErp |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 902477e4-43a5-47c4-8a65-812ad08d8235 |
| ComVisible | false |

---

## Cấu trúc File

```
CODMBOM.dll/
├── CODMBOM.csproj              # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface.frmCODMBOM.resx  # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── MyComputer.cs
│   ├── MyApplication.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaErp.DataAccess/
│   ├── ICODMBOMDAO.cs         # Interface DAO
│   └── MsSqlCODMBOMDAO.cs     # SQL Server DAO implementation
└── AsiaErp.UserInterface/
    └── frmCODMBOM.cs          # Main form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Xml.Linq | XML LINQ support |
| System.Data | Data access |
| System.Core | Core .NET functionality |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.DataAccess`, `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Linq`, `System.Collections.Generic`
- `Microsoft.VisualBasic.CompilerServices`
- `My.Resources`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCODMBOM` | `frmAsiaRoot` | Form quản lý định mức BOM (Bill of Materials) |
| `ICODMBOMDAO` | `DAO` | Interface định nghĩa các phương thức DAO |
| `MsSqlCODMBOMDAO` | `MsSqlDAO` | Implementation DAO cho SQL Server |
| `Resources` | - | Resource manager |

---

## Chi tiết Forms

### frmCODMBOM (Main Form)
- **Kế thừa**: `frmAsiaRoot`
- **Chức năng**: Quản lý định mức nguyên vật liệu (BOM)
- **Controls chính**:
  - `gbTTChung`: GroupBox thông tin chung
  - `gbChiTiet`: GroupBox chi tiết vật tư
  - `gbDmSp`: GroupBox danh mục sản phẩm
  - `txtMa_sp`: Mã sản phẩm (AsTextBox, AutoLookup)
  - `lblTen_sp`: Tên sản phẩm
  - `txtSDate`, `txtEDate`: Ngày bắt đầu/kết thúc hiệu lực (AsMaskedTextBox)
  - `txtDon_gia_luong`: Đơn giá nhân công (AsTextNumeric)
  - `txtGhi_Chu`: Ghi chú
  - `txtMa_vt`: Mã vật tư (AsTextBox, AutoLookup)
  - `txtSo_luong`: Số lượng vật tư (AsTextNumeric)
  - `chkVt_chinh`: CheckBox vật tư chính (AsCheckBox)
  - `dgvCTVT`: DataGridView chi tiết vật tư
  - `dgvListVt`: DataGridView danh sách vật tư
  - `cmdAdd`, `cmdDel`, `cmdEdit`: Nút thao tác
  - `cmdFind`: Nút tìm kiếm
  - `cboFilter`, `txtSearch`: Filter controls

---

## Data Access Layer

### ICODMBOMDAO Interface

```csharp
public interface ICODMBOMDAO : DAO
{
    DataTable GetCoDmbomPH();
    int InsCoDmbomPH(DataRow oDrw);
    int UpdCoDmbomPH(DataRow oDrw);
    int DelCoDmbomPH(string pMa_spct);
    DataTable GetCoDmbomCT();
    int InsCoDmbomCT(DataRow oDrw);
    int DelCoDmbomCT(string pMa_spct, string pMa_vt);
}
```

### MsSqlCODMBOMDAO Implementation

| Method | Stored Procedure | Mục đích |
|--------|-----------------|----------|
| `GetCoDmbomPH()` | `asCOGetDMCobomPH` | Lấy dữ liệu BOM master |
| `InsCoDmbomPH()` | `asCOInsDMCoBomPH` | Insert BOM master |
| `UpdCoDmbomPH()` | `asCOUpdDMCoBomPH` | Update BOM master |
| `DelCoDmbomPH()` | `asCODelDMCobomPH` | Delete BOM master |
| `GetCoDmbomCT()` | `asCOGetDMCobomCT` | Lấy dữ liệu BOM chi tiết |
| `InsCoDmbomCT()` | `asCOInsDMCobomCT` | Insert BOM chi tiết |
| `DelCoDmbomCT()` | `asCODelDMCobomCT` | Delete BOM chi tiết |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Định mức nguyên vật liệu" - Tên chức năng
- "Mã sản phẩm", "Tên sản phẩm"
- "Mã vật tư", "Tên vật tư"
- "Số lượng", "Đơn giá nhân công"
- "Vật tư chính", "Ghi chú"
- "Ngày hiệu lực từ", "Ngày hiệu lực đến"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_vt` | Mã vật tư |
| `so_luong` | Số lượng định mức |
| `don_gia_luong` | Đơn giá nhân công |
| `vt_chinh` | Vật tư chính |
| `ngay1` | Ngày bắt đầu hiệu lực |
| `ngay2` | Ngày kết thúc hiệu lực |
| `ghi_chu` | Ghi chú |

---

## Mục đích sử dụng

**CODMBOM.dll là module quản lý "Định mức nguyên vật liệu (BOM)"** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Quản lý BOM (Bill of Materials)
- Định nghĩa cấu trúc sản phẩm (thành phần nguyên vật liệu)
- Thiết lập định mức tiêu hao cho từng vật tư
- Phân loại vật tư chính/phụ
- Quản lý thời gian hiệu lực của định mức

#### 2. Quản lý giá nhân công
- Thiết lập đơn giá nhân công cho sản phẩm
- Hỗ trợ tính giá thành sản phẩm
- Cập nhật định kỳ đơn giá

#### 3. Tìm kiếm và Lọc
- Tìm kiếm theo mã sản phẩm
- Lọc theo tiêu chí người dùng
- Hiển thị danh sách sản phẩm và chi tiết vật tư

#### 4. Tích hợp sản xuất
- Cung cấp dữ liệu cho tính giá thành
- Hỗ trợ lập kế hoạch nguyên vật liệu
- Liên kết với module định mức chi tiết (CODD1)

### Đặc điểm kỹ thuật

- Kiến trúc DAO pattern
- Stored procedures SQL Server
- Master-detail data binding
- AutoLookup cho mã sản phẩm/vật tư
- Sử dụng My namespace (VB.NET style)

---

## Business Logic

### DataTables
- `f_tblBomPH`: DataTable chứa thông tin BOM master
- `f_tblBomCT`: DataTable chứa thông tin BOM chi tiết

### Variables
- `f_Edit`: Trạng thái chỉnh sửa
- `f_row`: DataRow hiện tại
- `f_isEditing`: Cờ đang chỉnh sửa
- `iCurrentRow`, `iCurrentCol`: Vị trí current cell

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaErp, phục vụ cho việc quản lý định mức nguyên vật liệu (BOM) - dữ liệu nền tảng cho việc tính giá thành sản phẩm và lập kế hoạch sản xuất.

---

*Ngày phân tích: 2026-03-29*
