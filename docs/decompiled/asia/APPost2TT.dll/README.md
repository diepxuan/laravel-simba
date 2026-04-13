# Báo cáo Phân tích DLL: APPost2TT.dll

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
| Assembly Name | APPost2TT |
| Assembly Title | ARPost2TT |
| Assembly Company | - |
| Assembly Product | ARPost2TT |
| Assembly Copyright | Copyright © 2012 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 0dfa269f-b4fb-4883-b219-2eaaa2489313 |
| ComVisible | false |

---

## Cấu trúc File

```
APPost2TT.dll/
├── APPost2TT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmAPPost2TT.cs          # Main form - Phân bổ thanh toán
│   ├── frmAPPost2TTFind.cs      # Search form
│   └── frmAPPost2TTResult.cs    # Result form
├── AsiaErp.DataAccess/
│   ├── APPost2TTDAO.cs          # DAO Interface
│   └── MsSqlAPPost2TTDAO.cs     # MSSQL DAO Implementation
├── My/
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   └── MySettings.cs
└── My.Resources/
    └── Resources.cs             # Resource manager
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

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmAPPost2TT` | `frmAsiaRoot` | Form chính phân bổ tiền thanh toán cho hóa đơn |
| `frmAPPost2TTFind` | - | Form tìm kiếm chứng từ phân bổ |
| `frmAPPost2TTResult` | - | Form hiển thị kết quả |
| `APPost2TTDAO` | `DAO` | Interface truy cập dữ liệu |
| `MsSqlAPPost2TTDAO` | `APPost2TTDAO` | Implementation DAO cho SQL Server |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phân bổ tiền hàng cho hoá đơn" - Tên form chính
- "Mã khách hàng", "Tên khách hàng", "Loại chứng từ"
- "Diễn giải", "Ngày chứng từ", "Số chứng từ"
- "Tổng tiền VND", "Tổng tiền NT"
- "Số tiền phân bổ VND còn lại", "Số tiền phân bổ NT còn lại"

### Cột DataGridView (Hoá đơn được phân bổ)

| Cột | Ý nghĩa |
|-----|---------|
| stt_rec | Số thứ tự record |
| stt_rec_hd | Số thứ tự hóa đơn |
| so_ct | Số hóa đơn |
| ngay_ct | Ngày hóa đơn |
| tk_pt | Tài khoản phải trả |
| ma_kh | Mã khách hàng |
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |
| t_tt | Tổng tiền VND |
| t_tt_nt | Tiền hóa đơn NT |
| tien_tt_nt | Đã thanh toán NT |
| du_hd_nt | Còn phải thanh toán |
| thanhtoan | Thanh toán |
| tien_tt_qd | Thanh toán quy đổi |
| dien_giai | Diễn giải |
| nguoi_gd | Người giao dịch |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `t_tien` | Tổng tiền |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `tien_tt` | Tiền thanh toán |
| `tien_tt_nt` | Tiền thanh toán ngoại tệ |
| `du_hd` | Dư hóa đơn |
| `tk_pt` | Tài khoản phải trả |

---

## Mục đích sử dụng

**APPost2TT.dll là module quản lý "Phân bổ thanh toán công nợ phải trả"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Phân bổ thanh toán cho hóa đơn
- Chọn chứng từ thanh toán (phiếu chi, ủy nhiệm chi)
- Phân bổ số tiền thanh toán cho các hóa đơn chưa tất toán
- Hỗ trợ đa tiền tệ với tỷ giá chuyển đổi
- Tính toán tự động số tiền còn lại sau phân bổ

#### 2. Quản lý thông tin chứng từ
- Hiển thị thông tin khách hàng (mã KH, tên KH)
- Thông tin chứng từ (số CT, ngày CT, loại CT)
- Thông tin tiền tệ (mã NT, tỷ giá)
- Tổng tiền VND và ngoại tệ

#### 3. Tính toán tự động
- Tính số tiền phân bổ còn lại (VND và NT)
- Chuyển đổi ngoại tệ theo tỷ giá
- Kiểm tra số tiền phân bổ không vượt quá tổng tiền
- Tính tiền thanh toán quy đổi

#### 4. Các thao tác
- Thêm mới phân bổ (btnNhan)
- Xóa phân bổ (btnXoa)
- Tìm kiếm chứng từ (btnTim_ct)
- In báo cáo (btnHuy)
- Di chuyển giữa các chứng từ (First, Prev, Next, Last)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra validation dữ liệu đầu vào
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình
- Tích hợp với Asia ERP Framework
- Sử dụng DAO pattern cho truy cập dữ liệu

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc phân bổ thanh toán công nợ phải trả - một chức năng quan trọng trong quản lý kế toán công nợ nhà cung cấp.

---

*Ngày phân tích: 2026-03-29*
