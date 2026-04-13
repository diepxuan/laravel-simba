# Báo cáo Phân tích DLL: SODMTKM.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SODMTKM |
| Assembly Title | Danh mục trả khuyến mại |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | ad65a7a8-c5f7-4cb8-8840-a3b90036a751 |
| ComVisible | false |

---

## Cấu trúc File

```
SODMTKM.dll/
├── SODMTKM.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaERP.UserInterface/
│   ├── frmSODMTKM.cs          # Main view form
│   └── frmSODMTKMEdit.cs      # Edit form
└── AsiaERP.UserInterface.My/
    ├── MyProject.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyComputer.cs
    └── MyApplication.cs
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System | Core .NET Framework |
| System.Drawing | Graphics và UI |
| System.Windows.Forms | Windows Forms UI |
| AsiaErp.Framework | Asia ERP Framework (frmDMComplexView, frmDMComplexEdit) |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSODMTKM` | `frmDMComplexView` | Form xem danh sách trả khuyến mại |
| `frmSODMTKMEdit` | `frmDMComplexEdit` | Form nhập/sửa thông tin trả khuyến mại |

---

## Các trường dữ liệu (frmSODMTKMEdit)

### Lookup controls (AsTextBox)
| Control | Trường DB | Lookup | Mô tả |
|---------|-------------|--------|-------|
| txtMa_km | ma_km | MA_KM | Mã khuyến mại |
| txtMa_vt | ma_vt | MA_VT | Mã vật tư |

### Numeric controls (AsTextNumeric)
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| txtSo_luong | sl_km | Số lượng khuyến mại |

### Checkbox
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| chkKsd | ksd | Không sử dụng |

### Label hiển thị
| Control | Mô tả |
|---------|-------|
| lblMa_km | Nhãn "Mã KM" |
| lblTen_km | Tên khuyến mại (lookup) |
| lblMa_vt | Nhãn "Mã vật tư" |
| lblTen_vt | Tên vật tư (lookup) |
| lblSo_luong | Nhãn "Số lượng" |

---

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| TKM | Trả khuyến mại |
| ma_km | Mã khuyến mại |
| ma_vt | Mã vật tư |
| sl_km | Số lượng khuyến mại |
| ksd | Không sử dụng |

---

## Mục đích sử dụng

**SODMTKM.dll là module quản lý Danh mục trả khuyến mại** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý thông tin trả khuyến mại
- Mã khuyến mại (ma_km) - Lookup từ MA_KM
- Mã vật tư (ma_vt) - Lookup từ MA_VT
- Số lượng khuyến mại (sl_km)

#### 2. Xử lý đặc thù
- Auto-lookup mã khuyến mại với validation
- Auto-lookup mã vật tư với validation
- Hiển thị tên khuyến mại và tên vật tư tự động
- Đánh dấu không sử dụng (ksd)

#### 3. Tính năng cơ bản
- Thêm mới, sửa, xóa chính sách trả khuyến mại
- Kiểm tra dữ liệu bắt buộc (Mã KM, Mã vật tư)
- Auto-complete và validation dữ liệu
- Tự động binding dữ liệu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit` của Framework (complex = có nhiều trường lookup phức tạp)
- Sử dụng AsTextBox với AutoLookup và AutoValid
- BackColor = SystemColors.Info cho trường lookup
- CharacterCasing = Upper cho mã
- Mask format cho số: `### ### ### ###.##`
- Disable cả ma_km và ma_vt khi sửa (khóa key)

---

## Kết luận

Đây là module Windows Forms quản lý danh mục trả khuyến mại, phục vụ cho việc định nghĩa chính sách khuyến mại trong hệ thống ERP. Module kết nối giữa mã khuyến mại và vật tư, xác định số lượng vật tư được trả khi áp dụng khuyến mại.

---

*Ngày phân tích: 2026-03-29*
