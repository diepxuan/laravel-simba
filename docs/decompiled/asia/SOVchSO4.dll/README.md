# Báo cáo Phân tích DLL: SOVchSO4.dll

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
| Assembly Name | SOVchSO4 |
| Assembly Title | Phiếu nhập hàng bán bị trả lại |
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
SOVchSO4.dll/
├── SOVchSO4.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSoVchSO4.cs           # Main form - Phiếu nhập hàng bán bị trả lại
│   ├── frmSoVchSO4Find.cs       # Form tìm kiếm phiếu nhập
│   ├── frmSoVchSo4FindSO2.cs    # Form tìm kiếm hóa đơn SO2
│   ├── frmSoVchSo4FindSO3.cs    # Form tìm kiếm hóa đơn SO3
│   └── frmSoVchSO4SeachSO2SO3.cs # Form tìm kiếm chi tiết SO2/SO3
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

### Namespaces sử dụng

- `AsiaErp.Framework`
- `AsiaErp.SOUtilities`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSoVchSO4` | `frmVoucher` | Form nhập liệu chính cho Phiếu nhập hàng bán bị trả lại |
| `frmSoVchSO4Find` | `frmVoucherFind` | Form tìm kiếm phiếu nhập hàng trả lại |
| `frmSoVchSo4FindSO2` | `frmAsiaRoot` | Form tìm kiếm hóa đơn bán hàng SO2 |
| `frmSoVchSo4FindSO3` | `frmAsiaRoot` | Form tìm kiếm hóa đơn bán hàng SO3 |
| `frmSoVchSO4SeachSO2SO3` | `frmAsiaRoot` | Form tìm kiếm chi tiết hóa đơn SO2/SO3 |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Phiếu nhập hàng bán bị trả lại" - Tên chức năng chính
- "Mã khách hàng", "Tên khách hàng", "Địa chỉ", "Người giao dịch"
- "Số seri", "Ngày lập", "Diễn giải"
- "Mã ngoại tệ", "Tỷ giá"
- "Tài khoản phải trả", "Tài khoản thuế"
- "Tổng tiền", "Thuế GTGT", "Thanh toán"
- "Số hóa đơn", "Ngày hóa đơn"

### Cột DataGridView (Chi tiết phiếu nhập)

| Cột | Ý nghĩa |
|-----|---------|
| Ma_vt | Mã vật tư |
| Ten_vt | Tên vật tư |
| Dvt | Đơn vị tính |
| Ma_kho | Mã kho |
| So_luong | Số lượng trả lại |
| Gia_nt2 | Giá ngoại tệ 2 |
| Tien_nt2 | Tiền ngoại tệ 2 |
| Ts_gtgt | Thuế suất GTGT |
| Thue_gtgt_nt | Thuế GTGT ngoại tệ |
| Gia2 | Giá 2 |
| Tien2 | Tiền 2 |
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
| `t_tt` | Tổng thanh toán |
| `tk_pt` | Tài khoản phải trả |
| `tk_thue` | Tài khoản thuế |
| `ma_kh` | Mã khách hàng |
| `ma_httt` | Mã hình thức thanh toán |
| `du13` | Dư công nợ |
| `so_hd` | Số hóa đơn gốc |
| `ngay_hd` | Ngày hóa đơn gốc |

---

## Mục đích sử dụng

**SOVchSO4.dll là module quản lý chứng từ "Phiếu nhập hàng bán bị trả lại"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Nhập liệu Phiếu nhập hàng bán bị trả lại
- Quản lý thông tin khách hàng trả hàng (mã KH, tên, địa chỉ, mã số thuế, người giao dịch)
- Quản lý thông tin phiếu nhập (số seri, ngày lập, diễn giải)
- Xử lý đa tiền tệ (mã ngoại tệ, tỷ giá)
- Quản lý tài khoản kế toán (TK phải trả, TK thuế)
- Liên kết với hóa đơn gốc (số HD, ngày HD)

#### 2. Chi tiết hàng hóa trả lại
- Nhập liệu vật tư/hàng hóa trả lại (mã VT, tên VT, đơn vị tính, kho)
- Quản lý số lượng trả lại
- Giữ nguyên giá từ hóa đơn gốc
- Tính toán thành tiền tự động
- Tính thuế GTGT điều chỉnh

#### 3. Tính toán tự động
- Tính tổng tiền hàng trả lại
- Tính thuế GTGT điều chỉnh (giảm)
- Tính tổng thanh toán
- Chuyển đổi ngoại tệ theo tỷ giá
- Tính dư công nợ (Du13) theo khách hàng

#### 4. Hạch toán kế toán
- Tab hạch toán riêng (`tabHach_toan`)
- Grid hạch toán tự động (`adgvHach_toan`)
- Hạch toán giảm doanh thu
- Hạch toán giảm thuế GTGT đầu ra
- Hạch toán nhập kho (tăng tồn kho)

#### 5. Tích hợp với hóa đơn bán hàng
- Chọn hóa đơn gốc từ SO2/SO3
- Tìm kiếm hóa đơn (`frmSoVchSo4FindSO2`, `frmSoVchSo4FindSO3`)
- Lấy thông tin chi tiết từ hóa đơn gốc
- Kiểm tra số lượng trả lại không vượt quá số lượng đã bán

#### 6. Tab Thuế đầu vào (TaIn)
- Tab thuế riêng (`tabTain`)
- Tích hợp với `ctlTaIn` (control thuế đầu vào)
- Xử lý thuế GTGT điều chỉnh khi trả hàng

#### 7. Tìm kiếm
- Tìm kiếm phiếu nhập hàng trả lại theo nhiều tiêu chí

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable (PHTable, CTTable)
- Kiểm tra validation dữ liệu đầu vào (mã KH, mã VT, số lượng)
- Hỗ trợ nhiều loại tiền tệ với làm tròn theo cấu hình hệ thống
- Tích hợp với SOUtilities cho các hàm chung của Sales Order
- Hỗ trợ sửa thuế (`chkSua_thue`)
- Hỗ trợ sửa tiền (`chkSua_tien`)
- Kiểm tra số lượng trả lại hợp lệ

### Mã chứng từ

**SO4** (Phiếu nhập hàng bán bị trả lại) - chứng từ xử lý việc khách hàng trả lại hàng đã mua.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc nhập liệu, quản lý phiếu nhập hàng bán bị trả lại. Module này tích hợp chặt chẽ với module hóa đơn bán hàng (SO2, SO3) và cung cấp đầy đủ chức năng xử lý trả hàng, điều chỉnh thuế, và hạch toán kế toán ngược lại.

---

*Ngày phân tích: 2026-03-29*
