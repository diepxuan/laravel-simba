# Báo cáo Phân tích DLL: GlRptBctc01.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework 3.5 |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | GlRptBctc01 |
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
GlRptBctc01.dll/
├── GlRptBctc01.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
└── AsiaErp.UserInterface/
    └── frmGlRptBctc01.cs      # Main form class
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| AsiaErp.Framework | Asia ERP Framework |
| AsiaErp.Helper | Asia ERP Helper |
| System.Data | Data access |
| System.Windows.Forms | Windows Forms |
| Microsoft.VisualBasic | Visual Basic runtime support |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGlRptBctc01` | `frmReport` | Form báo cáo bảng cân đối phát sinh các tài khoản |

---

## Controls và UI Components

### Controls chính

| Control | Kiểu | Mục đích |
|---------|------|----------|
| `txtTk` | AsTextBox | Nhập tài khoản |
| `txtBac` | AsTextNumeric | Nhập bậc tài khoản (mặc định = 9) |
| `chkTK_sc` | CheckBox | Lên cho tài khoản sổ cái |
| `lblTk` | Label | Nhãn "Tài khoản" |
| `lblbac` | Label | Nhãn "In đến bậc" |

### Controls kế thừa từ frmReport

| Control | Mục đích |
|---------|----------|
| `cboKyBc` | Chọn kỳ báo cáo |
| `txtNgay1`, `txtNgay2` | Ngày bắt đầu/kết thúc |
| `cboMau_bc` | Chọn mẫu báo cáo |
| `txtTieu_De` | Tiêu đề báo cáo |
| `txtMa_Nt` | Mã ngoại tệ |
| `optVND`, `optNt` | Tùy chọn tiền tệ |
| `cmdOk`, `cmdCancel` | Nút OK/Cancel |
| `cmdExcel` | Xuất Excel |
| `cmdModifyReport` | Sửa báo cáo |

---

## Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|----------|
| `tk` | Tài khoản |
| `bac` | Bậc tài khoản |
| `ma_nt` | Mã ngoại tệ |
| `ngay_ct1`, `ngay_ct2` | Ngày chứng từ từ/đến |
| `TK_sc` | Tài khoản sổ cái |

---

## Phím tắt

| Phím | Chức năng |
|------|------------|
| F5 | Sổ chữ T |
| Ctrl+F5 | Sổ chi tiết |
| Shift+F5 | Cân đối phát sinh công nợ |
| F7 | Xem báo cáo |
| F9 | In báo cáo |

---

## Business Logic

### LoadData

Phương thức `LoadData` thực hiện:
1. Tạo ArrayList với các tham số:
   - CompanyID
   - Ngày bắt đầu (txtNgay1)
   - Ngày kết thúc (txtNgay2)
   - Tài khoản (txtTk)
   - Bậc tài khoản (txtBac)
   - Checkbox TK_sc
   - Mã ngoại tệ (txtMa_Nt)
2. Gọi `base.MyController.GetData` để lấy dữ liệu
3. Thiết lập Parameters4DrillDown cho drill-down

### Drill-down

Hỗ trợ drill-down với các phím:
- **F5**: Drill-down đến sổ chữ T của tài khoản
- **Ctrl+F5**: Drill-down đến sổ chi tiết
- **Shift+F5**: Drill-down đến cân đối phát sinh công nợ (nếu tk_cn = 1)

---

## Mục đích sử dụng

**GlRptBctc01.dll là module báo cáo "Bảng cân đối phát sinh các tài khoản"** trong hệ thống ERP của Asia Software Development JSC.

### Chức năng chính

1. **Báo cáo cân đối phát sinh**: Hiển thị bảng cân đối phát sinh của các tài khoản theo kỳ
2. **Lọc theo tài khoản**: Cho phép lọc theo tài khoản cụ thể và bậc tài khoản
3. **Lên sổ cái**: Tùy chọn chỉ hiển thị các tài khoản sổ cái
4. **Hỗ trợ đa tiền tệ**: Xem báo cáo theo VND hoặc ngoại tệ
5. **Drill-down**: Xem chi tiết sổ sách từ báo cáo tổng hợp

### Đặc điểm kỹ thuật

- Kế thừa từ `frmReport` - form báo cáo chuẩn của Asia ERP
- Sử dụng `AsTabControl` để chuyển đổi giữa filter và grid
- Tích hợp với framework báo cáo của Asia ERP
- Hỗ trợ xuất Excel và in ấn

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP Asia Enterprise, phục vụ cho việc xem và in ấn báo cáo bảng cân đối phát sinh các tài khoản - một báo cáo tài chính quan trọng trong kế toán doanh nghiệp.

---

*Ngày phân tích: 2026-03-29*
