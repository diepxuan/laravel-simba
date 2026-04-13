# Báo cáo Phân tích DLL: PORptTH03.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | PORptTH03 |
| Assembly Title | Tổng hợp chi phí mua hàng |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 94421421-1d9a-481d-836f-74d5f3f3e870 |
| ComVisible | false |

---

## Cấu trúc File

```
PORptTH03.dll/
├── PORptTH03.csproj                # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaERP.UserInterface/
│   └── frmPORptTH03.cs             # Main report form
└── AsiaERP.UserInterface.My/
    ├── MyComputer.cs
    ├── MyApplication.cs
    ├── MySettings.cs
    ├── MySettingsProperty.cs
    ├── MyProject.cs
    ├── InternalXmlHelper.cs
    └── Resources/
        └── Resources.cs            # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Drawing | Graphics và UI |
| System.Windows.Forms | Windows Forms controls |
| AsiaErp.Framework | Asia ERP Framework |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaERP.UserInterface`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPORptTH03` | `frmReport` | Form báo cáo tổng hợp chi phí mua hàng |

---

## Các trường Filter chính

### Thông tin Chứng từ
| Trường | Control | Ý nghĩa |
|--------|---------|---------|
| `txtCT1` | Chứng từ số | Số chứng từ từ |
| `txtCT2` | Đến số | Số chứng từ đến |

### Thông tin Nhà cung cấp
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_ncc` | Mã nhà cung cấp | MA_NCC (isNcc=1) |
| `txtMa_nh_ncc` | Mã nhóm NCC | MA_NHKH |
| `txtPl_ncc1` | Phân loại NCC 1 | MA_PLKH (loai=1) |
| `txtPl_ncc2` | Phân loại NCC 2 | MA_PLKH (loai=2) |
| `txtPl_ncc3` | Phân loại NCC 3 | MA_PLKH (loai=3) |

### Thông tin Vật tư
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_vt` | Mã vật tư | MA_VT |
| `txtMa_nh_vt` | Nhóm vật tư | MA_NHVT |
| `txtMa_Plvt1` | Phân loại VT 1 | MA_PLVT (loai='1') |
| `txtMa_Plvt2` | Phân loại VT 2 | MA_PLVT (loai='2') |
| `txtMa_plvt3` | Phân loại VT 3 | MA_PLVT (loai='3') |

### Thông tin Hợp đồng và Thanh toán
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_hd` | Mã hợp đồng | MA_HD |
| `txtMa_nhhd` | Nhóm hợp đồng | MA_NHHD |
| `txtMA_HTTT` | Hình thức TT | MA_HTTT (moduleid='po') |
| `txtMA_DKTT` | Điều khoản TT | MA_TT |

### Thông tin Kho và Chi phí
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_kho` | Mã kho | MA_KHO |
| `txtMa_vtri` | Mã vị trí | MA_VITRI |
| `txtMaLo` | Mã lô | MA_LO |
| `txtMaPhi` | Mã phí | MA_PHI |
| `txtMa_spct` | Mã SPCT | MA_SPCT |

### Tùy chọn khác
| Trường | Ý nghĩa |
|--------|---------|
| `txtMa_Nt` | Mã ngoại tệ |
| `optVND` / `optNt` | Tùy chọn tiền tệ (VND/Ngoại tệ) |

---

## Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `InitOtherComponents()` | Khởi tạo các thành phần bổ sung |
| `LoadData()` | Tải dữ liệu báo cáo với các tham số filter |
| `GetFilterTitle()` | Tạo chuỗi tiêu đề filter từ các điều kiện đã chọn |
| `CreateDrilldownArgument()` | Tạo tham số drill-down khi click vào dòng báo cáo (F5) |

---

## Mục đích sử dụng

**PORptTH03.dll là module Báo cáo tổng hợp chi phí mua hàng** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo tổng hợp chi phí mua hàng
- Tổng hợp chi phí mua hàng theo nhiều chiều
- Phân tích chi phí theo nhà cung cấp, vật tư, hợp đồng...

#### 2. Lọc dữ liệu đa chiều
- Lọc theo nhà cung cấp, nhóm NCC, phân loại NCC (3 cấp)
- Lọc theo vật tư, nhóm vật tư, phân loại vật tư (3 cấp)
- Lọc theo hợp đồng, nhóm hợp đồng
- Lọc theo kho, vị trí, lô, phí, SPCT
- Lọc theo hình thức thanh toán, điều khoản thanh toán
- Lọc theo số chứng từ (từ số - đến số)
- Lọc theo ngoại tệ

#### 3. Drill-down (F5)
- Hỗ trợ drill-down để xem chi tiết từ báo cáo tổng hợp
- Khi nhấn F5 trên một dòng vật tư, sẽ hiển thị chi tiết cho vật tư đó
- Truyền các tham số: mã vật tư, nhà cung cấp, nhóm NCC, phân loại NCC, kho, hợp đồng...

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với tính năng AutoLookup cho các trường mã
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Có chức năng drill-down để xem chi tiết

---

## Kết luận

Đây là module báo cáo tổng hợp chi phí mua hàng trong hệ thống Simba Accounting, cho phép người dùng tổng hợp và phân tích chi phí mua hàng theo nhiều chiều khác nhau, đồng thời hỗ trợ drill-down để xem chi tiết.

---

*Ngày phân tích: 2026-03-29*
