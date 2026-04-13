# Báo cáo Phân tích DLL: COPB.dll

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
| Assembly Name | COPB |
| Assembly Title | BÚT TOÁN PHÂN BỔ TỰ ĐỘNG |
| Assembly Company | Asia |
| Assembly Product | COPB |
| Assembly Copyright | Copyright © Asia 2011 |
| Assembly Trademark | |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 5951a517-8a01-41ab-b0b9-87635fe2f2fd |
| ComVisible | false |

---

## Cấu trúc File

```
COPB.dll/
├── COPB.csproj                # Project file
├── app.ico                      # Application icon
├── AsiaErp.UserInterface.frmCOPB.resx  # Resource file
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── My/
│   ├── MyComputer.cs
│   ├── MyApplication.cs
│   ├── MyProject.cs
│   ├── MySettings.cs
│   └── MySettingsProperty.cs
├── My.Resources/
│   └── Resources.cs             # Resource manager
├── AsiaErp.DataAccess/
│   └── COPBDAO.cs             # Data Access Object
└── AsiaErp.UserInterface/
    └── frmCOPB.cs             # Main form
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

- `AsiaErp.DataAccess`, `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmCOPB` | `frmAsiaRoot` | Form thực hiện bút toán phân bổ tự động |
| `COPBDAO` | - | Data Access Object cho phân bổ |
| `Resources` | - | Resource manager |

---

## Chi tiết Forms

### frmCOPB (Main Form)
- **Kế thừa**: `frmAsiaRoot`
- **Chức năng**: Thực hiện bút toán phân bổ chi phí tự động
- **Controls chính**:
  - `GrB_KBC`: GroupBox kỳ báo cáo
  - `cboKyBc`: ComboBox chọn kỳ báo cáo (AsComboBox)
  - `txtNgay1`, `txtNgay2`: Ngày bắt đầu/kết thúc (AsMaskedTextBox)
  - `chk_CheckAll`: CheckBox chọn tất cả
  - `dgvDMPB`: DataGridView danh mục phân bổ 1 (AsInputDGV)
  - `dgvDMPB2`: DataGridView danh mục phân bổ 2 (AsInputDGV)
  - `btn_PB`: Button thực hiện phân bổ
  - `btn_XPB`: Button xóa phân bổ
  - `btn_exit`: Button thoát
  - `sbtn_DHS`: SplitButton điều kiện hệ số
  - `lblDien_hs`: Label diễn giải hệ số

### DataGridView Columns

#### dgvDMPB Columns
| Column | Type | Mô tả |
|--------|------|---------|
| `dgvcID_` | DataGridViewTextBoxColumn | ID |
| `dgvcTag` | DataGridViewCheckBoxColumn | Chọn |
| `dgvcTen_bt` | DataGridViewAsTextBoxColumn | Tên bút toán |
| `dgvcTheoSPCT` | DataGridViewCheckBoxColumn | Theo SPCT |
| `dgvcTheoBP` | DataGridViewCheckBoxColumn | Theo bộ phận |
| `dgvcTheoTKDU` | DataGridViewCheckBoxColumn | Theo TK đối ứng |
| `dgvcTk_pb` | DataGridViewTextBoxColumn | TK phân bổ |
| `dgvcTien_Pb` | DataGridViewAsTextNumericColumn | Tiền phân bổ |

#### dgvDMPB2 Columns
| Column | Type | Mô tả |
|--------|------|---------|
| `dgvcID` | DataGridViewTextBoxColumn | ID |
| `dgvThang` | DataGridViewTextBoxColumn | Tháng |
| `dgvcTk` | DataGridViewTextBoxColumn | Tài khoản |
| `dgvcTen_tk` | DataGridViewTextBoxColumn | Tên tài khoản |
| `dgvcMa_spct` | DataGridViewTextBoxColumn | Mã SPCT |
| `dgvcTen_spct` | DataGridViewTextBoxColumn | Tên SPCT |
| `dgvcMa_bo` | DataGridViewTextBoxColumn | Mã bộ phận |
| `dgvcTen_Bp` | DataGridViewTextBoxColumn | Tên bộ phận |
| `dgvcTk_du` | DataGridViewTextBoxColumn | TK đối ứng |
| `dgvcTen_tk_du` | DataGridViewTextBoxColumn | Tên TK đối ứng |
| `dgvcHe_so` | DataGridViewAsTextNumericColumn | Hệ số |
| `dgvTien_nhan` | DataGridViewAsTextNumericColumn | Tiền nhận |

### DataTables
- `dtDMPB1`: DataTable cho danh mục phân bổ 1
- `dtDMPB2`: DataTable cho danh mục phân bổ 2
- `dtCBB`: DataTable cho combo box

---

## Data Access Layer

### COPBDAO
- **Namespace**: `AsiaErp.DataAccess`
- **Chức năng**: Truy cập dữ liệu cho phân bổ
- **Thuộc tính**: `odao` - instance của COPBDAO

---

## Các chuỗi Text đáng chú ý

### Tiêu đề và nhãn UI
- "BÚT TOÁN PHÂN BỔ TỰ ĐỘNG" - Tên chức năng
- "Kỳ báo cáo", "Từ ngày", "Đến ngày"
- "Phân bổ", "Xóa phân bổ"
- "Theo SPCT", "Theo bộ phận", "Theo TK đối ứng"

### Thuật ngữ

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| `pb` | Phân bổ |
| `tk_pb` | Tài khoản phân bổ |
| `tien_pb` | Tiền phân bổ |
| `he_so` | Hệ số phân bổ |
| `tien_nhan` | Tiền nhận phân bổ |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ma_bo` | Mã bộ phận |
| `tk_du` | Tài khoản đối ứng |

---

## Mục đích sử dụng

**COPB.dll là module thực hiện "Bút toán phân bổ tự động"** trong hệ thống ERP của Asia.

### Chức năng chính

#### 1. Phân bổ chi phí tự động
- Thực hiện bút toán phân bổ chi phí gián tiếp
- Phân bổ theo nhiều tiêu chí: SPCT, bộ phận, TK đối ứng
- Tính toán hệ số và tiền phân bổ tự động

#### 2. Quản lý kỳ phân bổ
- Chọn kỳ báo cáo (tháng/quý/năm)
- Xác định khoảng thời gian phân bổ
- Lưu lịch sử phân bổ

#### 3. Xử lý phân bổ
- Tính toán tiền nhận phân bổ
- Áp dụng hệ số phân bổ
- Xóa phân bổ khi cần điều chỉnh

#### 4. Tích hợp danh mục
- Lấy dữ liệu từ CODMPB (Danh mục phân bổ)
- Hiển thị chi tiết phân bổ theo TK, SPCT, BP

### Đặc điểm kỹ thuật

- Sử dụng 2 DataGridView (master-detail)
- SplitContainer cho layout
- COPBDAO cho data access
- ContextMenuStrip cho tùy chọn

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP, phục vụ cho việc thực hiện bút toán phân bổ chi phí tự động - công cụ quan trọng trong kế toán giá thành để phân bổ chi phí gián tiếp về các đối tượng chi phí trực tiếp.

---

*Ngày phân tích: 2026-03-29*
