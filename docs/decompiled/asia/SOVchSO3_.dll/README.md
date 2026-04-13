# Báo cáo Phân tích DLL: SOVchSO3_.dll

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
| Assembly Name | SOVchSO3 |
| Assembly Title | Hoá đơn bán hàng |
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
SOVchSO3_.dll/
├── SOVchSO3_.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSoVchSO3.cs           # Main form - Hóa đơn bán hàng
│   ├── frmSoVchSO3Find.cs       # Form tìm kiếm hóa đơn
│   ├── frmSoVchSo3FindSO1.cs    # Form tìm kiếm đơn hàng SO1
│   ├── frmSoVchSO3SeachSO1.cs   # Form tìm kiếm chi tiết SO1
│   └── frmSoVchSo3ViewCrystal.cs  # Form xem báo cáo Crystal
└── AsiaErp.UserInterface.My.Resources/
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
| SOUtilities | Sales Order Utilities (../../../../native-apps/ASIA/SOUtilities.dll) |
| CrystalDecisions.Shared | Crystal Reports integration |
| CrystalDecisions.CrystalReports.Engine | Crystal Reports engine |
| CrystalDecisions.Windows.Forms | Crystal Reports Windows Forms |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.SOUtilities`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`
- `CrystalDecisions.Shared`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSoVchSO3` | `frmVoucher` | Form nhập liệu chính cho Hóa đơn bán hàng |
| `frmSoVchSO3Find` | `frmVoucherFind` | Form tìm kiếm hóa đơn |
| `frmSoVchSo3FindSO1` | `frmAsiaRoot` | Form tìm kiếm đơn hàng SO1 |
| `frmSoVchSO3SeachSO1` | `frmAsiaRoot` | Form tìm kiếm chi tiết đơn hàng SO1 |
| `frmSoVchSo3ViewCrystal` | `Form` | Form xem báo cáo Crystal Reports |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Hoá đơn bán hàng" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng", "Địa chỉ", "Người giao dịch"
- "Số seri", "Ngày lập", "Diễn giải"
- "Mã ngoại tệ", "Tỷ giá"
- "Tài khoản phải thu", "Tài khoản thuế"
- "Tổng tiền", "Thuế GTGT", "Chiết khấu", "Thanh toán"

### Cột DataGridView (Chi tiết hóa đơn)

| Cột | Ý nghĩa |
|-----|---------|
| Ma_vt | Mã vật tư |
| Ten_vt | Tên vật tư |
| Dvt | Đơn vị tính |
| Ma_kho | Mã kho |
| Ton | Tồn kho |
| So_luong | Số lượng |
| Gia_nt2 | Giá ngoại tệ 2 |
| Tien_nt2 | Tiền ngoại tệ 2 |
| Tl_ck | Tỷ lệ chiết khấu |
| Tien_ck_nt | Tiền chiết khấu ngoại tệ |
| Ts_gtgt | Thuế suất GTGT |
| Thue_gtgt_nt | Thuế GTGT ngoại tệ |
| Gia2 | Giá 2 |
| Tien2 | Tiền 2 |
| Tien_ck | Tiền chiết khấu |
| Thue_gtgt | Thuế GTGT |
| Gia_nt | Giá ngoại tệ |
| Tien_nt | Tiền ngoại tệ |
| Gia | Giá |
| Tien | Tiền |
| Ma_Nvkd | Mã nhân viên kinh doanh |
| Tk_dt | Tài khoản doanh thu |
| Tk_gv | Tài khoản giá vốn |
| Tk_vt | Tài khoản vật tư |
| Tk_ck | Tài khoản chiết khấu |

### Tab Hạch toán

| Cột | Ý nghĩa |
|-----|---------|
| TK | Tài khoản |
| Ps_no | Phát sinh nợ |
| Ps_co | Phát sinh có |
| Ma_kh | Mã khách hàng |
| Ma_vv | Mã vụ việc |
| Ma_bp | Mã bộ phận |
| Ma_phi | Mã phí |
| Ma_hd | Mã hợp đồng |
| Ma_ku | Mã khế ước |
| Ma_spct | Mã sản phẩm chi tiết |

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `t_tien` | Tổng tiền |
| `t_thue` | Tổng thuế |
| `t_ck` | Tổng chiết khấu |
| `t_tt` | Tổng thanh toán |
| `tk_pt` | Tài khoản phải thu |
| `tk_thue` | Tài khoản thuế |
| `ma_kh` | Mã khách hàng |
| `ma_httt` | Mã hình thức thanh toán |
| `du13` | Dư công nợ |

---

## Mục đích sử dụng

**SOVchSO3_.dll là module quản lý chứng từ "Hóa đơn bán hàng"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu Hóa đơn bán hàng
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, mã số thuế, người giao dịch)
- Quản lý thông tin hóa đơn (số seri, ngày lập, diễn giải)
- Xử lý đa tiền tệ (mã ngoại tệ, tỷ giá)
- Quản lý tài khoản kế toán (TK phải thu, TK thuế)

#### 2. Chi tiết hàng hóa/dịch vụ
- Nhập liệu vật tư/hàng hóa (mã VT, tên VT, đơn vị tính, kho)
- Quản lý số lượng và giá (giá ngoại tệ, giá VNĐ)
- Tính toán thành tiền tự động
- Hỗ trợ chiết khấu (tỷ lệ chiết khấu, tiền chiết khấu)
- Tính thuế GTGT theo từng dòng

#### 3. Tính toán tự động
- Tính tổng tiền hàng, tổng thuế, tổng chiết khấu
- Tính tổng thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính dư công nợ (Du13) theo khách hàng

#### 4. Hạch toán kế toán
- Tab hạch toán riêng (`tabHach_toan`)
- Grid hạch toán tự động (`adgvHach_toan`)
- Phân bổ doanh thu, giá vốn, chiết khấu

#### 5. Tích hợp với đơn hàng
- Chọn đơn hàng từ SO1 (`cmdChon_dh`)
- Tìm kiếm đơn hàng (`frmSoVchSo3FindSO1`)
- Liên kết hóa đơn với đơn hàng gốc

#### 6. Tìm kiếm và In ấn
- Tìm kiếm hóa đơn theo nhiều tiêu chí
- In hóa đơn qua Crystal Reports (`frmSoVchSo3ViewCrystal`)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã VT, số lượng, giá)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với SOUtilities cho các hàm chung của Sales Order
- Hỗ trợ giá đặc biệt (`chkGia_dd`)
- Hỗ trợ chiết khấu doanh số (`txtTl_ck_ds`, `txtT_ck_ds`)

### Mã chứng từ

**SO3** (Hóa đơn bán hàng) - phiên bản khác (có dấu _ ở cuối tên DLL)

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý và in ấn Hóa đơn bán hàng. Module này tích hợp chặt chẽ với module đơn hàng (SO1) và cung cấp đầy đủ chức năng xử lý bán hàng, tính thuế, chiết khấu và hạch toán kế toán.

---

*Ngày phân tích: 2026-03-29*
