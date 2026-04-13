# Báo cáo Phân tích DLL: SOTaOut.dll

## Tổng quan

| Thuộc tính | Giá trị |
|------------|---------|
| Loại file | .NET Assembly (Windows Forms) |
| Ngôn ngữ | C# |
| Framework | .NET Framework |
| Output type | Class Library (DLL) |

---

## Metadata

| Thuộc tính | Giá trị |
|------------|---------|
| Assembly Name | SOTaOut |
| Assembly Title | Vào các hóa đơn đầu ra |
| Assembly Company | Asia Software Development JSC |
| Assembly Product | Asia Enterprise |
| Assembly Copyright | Copyright © AsiaSoft 2010 |
| Assembly Trademark | AsiaSoft |
| Assembly Version | 9.1.0.0 |
| Assembly File Version | 1.0.0.0 |
| GUID | 2b77c71e-b8d4-4512-9c4a-843e2824a429 |
| ComVisible | true |

---

## Cấu trúc File

```
SOTaOut.dll/
├── SOTaOut.csproj               # Project file
├── app.ico                      # Application icon
├── Properties/
│   └── AssemblyInfo.cs          # Assembly metadata
├── AsiaErp.UserInterface/
│   ├── frmSOTaOut.cs            # Form danh sách
│   └── frmSOTAOutEdit.cs        # Form nhập liệu chi tiết
└── Properties/
    └── AssemblyInfo.cs          # Assembly metadata
```

---

## Dependencies

### External References

| Assembly | Mục đích |
|----------|----------|
| Microsoft.VisualBasic | Visual Basic runtime support |
| System.Data | Data access |
| Framework | Asia ERP Framework |

### Namespaces sử dụng

- `AsiaErp.Framework`
- `System`, `System.Data`, `System.Drawing`, `System.Windows.Forms`
- `Microsoft.VisualBasic`, `Microsoft.VisualBasic.CompilerServices`

---

## Classes và Components

| Class | Kế thừa | Mục đích |
|-------|---------|----------|
| `frmSOTaOut` | `frmDMView` | Form danh sách thuế đầu ra |
| `frmSOTAOutEdit` | `frmDMEdit` | Form nhập liệu hóa đơn đầu ra |

---

## Các trường dữ liệu chính

### Thông tin chứng từ

| Trường | Ý nghĩa |
|--------|---------|
| `so_ct` | Số chứng từ |
| `ngay_ct` | Ngày chứng từ |
| `ngay_lap` | Ngày lập chứng từ |
| `so_seri` | Số sê-ri |
| `so_seri_mhd` | Ký hiệu mẫu hóa đơn |

### Thông tin khách hàng

| Trường | Ý nghĩa |
|--------|---------|
| `ma_kh` | Mã khách hàng |
| `ten_kh` | Tên khách hàng |
| `ma_so_thue` | Mã số thuế |
| `dia_chi` | Địa chỉ |

### Thông tin hàng hóa

| Trường | Ý nghĩa |
|--------|---------|
| `ma_vt` | Mã vật tư |
| `ten_vt` | Tên vật tư |
| `so_luong` | Số lượng |
| `gia` | Đơn giá |
| `ma_thue` | Mã thuế |
| `thue_suat` | Thuế suất (%) |

### Thông tin tiền tệ

| Trường | Ý nghĩa |
|--------|---------|
| `ma_nt` | Mã ngoại tệ |
| `ty_gia` | Tỷ giá |
| `t_tien_nt` | Tổng tiền ngoại tệ |
| `t_tien` | Tổng tiền VNĐ |
| `t_thue_nt` | Tổng thuế ngoại tệ |
| `t_thue` | Tổng thuế VNĐ |

### Thông tin kế toán

| Trường | Ý nghĩa |
|--------|---------|
| `tk_thue` | Tài khoản thuế |
| `tk_du` | Tài khoản đối ứng |
| `ma_bp` | Mã bộ phận |
| `ma_hd` | Mã hóa đơn |
| `ma_spct` | Mã sản phẩm chi tiết |
| `ghi_chu` | Ghi chú |

---

## Mục đích sử dụng

**SOTaOut.dll là module quản lý thuế đầu ra (hóa đơn bán hàng)** trong hệ thống ERP Asia Enterprise.

### Chức năng chính

#### 1. Nhập liệu hóa đơn đầu ra
- Quản lý thông tin chứng từ bán hàng
- Thông tin khách hàng (mã KH, tên, MST, địa chỉ)
- Thông tin hàng hóa (vật tư, số lượng, đơn giá)

#### 2. Tính toán tự động
- Tính tổng tiền theo số lượng × đơn giá
- Tính thuế GTGT theo thuế suất
- Hỗ trợ đa tiền tệ với tỷ giá
- Tự động làm tròn theo cấu hình hệ thống

#### 3. Quản lý ngoại tệ
- ComboBox chọn mã ngoại tệ
- Tỷ giá tự động lấy theo ngày
- Tính toán song song VNĐ và ngoại tệ
- Ẩn/hiện control tùy theo loại tiền

#### 4. Kế toán thuế
- Tài khoản thuế (TK thuế)
- Tài khoản đối ứng
- Mã bộ phận, mã hóa đơn, mã sản phẩm chi tiết

### Đặc điểm kỹ thuật

- Sử dụng DataBinding với các control AsTextBox, AsMaskedTextBox, AsTextNumeric
- AsComboBoxNT cho chọn ngoại tệ
- Tự động tính toán khi thay đổi số lượng, đơn giá, thuế suất, tỷ giá
- Validation kiểm tra ngày chứng từ không vượt quá năm tài chính
- Cảnh báo điều chỉnh giá/trị vượt ngưỡng cho phép

### Validation

- Ngày chứng từ > ngày khóa sổ (ngay_ks)
- Năm của ngày chứng từ = năm tài chính hiện hành
- TK đối ứng và TK thuế không được để trống
- Số lượng >= 0
- Cảnh báo điều chỉnh khi chênh lệch giá/trị vượt ngưỡng cấu hình

---

## Các sự kiện tính toán chính

| Sự kiện | Mô tả |
|---------|-------|
| `txtSo_luong_ValueChanged` | Tính lại tổng tiền, thuế |
| `txtGia_ValueChanged` | Tính lại tổng tiền, thuế |
| `txtThue_suat_ValueChanged` | Tính lại tổng thuế |
| `txtTy_gia_ValueChanged` | Quy đổi ngoại tệ sang VNĐ |
| `txtTong_NT_ValueChanged` | Tính lại tổng VNĐ theo tỷ giá |
| `cboNgoai_te_SelectedIndexChanged` | Đổi ngoại tệ, cập nhật mask và tỷ giá |

---

## Các hàm tính toán

| Hàm | Mô tả |
|-----|-------|
| `Calc_Tien_nt()` | Tính tổng tiền ngoại tệ = số lượng × đơn giá |
| `Calc_Tien()` | Tính tổng tiền VNĐ = tổng NT × tỷ giá |
| `Cal_Thue_nt()` | Tính thuế ngoại tệ = tổng NT × thuế suất / 100 |
| `Cal_Thue()` | Tính thuế VNĐ = tổng VNĐ × thuế suất / 100 |
| `RefreshControls()` | Cập nhật hiển thị control theo loại tiền |
| `CanhBaoDieuChinh()` | Kiểm tra và cảnh báo điều chỉnh vượt ngưỡng |

---

## Kết luận

Đây là module Windows Forms quan trọng trong phân hệ Bán hàng của Asia Enterprise, phục vụ việc nhập liệu và quản lý hóa đơn đầu ra (thuế đầu ra). Module hỗ trợ đầy đủ tính năng tính toán tự động, đa tiền tệ, và tích hợp với kế toán thuế.

---

*Ngày phân tích: 2026-03-29*
