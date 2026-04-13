# Báo cáo Phân tích DLL: PODMHTTT.dll

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
| Assembly Name | PODMHTTT |
| Assembly Title | Danh mục hình thức thanh toán mua |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © Asia 2010 |
| Assembly Trademark | Asia |
| Assembly Version | 9.1.0.0 |
| ComVisible | false |

---

## Cấu trúc File

```
PODMHTTT.dll/
├── PODMHTTT.csproj              # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmPODMHTTT.cs         # Main form class (danh mục view)
│   └── frmPODMHTTTEdit.cs      # Edit form class
├── AsiaErp.UserInterface.My/
│   └── Resources/
│       └── Resources.cs         # Resource manager
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| Framework | Asia ERP Framework (../../../../native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (../../../../native-apps/ASIA/Helper.dll) |
| System.Data | Data access |
| System.Core | LINQ support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Collections.Generic`, `System.ComponentModel`, `System.Diagnostics`, `System.Drawing`, `System.Linq`, `System.Runtime.CompilerServices`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmPODMHTTT` | `frmDMComplexView` | Form xem danh mục hình thức thanh toán mua |
| `frmPODMHTTTEdit` | `frmDMComplexEdit` | Form chỉnh sửa hình thức thanh toán mua |

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Danh mục hình thức thanh toán mua" - Tên chức năng chính
- "Mã hình thức" (`txtMa_httt`)
- "Tên hình thức" (`txtTen_httt`)
- "Tài khoản" (`txtTK`)
- "Tên tài khoản" (`lblTen_Tk`)
- "Tài khoản thuế mua" (`txtThue_mua`)
- "Tên TK thuế mua" (`lblTen_Tk_thue_mua`)
- "Tài khoản thuế NK" (`txtThue_NK`)
- "Tên TK thuế NK" (`lblTen_TK_thue_NK`)
- "Tài khoản NK nợ" (`txtTK_NK_no`)
- "Tên TK NK nợ" (`lblTen_TK_NK_no`)
- "Tài khoản NK có" (`txtTK_NK_co`)
- "Tên TK NK có" (`lblTen_TK_NK_co`)
- "Tài khoản thuế TTĐB" (`txtTk_thue_ttdb`)
- "Tên TK thuế TTĐB" (`lblTen_tk_thue_ttdb`)
- "Tài khoản chiết khấu" (`txtTk_ck`)
- "Tên TK chiết khấu" (`lblTk_ck`)
- "Thuế GTGT trả lại" (`txtThue_gtgt_tralai`)

### Thuật ngữ nghiệp vụ

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `ma_httt` | Mã hình thức thanh toán mua |
| `ten_httt` | Tên hình thức thanh toán mua |
| `tk` | Tài khoản thanh toán |
| `tk_thue_mua` | Tài khoản thuế GTGT mua |
| `tk_thue_nk` | Tài khoản thuế nhập khẩu |
| `tk_gtgt_nk_no` | Tài khoản GTGT NK nợ |
| `tk_gtgt_nk_co` | Tài khoản GTGT NK có |
| `tk_thue_ttdb` | Tài khoản thuế tiêu thụ đặc biệt |
| `tk_ck` | Tài khoản chiết khấu |
| `thue_gtgt_tralai` | Tài khoản thuế GTGT trả lại |

---

## Mục đích sử dụng

**PODMHTTT.dll là module quản lý Danh mục hình thức thanh toán mua** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý hình thức thanh toán
- Thêm mới hình thức thanh toán
- Chỉnh sửa thông tin hình thức thanh toán
- Xóa hình thức không còn sử dụng
- Tìm kiếm và lọc danh mục

#### 2. Thông tin quản lý
- Mã hình thức thanh toán (`ma_httt`)
- Tên hình thức thanh toán (`ten_httt`)
- Tài khoản thanh toán (`tk`)
- Tài khoản thuế GTGT mua (`tk_thue_mua`)
- Tài khoản thuế nhập khẩu (`tk_thue_nk`)
- Tài khoản GTGT NK nợ/có (`tk_gtgt_nk_no`, `tk_gtgt_nk_co`)
- Tài khoản thuế TTĐB (`tk_thue_ttdb`)
- Tài khoản chiết khấu (`tk_ck`)
- Tài khoản thuế GTGT trả lại (`thue_gtgt_tralai`)

#### 3. Cấu hình tài khoản mặc định
- Lấy cấu hình từ `POConfiguration`
- Thiết lập giá trị mặc định cho các tài khoản:
  - `tk_pt`: Tài khoản phải trả
  - `tk_thue_gtgt`: Tài khoản thuế GTGT
  - `tk_thue_nk`: Tài khoản thuế NK
  - `tk_gtgt_nk_no/co`: Tài khoản GTGT NK
  - `tk_thue_ttdb`: Tài khoản thuế TTĐB
  - `tk_ck`: Tài khoản chiết khấu

### Ý nghĩa nghiệp vụ

Hình thức thanh toán mua hàng quy định:
- Phương thức thanh toán (tiền mặt, chuyển khoản, ...)
- Các tài khoản kế toán liên quan đến thanh toán
- Các tài khoản thuế áp dụng
- Xử lý chiết khấu thanh toán
- Xử lý thuế nhập khẩu (nếu có)

### Đặc điểm kỹ thuật

- Kế thừa từ `frmDMComplexView` và `frmDMComplexEdit` (Framework chuẩn của Asia ERP)
- Sử dụng `AsTextBox` cho các trường nhập liệu có validation
- Tích hợp với `POConfiguration` để lấy cấu hình mặc định
- Hỗ trợ validation dữ liệu đầu vào
- Tích hợp với hệ thống phân quyền của Asia ERP

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý danh mục hình thức thanh toán mua - một danh mục quan trọng trong việc cấu hình tài khoản kế toán cho các giao dịch mua hàng.

---

*Ngày phân tích: 2026-03-29*
