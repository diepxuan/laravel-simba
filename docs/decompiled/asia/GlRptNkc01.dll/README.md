# Báo cáo Phân tích DLL: GlRptNkc01.dll

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
| Assembly Name | GlRptNkc01 |
| Assembly Title | Sổ cái |
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
GlRptNkc01.dll/
├── GlRptNkc01.csproj           # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptNkc01.cs       # Main form class (Report)
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
- `System`, `System.Collections`, `System.Collections.Generic`, `System.ComponentModel`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptNkc01` | `frmReport` | Form báo cáo NKC01 (Sổ cái) |

---

## Chi tiết Form: frmGlRptNkc01

### Thuộc tính Form

| Thuộc tính | Giá trị |
|-------------|---------|
| ClientSize | 564 x 258 |
| AutoScaleDimensions | 6f, 13f |
| Name | frmGlRptNkc01 |
| Base Class | frmReport |

### Private Fields

| Field | Kiểu | Mục đích |
|-------|--------|----------|
| `Ten_tk` | string | Lưu tên tài khoản |

### Controls

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Nhập tài khoản (LookupCodeName = "TK") |
| `lblTen_Tk` | Label | Hiển thị tên tài khoản |
| `lblTk` | Label | Nhãn "Tài khoản" |

### Thuộc tính Controls

#### txtTk (AsTextBox)
| Thuộc tính | Giá trị |
|-------------|---------|
| AutoLookup | true |
| AutoValid | true |
| BackColor | SystemColors.Info |
| CharacterCasing | Upper |
| LookupCodeName | TK |
| NameControl | lblTen_Tk |
| TabIndex | 3 |
| Tag | @pTk |
| UseAutoCompleteSource | true |
| ValidReturnFieldList | TEN_TK |

### LoadData Logic

Parameters:
- CompanyID
- Ngày bắt đầu (txtNgay1)
- Ngày kết thúc (txtNgay2)
- Tài khoản (txtTk)
- Mã ngoại tệ (txtMa_Nt)

Formula Fields:
- TK: Mã tài khoản
- TEN_TK: Tên tài khoản
- Du_Co_Cky: Dư có cuối kỳ
- Du_No_Cky: Dư nợ cuối kỳ
- Du_Co_Dky: Dư có đầu kỳ
- Du_No_Dky: Dư nợ đầu kỳ

### Validation

- `ValidData()`: Kiểm tra dữ liệu hợp lệ
- `ChkEmtyTextBox(txtTk)`: Bắt buộc nhập tài khoản

---

## Mục đích sử dụng

**GlRptNkc01.dll là module báo cáo NKC01 (Sổ cái)** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Sổ cái (NKC01)
- Hiển thị sổ cái cho một tài khoản cụ thể
- Theo dõi phát sinh và số dư của tài khoản
- Hiển thị dư đầu kỳ và dư cuối kỳ

#### 2. Chọn tài khoản
- Nhập mã tài khoản với auto-lookup
- Tự động hiển thị tên tài khoản
- Validation bắt buộc nhập tài khoản

#### 3. Xem và In
- Xem sổ cái trong khoảng thời gian
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- In ấn báo cáo

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn
- Sử dụng AsTextBox với AutoLookup cho chọn tài khoản
- Hỗ trợ đa tiền tệ (VND/Ngoại tệ)
- Validation dữ liệu đầu vào (bắt buộc nhập tài khoản)
- Formula fields cho dữ liệu đầu kỳ/cuối kỳ

### Sổ cái (NKC01)

Sổ cái là sổ kế toán chi tiết theo dõi tình hình tăng giảm và số hiện có của từng tài khoản kế toán. Mỗi tài khoản có một trang sổ riêng, ghi chép đầy đủ các nghiệp vụ kinh tế phát sinh liên quan đến tài khoản đó trong kỳ kế toán.

Các thông tin chính trên sổ cái:
- Dư nợ đầu kỳ
- Dư có đầu kỳ
- Phát sinh nợ trong kỳ
- Phát sinh có trong kỳ
- Dư nợ cuối kỳ
- Dư có cuối kỳ

---

## Kết luận

Đây là module báo cáo Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc hiển thị và in ấn sổ cái (NKC01) cho một tài khoản cụ thể. Module này đơn giản, tập trung vào việc chọn tài khoản và hiển thị thông tin phát sinh, số dư của tài khoản đó.

---

*Ngày phân tích: 2026-03-29*
