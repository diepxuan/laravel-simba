# Báo cáo Phân tích DLL: INDMVT.dll

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
| Assembly Name | INDMVT |
| Assembly Title | Danh mục vật tư |
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
INDMVT.dll/
├── INDMVT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    ├── frmINDMVT.cs             # Main form class (danh mục view)
    └── frmINDMVTEdit.cs         # Edit form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.ComponentModel`, `System.Diagnostics`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmINDMVT` | `frmDMView` | Form xem danh mục vật tư |
| `frmINDMVTEdit` | `frmDMEdit` | Form nhập liệu/chỉnh sửa vật tư |

---

## Chi tiết Form frmINDMVTEdit

### Các trường dữ liệu chính

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtMa_Vt | Ma_Vt | Mã vật tư |
| txtTen_Vt | Ten_Vt | Tên vật tư |
| cboDvt | Dvt | Đơn vị tính |
| txtMa_Nhvt | Ma_Nhvt | Mã nhóm vật tư |
| cboLoai | Loai | Loại vật tư |
| cboGia_ton | Gia_ton | Phương pháp giá tồn kho |
| txtMa_kho | Ma_kho | Mã kho mặc định |
| txtMa_Thue | ma_thue | Mã thuế GTGT |

### Tài khoản kế toán

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtTk_Vt | Tk_Vt | TK vật tư (kho) |
| txtTk_Dt | Tk_Dt | TK doanh thu |
| txtTk_DtNb | Tk_DtNb | TK doanh thu nội bộ |
| txtTk_Gv | Tk_Gv | TK giá vốn |
| txtTk_Tl | Tk_Tl | TK trả lại |
| txtTk_Ck | Tk_Ck | TK chiết khấu |

### Thông tin bổ sung

| Control | Tên trường | Mục đích |
|---------|------------|----------|
| txtSl_min | Sl_min | Tồn tối thiểu |
| txtSl_max | Sl_max | Tồn tối đa |
| txtGia_nt0 | Gia_nt0 | Giá mua |
| txtGia_nt2 | Gia_nt2 | Giá bán |
| txtTs_Gtgt | Ts_Gtgt | Thuế suất GTGT |
| txtTs_Nk | Ts_Nk | Thuế suất NK |
| txtTs_Xk | Ts_Xk | Thuế suất XK |
| txtTs_ttdb | Ts_ttdb | Thuế suất TTĐB |
| cboDvt_mua | Dvt_mua | ĐVT mua |
| cboDvt_ban | Dvt_ban | ĐVT bán |
| txtHs_dvtmua | Hs_dvtmua | Hệ số ĐVT mua |
| txtHs_dvtban | Hs_dvtban | Hệ số ĐVT bán |
| chkTon_kho | ton_kho | Theo dõi tồn kho |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã vật tư", "Tên" - Thông tin cơ bản
- "Đvt" - Đơn vị tính
- "Nhóm" - Nhóm vật tư
- "Giá tồn" - Phương pháp giá tồn kho
- "Loại" - Loại vật tư
- "Mã kho" - Kho mặc định
- "Theo dõi tồn kho" - Checkbox tồn kho

### Tài khoản kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `Tk_Vt` | Tài khoản vật tư |
| `Tk_Dt` | Tài khoản doanh thu |
| `Tk_DtNb` | Tài khoản DT nội bộ |
| `Tk_Gv` | Tài khoản giá vốn |
| `Tk_Tl` | Tài khoản trả lại |
| `Tk_Ck` | Tài khoản chiết khấu |

### Thuế

- "Thuế suất GTGT" - Thuế giá trị gia tăng
- "Thuế suất NK" - Thuế nhập khẩu
- "Thuế suất XK" - Thuế xuất khẩu
- "Thuế suất TTĐB" - Thuế tiêu thụ đặc biệt

---

## Mục đích sử dụng

**INDMVT.dll là module quản lý danh mục vật tư** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý thông tin vật tư
- Mã vật tư, tên vật tư
- Đơn vị tính (mua, bán, kho)
- Hệ số chuyển đổi đơn vị tính
- Nhóm vật tư phân loại

#### 2. Cấu hình tài khoản kế toán
- TK vật tư (kho)
- TK doanh thu, DT nội bộ
- TK giá vốn
- TK trả lại, chiết khấu

#### 3. Quản lý tồn kho
- Tồn tối thiểu/tối đa
- Phương pháp giá tồn kho
- Theo dõi tồn kho (checkbox)
- Kho mặc định

#### 4. Thông tin giá và thuế
- Giá mua, giá bán
- Các loại thuế suất (GTGT, NK, XK, TTĐB)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Lookup tự động cho mã nhóm vật tư, kho, thuế
- Validation dữ liệu đầu vào
- Tự động điền tài khoản kế toán từ nhóm vật tư
- Hỗ trợ autocomplete cho các trường mã

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục vật tư - một chức năng cốt lõi trong module Inventory (IN).

---

*Ngày phân tích: 2026-03-29*
