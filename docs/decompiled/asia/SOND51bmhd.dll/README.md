# Báo cáo Phân tích DLL: SOND51bmhd.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |
| Chức năng | Bảo mật hóa đơn - Kiểm tra và mã hóa hóa đơn tự in |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOND51bmhd |
| Assembly Title | SOND51bmhd |
| Assembly Company | - |
| Assembly Product | SOND51bmhd |
| Assembly Copyright | Copyright © 2012 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | e437e56c-c230-4a53-a87c-ce3248b2ace2 |
| ComVisible | false |

---

## Cấu trúc File

```
SOND51bmhd.dll/
├── SOND51bmhd.csproj              # Project file
├── app.ico                        # Application icon
├── Properties/
│   └── AssemblyInfo.cs            # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOND51bmhd.cs           # Main form class (kế thừa frmAsiaRoot)
│   └── frmConfirm.cs              # Form xác nhận
├── AsiaErp.DataAccess/
│   ├── SOND51bmhdDAO.cs           # Data Access Object interface
│   └── MsSqlSOND51bmhdDAO.cs      # SQL Server implementation
└── My.Resources/
    └── Resources.cs               # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| System.Data | Data access |
| System.Security.Cryptography | Mã hóa dữ liệu |
| System.Text | Encoding |
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.DataAccess | Asia ERP Data Access |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.DataAccess`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `System.Security.Cryptography`
- `System.Text`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOND51bmhd` | `frmAsiaRoot` | Form bảo mật hóa đơn chính |
| `frmConfirm` | - | Form xác nhận thao tác |
| `SOND51bmhdDAO` | - | Interface DAO |
| `MsSqlSOND51bmhdDAO` | - | SQL Server DAO implementation |

---

## Các Controls chính trong frmSOND51bmhd

### GroupBox 1: Thiết lập mã số bảo mật

| Control | Loại | Mục đích |
|---------|------|----------|
| txtMa_BM | TextBox | Mã số bảo mật (PasswordChar = '*') |
| chkHien | CheckBox | Hiển thị/ẩn mã số bảo mật |
| ChkSu_dung | CheckBox | Sử dụng mã số bảo mật |
| btnLuu | Button | Lưu cấu hình |

### GroupBox 3: Thông tin hóa đơn cần kiểm tra

| Control | Loại | Mục đích |
|---------|------|----------|
| txtSo_HD | AsTextBox | Số hóa đơn |
| txtNgay_HD | AsMaskedTextBox | Ngày hóa đơn (dd/MM/yyyy) |
| txtSo_seri | AsTextBox | Ký hiệu hóa đơn |
| txtMST | AsTextBox | Mã số thuế khách hàng |
| txtMa_KT | AsTextBox | Mã số kiểm tra |
| txtMa_hoa | AsTextBox | Mã hóa kết quả |
| btnKiemtra | Button | Kiểm tra hóa đơn |
| btnMa_hoa | Button | Mã hóa thông tin |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Bảo mật hoá đơn tự in" - Tiêu đề form chính
- "Thiết lập mã số bảo mật" - GroupBox 1
- "Mã số bảo mật", "Hiển thị mã số bảo mật", "Sử dụng mã số bảo mật"
- "Thông tin của hoá đơn cần kiểm tra" - GroupBox 3
- "Số HĐ", "Ngày HĐ", "Ký hiệu HĐ", "MST KH"
- "Mã số kiểm tra", "Mã Hoá"

### Thông báo hướng dẫn

- "Nhập đầy đủ các thông tin mà bạn có trên tờ hoá đơn và tiến hành kiểm tra để biết đấy có phải là tờ hoá đơn mà doanh nghiệp bạn in hay không."

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_bm` | Mã bảo mật |
| `so_hd` | Số hóa đơn |
| `ngay_hd` | Ngày hóa đơn |
| `so_seri` | Số seri (ký hiệu) |
| `mst` | Mã số thuế |
| `ma_kt` | Mã kiểm tra |
| `ma_hoa` | Mã hóa |

---

## Mục đích sử dụng

**SOND51bmhd.dll là module "Bảo mật hóa đơn"** trong hệ thống ERP của Asia Software, cung cấp cơ chế mã hóa và xác thực hóa đơn tự in để chống giả mạo.

### Chức năng chính

#### 1. Thiết lập mã số bảo mật
- Cấu hình mã số bảo mật cho doanh nghiệp
- Lưu trữ mã số bảo mật đã mã hóa trong database
- Tùy chọn sử dụng hoặc không sử dụng mã bảo mật
- Hiển thị/ẩn mã số bảo mật khi nhập

#### 2. Mã hóa thông tin hóa đơn
- Kết hợp thông tin: Số HĐ + Ngày HĐ + Ký hiệu + MST
- Mã hóa XOR với key (mã bảo mật hoặc "asiasoft" mặc định)
- Tạo MD5 hash từ chuỗi đã mã hóa
- Xuất mã hóa để in trên hóa đơn

#### 3. Kiểm tra xác thực hóa đơn
- Nhập thông tin từ hóa đơn giấy
- Tính toán mã kiểm tra
- So sánh với mã in trên hóa đơn
- Xác nhận hóa đơn có phải do công ty phát hành hay không

### Thuật toán mã hóa

```csharp
// XOR Encryption
Encrypt(stringToEncrypt, key):
  - Convert key và stringToEncrypt sang byte array (UTF8)
  - XOR từng byte của stringToEncrypt với key (lặp lại key)
  - Convert kết quả sang Hex string

// MD5 Hash
GetMD5Hash(strToHash):
  - Tạo MD5 hash từ chuỗi đầu vào
  - Convert sang hex string lowercase
```

### Đặc điểm kỹ thuật

- Sử dụng mã hóa XOR đơn giản với key có thể cấu hình
- Tích hợp MD5 hash để tạo mã kiểm tra
- Lưu trữ mã bảo mật đã mã hóa trong database
- Validation mã bảo mật phải > 6 ký tự
- Form xác nhận khi cập nhật mã bảo mật

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia, cung cấp cơ chế bảo mật cho hóa đơn tự in. Module giúp doanh nghiệp tạo mã xác thực trên hóa đơn và kiểm tra tính hợp lệ của hóa đơn khi cần.

---

*Ngày phân tích: 2026-03-29*
