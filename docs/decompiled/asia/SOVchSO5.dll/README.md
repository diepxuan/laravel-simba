# Báo cáo Phân tích DLL: SOVchSO5.dll

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
| Assembly Name | SOVchSO5 |
| Assembly Title | Hóa đơn bán dịch vụ |
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
SOVchSO5.dll/
├── SOVchSO5.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSoVchSO5.cs           # Main form - Hóa đơn bán dịch vụ
│   ├── frmSoVchSO5Find.cs       # Form tìm kiếm báo giá
│   └── frmSoVchSo5Print.cs      # Form in ấn báo giá
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
| System.Core | .NET Core extensions |
| System.Data.DataSetExtensions | DataSet extensions |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| SOUtilities | Sales Order Utilities (../../../../native-apps/ASIA/SOUtilities.dll) |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.SOUtilities`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSoVchSO5` | `frmVoucher` | Form nhập liệu chính cho Hóa đơn bán dịch vụ / Báo giá |
| `frmSoVchSO5Find` | `frmVoucherFind` | Form tìm kiếm báo giá |
| `frmSoVchSo5Print` | `frmVoucherPrint` | Form in ấn báo giá |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Hóa đơn bán dịch vụ" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng", "Địa chỉ", "Người giao dịch"
- "Số seri", "Ngày lập", "Diễn giải"
- "Mã ngoại tệ", "Tỷ giá"
- "Tài khoản phải thu", "Tài khoản thuế"
- "Tổng tiền", "Thuế GTGT", "Chiết khấu", "Thanh toán"

### Cột DataGridView (Chi tiết dịch vụ)

| Cột | Ý nghĩa |
|-----|---------|
| Ma_vt | Mã dịch vụ |
| Ten_vt | Tên dịch vụ |
| Dvt | Đơn vị tính |
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

**SOVchSO5.dll là module quản lý chứng từ "Hóa đơn bán dịch vụ"** trong hệ thống ERP của Asia Software Development JSC. Đây là module chuyên biệt cho việc bán các loại dịch vụ (không phải hàng hóa vật chất).

### Chức năng chính

#### 1. Nhập liệu Hóa đơn bán dịch vụ
- Quản lý thông tin khách hàng (mã KH, tên, địa chỉ, mã số thuế, người giao dịch)
- Quản lý thông tin hóa đơn dịch vụ (số seri, ngày lập, diễn giải)
- Xử lý đa tiền tệ (mã ngoại tệ, tỷ giá)
- Quản lý tài khoản kế toán (TK phải thu, TK thuế)

#### 2. Chi tiết dịch vụ
- Nhập liệu dịch vụ (mã dịch vụ, tên dịch vụ, đơn vị tính)
- Quản lý số lượng và giá dịch vụ
- Tính toán thành tiền tự động
- Hỗ trợ chiết khấu (tỷ lệ chiết khấu, tiền chiết khấu)
- Tính thuế GTGT theo từng dòng dịch vụ

#### 3. Tính toán tự động
- Tính tổng tiền dịch vụ
- Tính tổng thuế GTGT
- Tính tổng chiết khấu
- Tính tổng thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính dư công nợ (Du13) theo khách hàng

#### 4. Hạch toán kế toán
- Tab hạch toán riêng
- Grid hạch toán tự động
- Phân bổ doanh thu dịch vụ
- Hạch toán thuế GTGT đầu ra
- Không hạch toán kho (vì là dịch vụ)

#### 5. Tính năng đặc biệt
- Hỗ trợ sửa chiết khấu (`chkSua_ck`)
- Hỗ trợ sửa thuế (`chkSua_thue`)
- Tính toán công nợ tự động (`txtGh_no`)

#### 6. Tìm kiếm và In ấn
- Tìm kiếm hóa đơn dịch vụ theo nhiều tiêu chí (`frmSoVchSO5Find`)
- In báo giá/hóa đơn dịch vụ (`frmSoVchSo5Print`)

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã dịch vụ, số lượng, giá)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với SOUtilities cho các hàm chung của Sales Order
- Không quản lý kho (vì là dịch vụ, không có tồn kho)
- Hỗ trợ sửa chiết khấu và thuế thủ công

### Điểm khác biệt với SOVchSO3

| Đặc điểm | SOVchSO3 (Hàng hóa) | SOVchSO5 (Dịch vụ) |
|-----------|----------------------|---------------------|
| Quản lý kho | Có | Không |
| Tồn kho | Có | Không |
| TK vật tư | Có | Không |
| TK giá vốn | Có | Không |
| Chiết khấu | Có | Có (sửa được) |
| Sửa thuế | Không | Có |

### Mã chứng từ

**SO5** (Hóa đơn bán dịch vụ) - chứng từ xuất hóa đơn cho các dịch vụ cung cấp cho khách hàng.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý và in ấn Hóa đơn bán dịch vụ. Module này chuyên biệt cho việc bán dịch vụ (không phải hàng hóa), do đó không có các chức năng quản lý kho và tồn kho như module SOVchSO3. Module cung cấp đầy đủ chức năng xử lý bán dịch vụ, tính thuế, chiết khấu và hạch toán kế toán.

---

*Ngày phân tích: 2026-03-29*
