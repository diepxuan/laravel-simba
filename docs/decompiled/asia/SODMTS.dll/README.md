# Báo cáo Phân tích DLL: SODMTS.dll

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
| Assembly Name | SODMTS |
| Assembly Title | Danh mục tài sản |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
SODMTS.dll/
├── SODMTS.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmSODMTS.cs           # Main view form
    └── frmSODMTSEdit.cs       # Edit form
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System | Core .NET Framework |
| System.Drawing | Graphics và UI |
| System.Windows.Forms | Windows Forms UI |
| AsiaErp.Framework | Asia ERP Framework (frmDMView, frmDMEdit) |
| Microsoft.VisualBasic | VB runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Drawing`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSODMTS` | `frmDMView` | Form xem danh sách thuế suất |
| `frmSODMTSEdit` | `frmDMEdit` | Form nhập/sửa thông tin thuế suất |

---

## Các trường dữ liệu (frmSODMTSEdit)

### TextBox controls
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| txtMa_Thue | Ma_Thue | Mã thuế |
| txtTen_thue | Ten_Thue | Tên thuế |

### Lookup controls (AsTextBox)
| Control | Trường DB | Lookup | Điều kiện | Mô tả |
|---------|-------------|--------|-------------|-------|
| txtTk_Thue_Co | Tk_Thue_Co | TK | chi_tiet=1 | TK Thuế đầu ra |

### Numeric controls (AsTextNumeric)
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| txtTS_GTGT | TS_GTGT | Thuế suất GTGT |

### Checkbox
| Control | Trường DB | Mô tả |
|---------|-------------|-------|
| chkKsd | Ksd | Không sử dụng |
| chk_KCT | KCT | Không chịu thuế |

### Label hiển thị
| Control | Mô tả |
|---------|-------|
| lbMa_thue | Nhãn "Mã thuế" |
| lbTen_Thue | Nhãn "Tên thuế" |
| lblTk_Thue_co | Nhãn "TK Thuế đầu ra" |
| lblTen_Tk_thue_co | Tên TK thuế (lookup) |
| lblTS_GTGT | Nhãn "Thuế suất GTGT" |

---

## Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| TS | Tỷ suất / Thuế suất |
| Ma_Thue | Mã thuế |
| Ten_Thue | Tên thuế |
| TS_GTGT | Thuế suất GTGT (Giá trị gia tăng) |
| Tk_Thue_Co | Tài khoản thuế có (đầu ra) |
| KCT | Không chịu thuế |
| Ksd | Không sử dụng |

---

## Mục đích sử dụng

**SODMTS.dll là module quản lý Danh mục tỷ suất (thuế)** trong hệ thống ERP của Asia Software.

### Chức năng chính

#### 1. Quản lý thông tin thuế suất
- Mã thuế (Ma_Thue)
- Tên thuế (Ten_Thue)
- Thuế suất GTGT (TS_GTGT) - Giá trị phần trăm
- Tài khoản thuế đầu ra (Tk_Thue_Co) - Lookup từ TK có chi_tiet=1

#### 2. Xử lý đặc thù thuế
- Đánh dấu không chịu thuế (KCT - Không chịu thuế)
- Đánh dấu không sử dụng (Ksd)
- Auto-lookup tài khoản thuế với validation

#### 3. Tính năng cơ bản
- Thêm mới, sửa, xóa thuế suất
- Kiểm tra dữ liệu bắt buộc (Mã, Tên)
- Auto-complete và validation tài khoản
- Tự động binding dữ liệu

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMView` và `frmDMEdit` của Framework
- Sử dụng AsTextBox với AutoLookup và AutoValid cho TK thuế
- Lookup condition: `chi_tiet=1` (chỉ lấy TK chi tiết)
- BackColor = SystemColors.Info cho trường lookup
- CharacterCasing = Upper cho mã
- Sử dụng DataBinding với BindingSource (bsDanhMuc)
- Mask format cho số: `### ### ### ###.##`

---

## Kết luận

Đây là module Windows Forms quản lý danh mục thuế suất GTGT, phục vụ cho việc định nghĩa các loại thuế và tỷ suất trong hệ thống ERP. Module tích hợp với danh mục tài khoản kế toán để xác định TK thuế đầu ra, hỗ trợ cả trường hợp không chịu thuế.

---

*Ngày phân tích: 2026-03-29*
