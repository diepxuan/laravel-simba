# Báo cáo Phân tích DLL: CoNgungKHCPTT.dll

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
| Assembly Name | CoNgungKHCPTT |
| Assembly Title | FADMCC |
| Assembly Product | FADMCC |
| Assembly Copyright | Copyright © 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | b71f3569-e439-4607-b511-60dc5628362c |
| ComVisible | false |

---

## Cấu trúc File

```
CoNgungKHCPTT.dll/
├── CoNgungKHCPTT.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/                          # VB.NET My namespace support
│   ├── MyApplication.cs
│   ├── MyComputer.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MySettingsProperty.cs
│   └── InternalXmlHelper.cs
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaErp.UserInterface/
│   ├── frmCoNgungKhCPTT.cs      # Main form (view list)
│   └── frmCoNgungKhCPTTEdit.cs  # Edit form
└── AsiaErp.DataAccess/
    ├── COPBDAO.cs               # DAO interface
    └── MsSqlCOPBDAO.cs          # SQL Server DAO implementation
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| System.Xml.Linq | XML LINQ support |
| System.Core | .NET Core extensions |
| Framework | Asia ERP Framework (native-apps/ASIA/Framework.dll) |
| Helper | Asia ERP Helper (native-apps/ASIA/Helper.dll) |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCoNgungKhCPTT` | `frmDMComplexView` | Form danh sách xem các chi phí TT đã ngừng KH |
| `frmCoNgungKhCPTTEdit` | `frmDMComplexEdit` | Form thêm/sửa thông tin ngừng phân bổ chi phí |
| `COPBDAO` | `DAO` (interface) | Interface định nghĩa các phương thức DAO |
| `MsSqlCOPBDAO` | `MsSqlDAO` | Triển khai SQL Server cho COPBDAO |
| `Resources` | - | Resource manager cho localization |

---

## UI Controls và Events

### frmCoNgungKhCPTT (Form danh sách)

| Control | Mục đích |
|---------|----------|
| `cmdAdd` | Nút thêm mới (được đặt lại vị trí) |
| `cmdDel` | Nút xóa |
| `cmdEdit` | Nút sửa |
| `cmdSearch` | Ẩn (Visible = false) |
| `cmdPrint` | Ẩn (Visible = false) |
| `cmdChgCode` | Ẩn (Visible = false) |
| `txtValue` | Ẩn (Visible = false) |
| `cboFilter` | Ẩn (Visible = false) |
| `lblTen` | Ẩn (Visible = false) |

**Events chính:**
- `GetData()`: Lấy dữ liệu danh sách chi phí TT ngừng KH
- `Delete()`: Xóa bản ghi ngừng KH (gọi stored procedure `asCoDelNgungKH_CPTT`)

### frmCoNgungKhCPTTEdit (Form chỉnh sửa)

| Control | Type | Mục đích |
|---------|------|----------|
| `txtMa_cptt` | `AsTextBox` | Mã chi phí (lookup tự động) |
| `lblTen_cptt` | `Label` | Tên chi phí (hiển thị từ lookup) |
| `txtNguyen_gia` | `AsTextNumeric` | Nguyên giá (read-only) |
| `txtNgay_bd_kh` | `AsMaskedTextBox` | Ngày bắt đầu phân bổ (read-only) |
| `txtNgay_tkh` | `DateTimePicker` | Tháng ngừng phân bổ (MM/yyyy) |
| `chkKh_so_du` | `CheckBox` | Phân bổ nốt số dư vào tháng ngừng |
| `txtID` | `AsTextNumeric` | ID (hidden, read-only) |
| `chkKsd` | `AsCheckBox` | Không sử dụng (hidden) |

**Events chính:**
- `txtMa_cptt.AfterCodeValidating`: Sau khi chọn mã chi phí, load thông tin tên, nguyên giá, ngày bắt đầu KH
- `txtNgay_tkh.Validated`: Validate và định dạng lại ngày tháng
- `InitBeforeGetData()`: Khởi tạo giá trị mặc định
- `ValidData()`: Kiểm tra dữ liệu hợp lệ trước khi lưu
- `InsertToDB() / UpdateDB()`: Thêm mới/cập nhật (gọi `asCoUpdNgungKH_CPTT`)

---

## Data Access Layer

### COPBDAO Interface

```csharp
public interface COPBDAO : DAO
{
    int CoUpdNgungKH_CPTT(params object[] para);  // Insert/Update
    int CoDelNgungKH_CPTT(params object[] para);  // Delete
}
```

### MsSqlCOPBDAO Implementation

| Method | Stored Procedure | Mô tả |
|--------|------------------|-------|
| `CoUpdNgungKH_CPTT` | `asCoUpdNgungKH_CPTT` | Thêm mới hoặc cập nhật thông tin ngừng phân bổ |
| `CoDelNgungKH_CPTT` | `asCoDelNgungKH_CPTT` | Xóa thông tin ngừng phân bổ |

**Parameters cho `asCoUpdNgungKH_CPTT`:**
- `@pMa_cty`: Mã công ty
- `@pMa_cptt`: Mã chi phí
- `@pNgay_tkh`: Ngày tháng ngừng phân bổ
- `@pKh_so_du`: Có phân bổ nốt số dư không
- `@pIsUpd`: Flag insert (false) hay update (true)
- `@pRet`: Output parameter (return code)

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI

- "Mã chi phí" - Label cho trường mã chi phí
- "Nguyên giá" - Label cho trường nguyên giá
- "Ngày bắt đầu phân bổ" - Label cho ngày bắt đầu KH
- "Dừng phân bổ tại cuối tháng" - Label cho ngày ngừng KH
- "Phân bổ nốt số dư vào tháng ngừng phân bổ" - Checkbox label

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `ma_cptt` | Mã chi phí trực tiếp |
| `ten_cptt` | Tên chi phí trực tiếp |
| `ng_gia` | Nguyên giá |
| `ngay_bdkh` | Ngày bắt đầu khấu hao/phân bổ |
| `ngay_tkh` | Ngày tháng ngừng khấu hao |
| `thang_tkh` | Tháng ngừng khấu hao (text) |
| `kh_so_du` | Khấu hao số dư (phân bổ nốt) |
| `dvt` | Đơn vị tính |

---

## Mục đích sử dụng

**CoNgungKHCPTT.dll là module quản lý "Cơ ngừng khấu hao chi phí trực tiếp"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

#### 1. Quản lý ngừng phân bổ chi phí
- Xem danh sách các chi phí trực tiếp đã ngừng phân bổ
- Thêm mới thông tin ngừng phân bổ cho chi phí
- Sửa thông tin ngừng phân bổ (tháng ngừng, phân bổ nốt số dư)
- Xóa thông tin ngừng phân bổ

#### 2. Thông tin quản lý
- **Mã chi phí**: Lookup từ danh mục chi phí trực tiếp
- **Tên chi phí**: Hiển thị tự động từ lookup
- **Nguyên giá**: Read-only, lấy từ danh mục
- **Ngày bắt đầu phân bổ**: Read-only, lấy từ danh mục
- **Tháng ngừng phân bổ**: Chọn tháng/năm (MM/yyyy)
- **Phân bổ nốt số dư**: Option để phân bổ hết số dư vào tháng cuối

#### 3. Validation và Business Logic
- Kiểm tra mã chi phí không được để trống
- Kiểm tra ngày tháng ngừng phân bổ hợp lệ (không phải 01/01/1900)
- Lookup tự động thông tin chi phí khi nhập mã
- Format ngày tháng theo định dạng MM/yyyy

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với BindingSource (`bsDanhMuc`)
- Kiểm tra validation dữ liệu đầu vào trước khi lưu
- Sử dụng stored procedure cho các thao tác INSERT/UPDATE/DELETE
- Tích hợp với Asia ERP Framework (frmDMComplexView, frmDMComplexEdit)
- Lookup code tự động với `AsTextBox.AutoLookup = true`

### Mã chứng từ liên quan

**CPTT** (Chi phí trực tiếp) - loại chi phí được phân bổ theo thời gian trong kế toán doanh nghiệp.

---

## Kết luận

Đây là một module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc quản lý việc ngừng phân bổ khấu hao cho các chi phí trực tiếp. Module cho phép người dùng đánh dấu thời điểm ngừng phân bổ và tùy chọn phân bổ nốt số dư vào tháng cuối cùng.

---

*Ngày phân tích: 2026-03-29*
