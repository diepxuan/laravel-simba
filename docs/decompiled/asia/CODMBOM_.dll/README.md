# Báo cáo Phân tích DLL: CODMBOM_.dll

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
CODMBOM_.dll/
├── CODMBOM_.csproj            # Project file
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
| System.Data | Data access |
| System.Core | Core .NET functionality |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.DataAccess`, `AsiaErp.Framework`
- `System`, `System.Data`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCODMBOM` | `frmAsiaRoot` | Form quản lý định mức BOM |
| `ICODMBOMDAO` | `DAO` | Interface định nghĩa các phương thức DAO |
| `MsSqlCODMBOMDAO` | `MsSqlDAO` | Implementation DAO cho SQL Server |
| `Resources` | - | Resource manager |

---

## Chi tiết Forms

### frmCODMBOM (Main Form)
- **Kế thừa**: `frmAsiaRoot`
- **Chức năng**: Quản lý định mức nguyên vật liệu (BOM)
- **Cấu trúc tương tự CODMBOM.dll**:
  - GroupBox thông tin chung (`gbTTChung`)
  - GroupBox chi tiết vật tư (`gbChiTiet`)
  - GroupBox danh mục sản phẩm (`gbDmSp`)
  - Controls nhập liệu: Mã SP, Mã vật tư, Số lượng, Đơn giá
  - DataGridView hiển thị chi tiết và danh sách

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

### Stored Procedures

| Stored Procedure | Mục đích |
|----------------|----------|
| `asCOGetDMCobomPH` | Lấy dữ liệu BOM master |
| `asCOInsDMCoBomPH` | Insert BOM master |
| `asCOUpdDMCoBomPH` | Update BOM master |
| `asCODelDMCobomPH` | Delete BOM master |
| `asCOGetDMCobomCT` | Lấy dữ liệu BOM chi tiết |
| `asCOInsDMCobomCT` | Insert BOM chi tiết |
| `asCODelDMCobomCT` | Delete BOM chi tiết |

---

## So sánh với CODMBOM.dll

| Đặc điểm | CODMBOM.dll | CODMBOM_.dll |
|-----------|-------------|--------------|
| Assembly Name | CODMBOM | CODMBOM |
| Project file | CODMBOM.csproj | CODMBOM_.csproj |
| Dependencies | Có System.Xml.Linq | Không có System.Xml.Linq |
| Chức năng | Tương đương | Tương đương |
| GUID | Giống nhau | Giống nhau |

### Phân tích
- CODMBOM_.dll là phiên bản khác của CODMBOM.dll
- Cùng GUID (902477e4-43a5-47c4-8a65-812ad08d8235) cho thấy đây là cùng một assembly
- Có thể là phiên bản build khác nhau hoặc cho môi trường khác nhau
- Ít dependencies hơn (không cần System.Xml.Linq)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "Định mức nguyên vật liệu" - Tên chức năng
- "Mã sản phẩm", "Tên sản phẩm"
- "Mã vật tư", "Tên vật tư"
- "Số lượng", "Đơn giá nhân công"
- "Vật tư chính"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_vt` | Mã vật tư |
| `so_luong` | Số lượng định mức |
| `don_gia_luong` | Đơn giá nhân công |
| `vt_chinh` | Vật tư chính |

---

## Mục đích sử dụng

**CODMBOM_.dll là module quản lý "Định mức nguyên vật liệu (BOM)"** - phiên bản thay thế/alternative của CODMBOM.dll.

### Chức năng chính

#### 1. Quản lý BOM
- Định nghĩa cấu trúc sản phẩm (thành phần nguyên vật liệu)
- Thiết lập định mức tiêu hao cho từng vật tư
- Phân loại vật tư chính/phụ

#### 2. Tích hợp sản xuất
- Cung cấp dữ liệu cho tính giá thành
- Hỗ trợ lập kế hoạch nguyên vật liệu
- Quản lý thay đổi định mức theo thời gian

### Đặc điểm kỹ thuật

- Kiến trúc DAO pattern
- Stored procedures SQL Server
- Master-detail data binding
- AutoLookup cho mã sản phẩm/vật tư

---

## Kết luận

Đây là phiên bản alternative của module CODMBOM.dll, phục vụ cho việc quản lý định mức nguyên vật liệu (BOM) trong hệ thống ERP AsiaErp. Có cùng chức năng nhưng với cấu hình dependencies khác.

---

*Ngày phân tích: 2026-03-29*
