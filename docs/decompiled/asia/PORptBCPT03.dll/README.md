# Báo cáo Phân tích DLL: PORptBCPT03.dll

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
| Assembly Name | PORptBCPT03 |
| Assembly Title | Báo cáo mua hàng theo hai chỉ tiêu |
| Assembly Company | Công ty phần mềm Asia |
| Assembly Product | Simba Accounting |
| Assembly Copyright | Copyright © 2014 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 14.1.0.0 |
| Assembly File Version | 14.1.0.0 |
| GUID | 657eba5a-dc40-4630-ae9c-519389cdbee7 |
| ComVisible | false |

---

## Cấu trúc File

```
PORptBCPT03.dll/
├── PORptBCPT03.csproj              # Project file
├── app.ico                         # Application icon
├── Properties/
│   └── AssemblyInfo.cs             # Assembly metadata
├── AsiaErp.UserInterface/
│   └── frmPORptBCPT03.cs           # Main report form
└── AsiaErp.UserInterface.My/
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
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPORptBCPT03` | `frmReport` | Form báo cáo phân tích mua hàng theo 2 chỉ tiêu |

---

## Các trường Filter chính

### Nhóm và Chi tiết
| Trường | Ý nghĩa |
|--------|---------|
| `cboNhom_Theo` | Nhóm theo (Nhà cung cấp, Bộ phận, Hợp đồng, Hình thức TT, Vật tư) |
| `cboChi_Tiet_Theo` | Chi tiết theo (Vật tư, Nhà cung cấp, Bộ phận, Hợp đồng, Hình thức TT) |

### Thông tin Nhà cung cấp
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_kh` | Mã nhà CC | MA_KH |
| `txtMa_Nhkh` | Mã nhóm NCC | MA_NHKH |
| `txtMa_Plkh1` | Phân loại NCC 1 | MA_PLKH (loai='1') |
| `txtMa_Plkh2` | Phân loại NCC 2 | MA_PLKH (loai='2') |
| `txtMa_Plkh3` | Phân loại NCC 3 | MA_PLKH (loai='3') |

### Thông tin Vật tư
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_vt` | Mã vật tư | MA_VT |
| `txtMa_nhvt` | Nhóm vật tư | MA_NHVT |
| `txtMa_Plvt1` | Phân loại VT 1 | MA_PLVT (loai='1') |
| `txtMa_Plvt2` | Phân loại VT 2 | MA_PLVT (loai='2') |
| `txtMa_plvt3` | Phân loại VT 3 | MA_PLVT (loai='3') |

### Thông tin Hợp đồng và Thanh toán
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_hd` | Mã hợp đồng | MA_HD |
| `txtMa_nhhd` | Nhóm hợp đồng | MA_NHHD |
| `txtMa_HTTT` | Hình thức thanh toán | MA_HTTT |
| `txtMa_DKTT` | Điều khoản thanh toán | MA_TT_PO |

### Thông tin Kho và Chi phí
| Trường | Control | Lookup |
|--------|---------|--------|
| `txtMa_kho` | Mã kho | MA_KHO |
| `txtMa_vitri` | Mã vị trí | MA_VITRI |
| `txtMa_lo` | Mã lô | MA_LO |
| `txtMa_phi` | Mã phí | MA_PHI |
| `txtMa_spct` | Mã SPCT | MA_VT |

### Tùy chọn khác
| Trường | Ý nghĩa |
|--------|---------|
| `ChkTra_lai` | Hàng xuất trả lại nhà cung cấp |
| `txtMa_Nt` | Mã ngoại tệ |
| `optVND` / `optNt` | Tùy chọn tiền tệ (VND/Ngoại tệ) |

---

## Phương thức chính

| Phương thức | Mô tả |
|-------------|-------|
| `InitOtherComponents()` | Khởi tạo các thành phần bổ sung, binding dữ liệu cho combobox |
| `LoadData()` | Tải dữ liệu báo cáo với các tham số filter |
| `GetFilterTitle()` | Tạo chuỗi tiêu đề filter từ các điều kiện đã chọn |
| `CreateDrilldownArgument()` | Tạo tham số drill-down khi click vào dòng báo cáo |
| `cboNhom_Theo_SelectedIndexChanged()` | Xử lý khi thay đổi nhóm theo |
| `cboChi_Tiet_Theo_GotFocus()` | Xử lý tooltip khi focus vào combobox chi tiết |

---

## Mục đích sử dụng

**PORptBCPT03.dll là module báo cáo phân tích mua hàng theo 2 chỉ tiêu** trong hệ thống Simba Accounting của Asia Software.

### Chức năng chính

#### 1. Báo cáo phân tích mua hàng đa chiều
- Phân tích mua hàng theo 2 chỉ tiêu: Nhóm theo và Chi tiết theo
- Hỗ trợ các tổ hợp: Nhà cung cấp, Bộ phận, Hợp đồng, Hình thức thanh toán, Vật tư

#### 2. Lọc dữ liệu linh hoạt
- Lọc theo nhà cung cấp, nhóm NCC, phân loại NCC (3 cấp)
- Lọc theo vật tư, nhóm vật tư, phân loại vật tư (3 cấp)
- Lọc theo hợp đồng, nhóm hợp đồng
- Lọc theo kho, vị trí, lô, phí, SPCT
- Lọc theo hình thức thanh toán, điều khoản thanh toán
- Lọc theo ngoại tệ

#### 3. Xử lý hàng trả lại
- Tùy chọn bao gồm/exclude hàng xuất trả lại nhà cung cấp

#### 4. Drill-down (F5)
- Hỗ trợ drill-down để xem chi tiết từ báo cáo tổng hợp
- Truyền tham số mã nhóm và mã chi tiết để lọc dữ liệu chi tiết

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của framework
- Sử dụng `AsTextBox` với tính năng AutoLookup cho các trường mã
- Binding dữ liệu qua `BindingSource` cho combobox
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)

---

## Kết luận

Đây là module báo cáo phân tích mua hàng nâng cao trong hệ thống Simba Accounting, cho phép phân tích dữ liệu mua hàng theo 2 chiều (nhóm và chi tiết) với nhiều tùy chọn lọc linh hoạt.

---

*Ngày phân tích: 2026-03-29*
