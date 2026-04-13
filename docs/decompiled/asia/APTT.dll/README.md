# Báo cáo Phân tích DLL: APTT.dll

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
| Assembly Name | APTT |
| Assembly Title | Số dư đầu kỳ các hóa đơn phải trả |
| Assembly Company | - |
| Assembly Product | APTT |
| Assembly Copyright | Copyright © 2010 |
| Assembly Trademark | - |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 6b068be7-41c0-49b7-acdc-3c5e05536484 |
| ComVisible | false |

---

## Cấu trúc File

```
APTT.dll/
├── APTT.csproj                   # Project file
├── app.ico                       # Application icon
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmAPTT.cs                # Main view form - Danh mục điều khoản TT
│   └── frmAPTTEdit.cs            # Edit form - Nhập/sửa điều khoản
├── AsiaErp.UserInterface.My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   └── MySettings.cs
└── AsiaErp.UserInterface.My.Resources/
    └── Resources.cs              # Resource manager
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
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmAPTT` | `frmOBView` | Form xem danh mục điều khoản thanh toán |
| `frmAPTTEdit` | `frmOBEdit` | Form nhập/sửa điều khoản thanh toán |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI (frmAPTTEdit)

- "Thông tin chung" - GroupBox chính
- "Chi tiết" - GroupBox chi tiết thanh toán
- "Mã NCC" (Nhà cung cấp)
- "TK phải trả" - Tài khoản phải trả
- "Mã TT" - Mã thanh toán
- "Mã hợp đồng"
- "Ngày chứng từ", "Số chứng từ"
- "Hạn chiết khấu", "Hạn thanh toán"
- "TL CK" - Tỷ lệ chiết khấu
- "LS QH" - Lãi suất quá hạn
- "Diễn giải"
- "Ngoại tệ", "Tỷ giá"
- "Ngày thanh toán", "Số CT thanh toán"

### Các trường nhập liệu (frmAPTTEdit)

| Trường | Ý nghĩa |
|--------|---------|
| txtMa_NCC | Mã nhà cung cấp |
| txtTK_pt | Tài khoản phải trả (tk_cn=1) |
| txtMa_tt_po | Mã điều khoản thanh toán |
| txtMa_hd | Mã hợp đồng |
| txtNgay_ct | Ngày chứng từ |
| txtSo_ct | Số chứng từ |
| txtHan_ck | Hạn chiết khấu (ngày) |
| txtHan_tt | Hạn thanh toán (ngày) |
| txttl_ck | Tỷ lệ chiết khấu (%) |
| txtls_qh | Lãi suất quá hạn (%) |
| txtdien_giai | Diễn giải |
| cboNgoai_te | Mã ngoại tệ |
| txtty_gia | Tỷ giá |
| txtNgay_ct_tt | Ngày thanh toán |
| txtSo_ct_tt | Số chứng từ thanh toán |

### Các trường tiền tệ (GroupBox Chi tiết)

| Trường NT | Trường VND | Ý nghĩa |
|-----------|------------|---------|
| txtTien_hang_nt | txtTien_hang | Tiền hàng |
| txtTien_thue_nt | txtTien_thue | Tiền thuế |
| txtTong_tt_nt | txtTong_tt | Tổng thanh toán |
| txtTien_tt_nt | txtTien_tt | Đã thanh toán |
| txtDu_hd_nt | txtDu_hd | Còn phải thanh toán |

### Thuật ngữ kế toán

| Thuật tính | Ý nghĩa |
|------------|---------|
| `ma_kh` | Mã nhà cung cấp |
| `tk_pt` | Tài khoản phải trả |
| `ma_tt_po` | Mã điều khoản thanh toán |
| `ma_hd` | Mã hợp đồng |
| `han_ck` | Hạn chiết khấu |
| `han_tt` | Hạn thanh toán |
| `tl_ck` | Tỷ lệ chiết khấu |
| `ls_qh` | Lãi suất quá hạn |
| `t_tien0` | Tiền hàng |
| `t_thue` | Tiền thuế |
| `t_tt` | Tổng thanh toán |
| `tien_da_tt` | Đã thanh toán |
| `du_hd` | Dư hóa đơn |
| `du_tt` | Dư thanh toán (tính toán) |
| `du_tt_nt` | Dư thanh toán NT (tính toán) |

---

## Mục đích sử dụng

**APTT.dll là module quản lý "Điều khoản thanh toán mua hàng"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý điều khoản thanh toán
- Tạo và quản lý các điều khoản thanh toán với nhà cung cấp
- Liên kết với hợp đồng mua hàng
- Thiết lập hạn thanh toán và chiết khấu
- Quản lý lãi suất quá hạn

#### 2. Theo dõi công nợ hóa đơn
- Theo dõi tiền hàng, tiền thuế
- Tính tổng thanh toán
- Theo dõi số tiền đã thanh toán
- Tính dư còn phải thanh toán

#### 3. Xử lý đa tiền tệ
- Hỗ trợ nhập liệu ngoại tệ (NT) và VND
- Tự động chuyển đổi theo tỷ giá
- Tính toán song song cả hai loại tiền
- Tự động cập nhật tỷ giá theo ngày

#### 4. Tính toán tự động
- Tính tổng thanh toán = Tiền hàng + Tiền thuế
- Tính dư = Tổng - Đã thanh toán
- Chuyển đổi NT sang VND theo tỷ giá
- Cảnh báo điều chỉnh nếu chênh lệch vượt ngưỡng

#### 5. Validation và kiểm soát
- Kiểm tra mã NCC, TK phải trả bắt buộc
- Kiểm tra số chứng từ thanh toán
- Kiểm tra ngày không được trước ngày khóa sổ
- Kiểm tra số liệu cân đối (cảnh báo điều chỉnh)

### Đặc điểm kỹ thuật

- `frmAPTT` kế thừa từ `frmOBView` - Form xem danh mục chuẩn
- `frmAPTTEdit` kế thừa từ `frmOBEdit` - Form edit chuẩn
- DataBinding với DataTable
- AutoLookup cho các trường mã (NCC, TK, TT, HD)
- AfterCodeValidating để tự động điền thông tin từ điều khoản TT
- Kiểm tra cảnh báo điều chỉnh (canh_bao_dieu_chinh)
- Tích hợp với Asia ERP Framework

### Công thức tính toán

```
Tổng thanh toán NT = Tiền hàng NT + Tiền thuế NT
Tổng thanh toán VND = Tiền hàng VND + Tiền thuế VND
Dư NT = Tổng NT - Đã thanh toán NT
Dư VND = Tổng VND - Đã thanh toán VND
Chuyển đổi: VND = NT × Tỷ giá
```

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý điều khoản thanh toán mua hàng - một chức năng quan trọng trong quản lý công nợ phải trả và theo dõi thanh toán với nhà cung cấp.

---

*Ngày phân tích: 2026-03-29*
