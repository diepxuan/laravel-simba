# Báo cáo Phân tích DLL: GLPost2DGTG.dll

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
| Assembly Name | GLPost2DGTG |
| Assembly Title | Đánh giá tỷ giá cuối kỳ |
| Assembly Company | ASIASOFT |
| Assembly Product | AsiaERP |
| Assembly Copyright | Copyright © ASIASOFT 2010 |
| Assembly Version | 1.0.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | c1d0e87b-171b-4d35-be97-fbb97ce7955c |
| ComVisible | false |

---

## Cấu trúc File

```
GLPost2DGTG.dll/
├── GLPost2DGTG.csproj         # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.DataAccess/
│   ├── IGLPost2DGTGDAO.cs   # DAO Interface
│   └── MsSqlGLPost2DGTGDAO.cs # SQL Server DAO implementation
├── AsiaErp.UserInterface/
│   └── frmGLPost2DGTG.cs     # Main form class
├── My/
│   ├── MyProject.cs
│   ├── MySettings.cs
│   ├── MyApplication.cs
│   ├── MySettingsProperty.cs
│   └── MyComputer.cs
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
| Framework | Asia ERP Framework |
| Helper | Asia ERP Helper |

### Namespaces sử dụng

- `AsiaErp.DataAccess`
- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmGLPost2DGTG` | `frmAsiaRoot` | Form đánh giá tỷ giá cuối kỳ |
| `IGLPost2DGTGDAO` | `DAO` | Interface cho data access |
| `MsSqlGLPost2DGTGDAO` | `MsSqlDAO` | SQL Server implementation |

---

## UI Controls (frmGLPost2DGTG)

### Input Controls
| Control | Loại | Mục đích |
|---------|------|----------|
| cboKyBc | AsComboBox | Chọn kỳ báo cáo |
| txtNgay1 | AsMaskedTextBox | Ngày bắt đầu (dd/MM/yyyy) |
| txtNgay2 | AsMaskedTextBox | Ngày kết thúc (dd/MM/yyyy) |
| cboMa_nt | AsComboBox | Chọn mã ngoại tệ |
| chkSelectAll | AsCheckBox | Chọn/bỏ chọn tất cả |

### DataGridView Columns (dgvDGTG)
| Cột | Ý nghĩa |
|-----|---------|
| colChon | Chọn để thực hiện |
| colLoai_DG | Loại đánh giá |
| colTenBT | Tên bút toán |
| colSo_ct | Số chứng từ |
| colTK_dgtg | TK đánh giá tỷ giá |
| dgvcMa_nt | Mã ngoại tệ |
| colTKLaiCLTG | TK Lãi CLTG cuối kỳ |
| colTKLoCLTG | TK Lỗ CLTG cuối kỳ |
| colTKCLTGCN | TK CLTG cuối năm |
| colDGKH | Đánh giá theo khách hàng |
| colDGBP | Đánh giá theo bộ phận |
| colDGHD | Đánh giá theo hợp đồng |
| colDGSPCT | Đánh giá theo SPCT |
| colDGPhi | Đánh giá theo phí |
| colKSD | Không sử dụng (ẩn) |

### Buttons
| Button | Text | Chức năng |
|--------|------|-------------|
| cmdDG | Đánh giá | Thực hiện đánh giá tỷ giá |
| cmdDeleteDG | Xóa ĐG | Xóa đánh giá tỷ giá |
| cmdCancel | Quay ra | Đóng form |

---

## Business Logic

### IGLPost2DGTGDAO Interface

| Method | Parameters | Return | Mô tả |
|--------|-----------|--------|---------|
| GetData | - | DataTable | Lấy danh mục đánh giá tỷ giá |
| DelDgtg | pMa_Cty, pMa_ct, pNgay1, pNgay2, pStt | int | Xóa đánh giá tỷ giá |
| CreateDgtg | pMa_cty, pMa_ct, pMa_nt, pStt, pNgay1, pNgay2, pUser | int | Tạo đánh giá tỷ giá |

### Stored Procedures

| Tên | Mục đích |
|-----|----------|
| asGLGetDMDGTG | Lấy danh mục đánh giá tỷ giá |
| asGLDelDGTG | Xóa đánh giá tỷ giá |
| asGLCrtDGTG | Tạo đánh giá tỷ giá mới |

---

## Mục đích sử dụng

**GLPost2DGTG.dll là module "Đánh giá tỷ giá cuối kỳ"** trong hệ thống ERP của ASIASOFT.

### Chức năng chính

#### 1. Quản lý đánh giá tỷ giá
- Xem danh sách các bút toán đánh giá tỷ giá
- Chọn kỳ báo cáo (tự động cập nhật ngày bắt đầu/kết thúc)
- Chọn loại ngoại tệ cần đánh giá
- Chọn nhiều bút toán để thực hiện đồng loạt

#### 2. Tính toán chênh lệch tỷ giá (CLTG)
- Tính lãi/lỗ tỷ giá cuối kỳ
- Tính CLTG cuối năm
- Hỗ trợ đánh giá theo nhiều chiều: khách hàng, bộ phận, hợp đồng, SPCT, phí

#### 3. Tài khoản kế toán liên quan
- TK lãi CLTG cuối kỳ
- TK lỗ CLTG cuối kỳ
- TK CLTG cuối năm

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với DataTable
- Kiểm tra khóa sổ (ngay_ks) trước khi thực hiện
- Lưu trữ kỳ báo cáo vào PublicVariables
- Hỗ trợ chọn/bỏ chọn tất cả các dòng

### Thuật ngữ kế toán

| Thuật ngữ | Ý nghĩa |
|-----------|---------|
| DGTG | Đánh giá tỷ giá |
| CLTG | Chênh lệch tỷ giá |
| ma_nt | Mã ngoại tệ |
| ty_gia | Tỷ giá |
| TK | Tài khoản |

---

## Kết luận

Đây là module Windows Forms của hệ thống ERP AsiaERP, phục vụ cho việc đánh giá tỷ giá cuối kỳ - một chức năng quan trọng trong kế toán doanh nghiệp có giao dịch ngoại tệ.

---

*Ngày phân tích: 2026-03-29*
