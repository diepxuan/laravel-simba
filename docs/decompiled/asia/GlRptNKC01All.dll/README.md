# Báo cáo Phân tích DLL: GlRptNKC01All.dll

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
| Assembly Name | GlRptNKC01All |
| Assembly Title | Bảng cân đối phát sinh các tài khoản |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | false |

---

## Cấu trúc File

```
GlRptNKC01All.dll/
├── GlRptNKC01All.csproj        # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNKC01All.cs   # Main form class (Report)
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNKC01All` | `frmReport` | Form báo cáo NKC01 All (Bảng cân đối phát sinh các tài khoản) |

---

## Chi tiết Form: frmGlRptNKC01All

### Thuộc tính Form

| Thuộc tính | Giá trị |
|-------------|---------|
| ClientSize | 762 x 446 |
| AutoScaleDimensions | 6f, 13f |
| Name | frmGlRptNKC01All |
| Base Class | frmReport |

### Controls

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `chkTK_sc` | CheckBox | Lên cho tài khoản sổ cái |
| `txtBac` | AsTextNumeric | Nhập bậc tài khoản (mặc định = 9) |
| `lblbac` | Label | Nhãn "In đến bậc" |
| `txtTk` | AsTextBox | Nhập tài khoản |
| `lblTk` | Label | Nhãn "Tài khoản" |
| `lblten_tk` | Label | Hiển thị tên tài khoản |
| `chkSTT_NKC` | CheckBox | Đánh STT theo sổ NKC |

### Events

| Event | Handler | Mục đích |
|-------|---------|----------|
| AsTabControl.SelectedIndexChanged | AsTabControl_SelectedIndexChanged | Cập nhật title bar khi chuyển tab |
| cboMau_bc.SelectedIndexChanged | cboMau_bc_SelectedIndexChanged | Enable/disable controls theo mẫu báo cáo |
| dgvBC.KeyDown | dgvBC_KeyDown | Xử lý Ctrl+A (toggle TAG) |
| dgvBC.CellContentClick | dgvBC_CellContentClick | Xử lý click vào cột TAG |

### Mẫu báo cáo (cboMau_bc)

| Index | Tên mẫu | Controls enabled |
|-------|-----------|----------------|
| 0 | Mẫu 01 | txtBac: false, chkTK_sc: false, chkSTT_NKC: true |
| 1 | Mẫu 02 | txtBac: true, chkTK_sc: true, chkSTT_NKC: false |

### LoadData Logic

#### Mẫu 01 (Index = 0)
Parameters:
- CompanyID
- Ngày bắt đầu (txtNgay1)
- Ngày kết thúc (txtNgay2)
- Tài khoản (txtTk)
- Mã ngoại tệ (txtMa_Nt)
- Đánh STT NKC (chkSTT_NKC.Checked)

Formula Fields:
- TK, TEN_TK
- Du_Co_Cky, Du_No_Cky
- Du_Co_Dky, Du_No_Dky

#### Mẫu 02 (Index = 1)
Parameters:
- CompanyID
- Ngày bắt đầu (txtNgay1)
- Ngày kết thúc (txtNgay2)
- Tài khoản (txtTk)
- Bậc (txtBac)
- Lên TK sổ cái (chkTK_sc.Checked)
- Mã ngoại tệ (txtMa_Nt)

### Drilldown Logic

| Phím | Modifier | Mục đích |
|------|----------|----------|
| F5 | None | Drilldown sổ chi tiết tài khoản |
| F5 | Shift | Drilldown cân đối phát sinh công nợ |
| F5 | Ctrl | Drilldown sổ chi tiết (với tk = "") |

Parameters cho drilldown:
```
Args[0]: CompanyID
Args[1]: tk (Tài khoản)
Args[2]: ngay_ct1 (Từ ngày)
Args[3]: ngay_ct2 (Đến ngày)
Args[4]: ma_nt (Mã ngoại tệ)
```

### Hotkeys

| Phím | Chức năng |
|------|-------------|
| F5 | Sổ chi tiết |
| Ctrl+F5 | Sổ chi tiết (variant) |
| Shift+F5 | Cân đối PS công nợ |
| F7 | Xem |
| F9 | In |

### Crystal Reports Integration

- `LoadDataToCrystal()`: Load dữ liệu đã chọn (TAG=1) sang Crystal Report
- `ViewCrystalBySource()`: Hiển thị báo cáo Crystal

---

## Mục đích sử dụng

**GlRptNKC01All.dll là module báo cáo NKC01 All** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Bảng cân đối phát sinh các tài khoản (NKC01 All)
- Hiển thị bảng cân đối phát sinh cho tất cả các tài khoản
- Hỗ trợ 2 mẫu báo cáo khác nhau
- Cho phép lọc theo bậc tài khoản và tài khoản sổ cái

#### 2. Quản lý tài khoản
- Chọn tài khoản cụ thể hoặc tất cả
- Lọc theo bậc tài khoản (mặc định đến bậc 9)
- Tùy chọn "Lên cho TK sổ cái"

#### 3. Đánh số thứ tự
- Tùy chọn đánh STT theo sổ NKC
- Hỗ trợ đánh dấu (TAG) để chọn in

#### 4. Drilldown đa dạng
- F5: Xem sổ chi tiết tài khoản
- Shift+F5: Xem cân đối phát sinh công nợ
- Ctrl+F5: Xem sổ chi tiết (variant)

#### 5. In ấn
- In trực tiếp (F9)
- Xuất Excel
- Xem trước (F7)
- Tích hợp Crystal Reports

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn
- Sử dụng DataGridView (`dgvBC`) với cột TAG để chọn dòng in
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Validation dữ liệu đầu vào (bắt buộc nhập tài khoản)
- Tích hợp Crystal Reports cho in ấn

### NKC (Nhật ký Chung)

NKC là viết tắt của "Nhật ký Chung" - sổ kế toán tổng hợp ghi chép theo trình tự thời gian các nghiệp vụ kinh tế phát sinh. Bảng cân đối phát sinh các tài khoản là báo cáo tổng hợp từ sổ NKC.

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc hiển thị, drilldown và in ấn bảng cân đối phát sinh các tài khoản (NKC01 All). Module này cung cấp nhiều tùy chọn lọc, xem chi tiết và in ấn linh hoạt.

---

*Ngày phân tích: 2026-03-29*
