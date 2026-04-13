# IN Module Summary - Tổng quan Module Kho

## Thông tin chung

| Thuộc tính | Giá trị |
|------------|---------|
| Module | IN (Inventory) |
| Tên tiếng Việt | Quản lý kho |
| Framework | .NET Framework 3.5 |
| Ngôn ngữ | C# |
| Company | Asia Software Development JSC |
| Product | Asia Enterprise / Simba Accounting |
| Version | 9.1.0.0 / 14.1.0.0 |

---

## Các nhóm chức năng

### 1. Danh mục (7 DLL)

| DLL | Danh mục | Mô tả |
|-----|----------|-------|
| INDMKHO.dll | Kho | Danh mục kho hàng |
| INDMLO.dll | Lô | Quản lý lô, hạn dùng |
| INDMNHVT.dll | Nhóm vật tư | Phân nhóm theo cây |
| INDMVT.dll | Vật tư | Thông tin vật tư cơ bản |
| INDMVT_.dll | Vật tư (BOM) | Vật tư với định mức BOM |
| INDMPLVT.dll | Phân loại VT | Phân loại vật tư |
| INDMNHVAT.dll | Nhóm VAT | Nhóm hàng cho thuế GTGT |

#### Chi tiết INDMVT_ - Danh mục vật tư (BOM)

**Forms:**
- **frmINDMVT**: Form xem danh sách (kế thừa frmDMView)
- **frmINDMVTEdit**: Form thêm/sửa (kế thừa frmDMEdit)

**Key Features:**
- Quản lý thông tin vật tư: mã, tên, đvt, nhóm
- Theo dõi tồn kho: tồn tối thiểu, tồn tối đa
- Tài khoản kế toán: TK vật tư, TK doanh thu, TK giá vốn, TK chiết khấu, TK trả lại
- Thuế suất: GTGT, NK, XK, TTĐB
- Đơn vị tính: mua, bán với hệ số quy đổi
- BOM (Bill of Materials): Định nghĩa thành phần lắp ráp

**Tables:**
- dmvt: Danh mục vật tư
- dm_bom: Định mức vật tư

---

### 2. Chứng từ nhập xuất (5 DLL)

| DLL | Chứng từ | Chức năng |
|-----|----------|-----------|
| INVchIN1.dll | IN1 | Phiếu nhập kho |
| INVchIN2.dll | IN2 | Phiếu xuất kho |
| INVchIN3.dll | IN3 | Phiếu chuyển kho |
| INVchIN5.dll | IN5 | Phiếu xuất CCDC |
| INVchIN6.dll | IN6 | Phiếu lắp ráp/tháo dỡ |

#### 2.1 INVchIN2 - Phiếu xuất kho (Xuất bán)

- **Chức năng**: Xuất kho bán hàng cho khách hàng
- **Kế thừa**: frmVoucher
- **Mã chứng từ**: IN2

**Header Fields:**

| Field | Type | Lookup | Description |
|-------|------|--------|-------------|
| so_ct | string | - | Số phiếu xuất |
| ngay_ct | date | - | Ngày phiếu xuất |
| ngay_lct | date | - | Ngày lập CT |
| ma_kh | string | MA_KH | Mã khách hàng |
| dia_chi | string | - | Địa chỉ |
| nguoi_gd | string | - | Người giao dịch |
| dien_giai | string | - | Diễn giải |
| ma_nt | string | DM_NT | Mã ngoại tệ |
| ty_gia | decimal | - | Tỷ giá |
| ma_gd | string | DM_MA_GD | Mã giao dịch |

**Detail Fields:**

| Field | Type | Lookup | Calculation |
|-------|------|--------|-------------|
| ma_vt | string | MA_VT | Mã vật tư |
| ten_vt | string | - | Tên vật tư |
| dvt | string | - | Đơn vị tính |
| ma_kho | string | MA_KHO | Mã kho |
| ton | decimal | - | Tồn kho (read-only) |
| so_luong | decimal | - | Số lượng xuất |
| gia_nt | decimal | - | Giá NT |
| tien_nt | decimal | - | so_luong * gia_nt |
| gia | decimal | - | Giá VND |
| tien | decimal | - | so_luong * gia |
| tk_no | string | TK | TK nợ |
| tk_vt | string | TK | TK có (TK vật tư) |
| ma_spct | string | MA_SPCT | Mã SPCT |
| ma_hd | string | MA_HD | Mã hợp đồng |
| ma_phi | string | MA_PHI | Mã phí |
| ma_bp | string | MA_BP | Mã bộ phận |
| ma_lo | string | MA_LO | Mã lô |

**Stored Procedures:**
- sp_GetInVchIN2
- sp_InsertInVchIN2
- sp_UpdateInVchIN2
- sp_DeleteInVchIN2

---

#### 2.2 INVchIN3 - Phiếu chuyển kho

- **Chức năng**: Chuyển kho nội bộ (từ kho A sang kho B)
- **Kế thừa**: frmVoucher
- **Mã chứng từ**: IN3

**Header Fields:**
Tương tự INVchIN2 + so_pn (số phiếu nhập tự sinh)

**Detail Fields:**

| Field | Type | Lookup | Description |
|-------|------|--------|-------------|
| ma_vt | string | MA_VT | Mã vật tư |
| ten_vt | string | - | Tên vật tư |
| dvt | string | - | ĐVT |
| ma_khox | string | MA_KHO | Kho xuất |
| ma_khon | string | MA_KHO | Kho nhập |
| so_luong | decimal | - | Số lượng |
| gia_nt | decimal | - | Giá NT |
| tien_nt | decimal | - | Tiền NT |
| tk_no | string | TK | TK nợ |
| tk_vt | string | TK | TK có |
| gia | decimal | - | Giá VND |
| tien | decimal | - | Tiền VND |
| ma_spct | string | MA_SPCT | Mã SPCT |
| ma_hd | string | MA_HD | Mã hợp đồng |
| ma_phi | string | MA_PHI | Mã phí |
| ma_bp | string | MA_BP | Mã bộ phận |
| ma_lo | string | MA_LO | Mã lô |

**Business Logic:**
- Khi chuyển kho: Tạo 2 bút toán
  - Phiếu xuất: Xuất từ kho nguồn
  - Phiếu nhập: Nhập vào kho đích (tự động sinh số phiếu nhập)
- Giá chuyển kho: Theo giá tồn kho hiện tại

**Stored Procedures:**
- sp_GetInVchIN3
- sp_InsertInVchIN3
- sp_UpdateInVchIN3
- sp_DeleteInVchIN3

---

#### 2.3 INVchIN5 - Phiếu nhập kho (Nhập mua)

- **Chức năng**: Nhập kho từ nhà cung cấp
- **Kế thừa**: frmVoucher
- **Mã chứng từ**: IN5

**Header Fields:** Tương tự INVchIN2

**Detail Fields:** Tương tự INVchIN2 + ma_po (đơn đặt hàng)

**Business Logic:**
- Có thể nhập từ PO
- Tính giá theo phương pháp đã chọn
- Cập nhật tồn kho và giá vốn

**Stored Procedures:**
- sp_GetInVchIN5
- sp_InsertInVchIN5
- sp_UpdateInVchIN5
- sp_DeleteInVchIN5

---

#### 2.4 INVchIN6 - Phiếu nhập kho khác

- **Chức năng**: Nhập kho không phải từ mua hàng (nhập điều chỉnh, nhập sản xuất...)
- **Kế thừa**: frmVoucher
- **Mã chứng từ**: IN6

**Header Fields:** Tương tự INVchIN2

**Detail Fields:** Tương tự INVchIN5

**Business Logic:**
- Nhập điều chỉnh tồn kho
- Nhập từ sản xuất
- Nhập trả lại từ khách hàng
- Nhập khuyến mãi, quà tặng

---

### 3. Báo cáo (12 DLL)

| DLL | Báo cáo | Loại | Mô tả |
|-----|---------|------|-------|
| INRptBK01.dll | Bảng kê chứng từ | Bảng kê | Tổng hợp nhập xuất tồn theo tháng |
| INRptBKN04.dll | Bảng kê phiếu nhập | Bảng kê | Chi tiết phiếu nhập kho |
| INRptBKX04.dll | Bảng kê phiếu xuất | Bảng kê | Chi tiết phiếu xuất kho |
| INRptCD01.dll | Công nợ 01 | Công nợ/Tồn kho | Chi tiết nhập xuất tồn VT |
| INRptCD02.dll | Tồn kho 02 | Công nợ/Tồn kho | Chi tiết VT - mẫu 2 |
| INRptCTVT01.dll | Chi tiết vật tư 01 | Chi tiết | Chi tiết VT theo chứng từ |
| INRptCTVT02.dll | Thẻ kho | Chi tiết | Chi tiết VT theo CT - mẫu 2 |
| INRptF5CD01.dll | Công nợ F5 | Drill-down | Drill down từ CD01 |
| INRptTHN01.dll | Tổng hợp nhập 01 | Tổng hợp | Tổng hợp nhập kho |
| INRptTHN02.dll | Tổng hợp nhập 02 | Tổng hợp | Tổng hợp nhập - mẫu 2 |
| INRptTHX01.dll | Tổng hợp xuất 01 | Tổng hợp | Tổng hợp xuất kho |
| INRptTHX02.dll | Tổng hợp xuất 02 | Tổng hợp | Tổng hợp xuất - mẫu 2 |

#### 3.1 INRptBK01 - Bảng kê nhập xuất tồn

- **Chức năng**: Báo cáo tổng hợp nhập xuất tồn theo tháng/năm
- **SP**: sp_INRptBK01

**Parameters:**

| Param | Type | Description |
|-------|------|-------------|
| month | int | Tháng báo cáo (1-12) |
| year | int | Năm báo cáo |
| ma_vt | string | Mã vật tư (optional) |
| ma_kho | string | Mã kho (optional) |

**Report Structure:**
- Tồn đầu kỳ
- Nhập trong kỳ
- Xuất trong kỳ
- Tồn cuối kỳ

---

#### 3.2 INRptBKN04 - Bảng kê nhập kho chi tiết

- **Chức năng**: Báo cáo chi tiết phiếu nhập kho
- **SP**: sp_INRptBKN04

**Parameters:**

| Param | Type | Description |
|-------|------|-------------|
| ngay1 | date | Từ ngày |
| ngay2 | date | Đến ngày |
| loai_pn | string | Loại phiếu nhập |
| loai_gd | string | Loại giao dịch |
| so_ct1 | string | Từ số CT |
| so_ct2 | string | Đến số CT |
| ma_kh | string | Mã khách/NCC |
| ma_vt | string | Mã vật tư |
| ma_nhvt | string | Nhóm vật tư |
| ma_kho | string | Mã kho |
| ma_vitri | string | Mã vị trí |
| ma_bp | string | Mã bộ phận |
| ma_hd | string | Mã hợp đồng |
| ma_tkvt | string | TK vật tư |
| tk_du | string | TK đối ứng |
| ma_lo | string | Mã lô |
| ma_phi | string | Mã phí |
| ma_spct | string | Mã SPCT |
| theo_nhom | string | Nhóm theo |
| theo_dvt | string | ĐVT theo |

**Group Options (theo_nhom):**
- "": Không nhóm
- "Ma_KH": Nhà cung cấp
- "MA_BP": Bộ phận
- "Ma_HD": Hợp đồng
- "Ma_SPCT": SPCT
- "MA_NX": Dạng nhập xuất
- "MA_VT": Vật tư
- "STT_REC": Chứng từ

---

#### 3.3 INRptBKX04 - Bảng kê xuất kho chi tiết

- **Chức năng**: Báo cáo chi tiết phiếu xuất kho
- **SP**: sp_INRptBKX04
- **Parameters**: Tương tự INRptBKN04 nhưng cho phiếu xuất

---

#### 3.4 INRptCD01 - Báo cáo chi tiết vật tư

- **Chức năng**: Báo cáo chi tiết nhập xuất tồn theo vật tư
- **SP**: sp_INRptCD01

**Parameters:**

| Param | Type | Description |
|-------|------|-------------|
| ngay1 | date | Từ ngày |
| ngay2 | date | Đến ngày |
| ma_kho | string | Mã kho |
| ma_vitri | string | Mã vị trí |
| ma_vt | string | Mã vật tư |
| ma_tkvt | string | TK vật tư |
| ma_nhvt | string | Nhóm vật tư |
| ma_plvt1 | string | Phân loại 1 |
| ma_plvt2 | string | Phân loại 2 |
| ma_plvt3 | string | Phân loại 3 |
| order1 | int | Thứ tự nhóm 1 |
| order2 | int | Thứ tự nhóm 2 |
| order3 | int | Thứ tự nhóm 3 |
| dvt | string | ĐVT (0:Kho, 1:Mua, 2:Bán) |
| ps_dc | string | Tính PS điều chuyển |

---

#### 3.5 INRptCD02 - Báo cáo chi tiết vật tư (mẫu 2)

- **Chức năng**: Báo cáo chi tiết nhập xuất tồn theo vật tư - mẫu 2
- **SP**: sp_INRptCD02

---

#### 3.6 INRptCTVT01 - Báo cáo chi tiết vật tư theo chứng từ

- **Chức năng**: Liệt kê chi tiết từng chứng từ nhập/xuất
- **SP**: sp_INRptCTVT01

---

#### 3.7 INRptCTVT02 - Báo cáo chi tiết vật tư theo chứng từ (mẫu 2)

- **Chức năng**: Liệt kê chi tiết chứng từ - mẫu 2
- **SP**: sp_INRptCTVT02

---

#### 3.8 INRptF5CD01 - Báo cáo chi tiết vật tư (F5 - Drill down)

- **Chức năng**: Drill down từ INRptCD01 để xem chi tiết
- **SP**: sp_INRptF5CD01

**Parameters:**

| Param | Type | Description |
|-------|------|-------------|
| ma_cty | string | Mã công ty |
| ma_vt | string | Mã vật tư |
| ma_kho | string | Mã kho |
| ma_vitri | string | Mã vị trí |
| ma_lo | string | Mã lô |
| ngay1 | date | Từ ngày |
| ngay2 | date | Đến ngày |
| ps_dc | string | Tính PS điều chuyển |

---

#### 3.9 INRptTHN01 - Tổng hợp nhập kho

- **Chức năng**: Báo cáo tổng hợp nhập kho theo các tiêu chí
- **SP**: sp_INRptTHN01

---

#### 3.10 INRptTHN02 - Tổng hợp nhập kho (mẫu 2)

- **Chức năng**: Báo cáo tổng hợp nhập kho - mẫu 2
- **SP**: sp_INRptTHN02

---

#### 3.11 INRptTHX01 - Tổng hợp xuất kho

- **Chức năng**: Báo cáo tổng hợp xuất kho theo các tiêu chí
- **SP**: sp_INRptTHX01

---

#### 3.12 INRptTHX02 - Tổng hợp xuất kho (mẫu 2)

- **Chức năng**: Báo cáo tổng hợp xuất kho - mẫu 2
- **SP**: sp_INRptTHX02

---

### 4. Tiện ích/Tính giá (6 DLL)

| DLL | Chức năng | Mô tả |
|-----|-----------|-------|
| INCDVT.dll | Nhập tồn đầu kỳ | Nhập số dư đầu năm |
| INCDFIFO.dll | Công nợ định mức FIFO | Theo dõi công nợ FIFO |
| INCalGiaBQDD.dll | Giá BQ di động | Tính giá sau mỗi nhập |
| INCalGiaNTXT.dll | Giá FIFO | Tính giá nhập trước xuất trước |
| INCalGiaTB.dll | Giá trung bình tháng | Tính giá cuối tháng |
| INTransferINCDVT.dll | Chuyển năm sau | Chuyển tồn kho sang năm mới |

---

## Pattern chung

### Common Lookup Codes

| Code | Description |
|------|-------------|
| MA_VT | Danh mục vật tư |
| MA_KHO | Danh mục kho |
| MA_NHVT | Danh mục nhóm vật tư |
| MA_VITRI | Danh mục vị trí kho |
| MA_BP | Danh mục bộ phận |
| MA_HD | Danh mục hợp đồng |
| MA_PHI | Danh mục phí |
| MA_SPCT | Danh mục sản phẩm công trình |
| MA_LO | Danh mục lô |
| MA_KH | Khách hàng |
| MA_NCC | Nhà cung cấp |
| TK | Danh mục tài khoản |

### Common Tables

| Table | Mô tả |
|-------|-------|
| inph | Header phiếu nhập/xuất kho |
| inct | Chi tiết phiếu nhập/xuất kho |
| inthvt | Tổng hợp vật tư |
| inctvt | Chi tiết vật tư theo chứng từ |
| dmvt | Danh mục vật tư |
| dmkho | Danh mục kho |
| dm_nhvt | Danh mục nhóm vật tư |
| dm_vitri | Danh mục vị trí kho |

### Calculation Logic

```
tien_nt = so_luong * gia_nt
tien = tien_nt * ty_gia
// Hoặc
tien = so_luong * gia
```

---

## Cấu trúc Module IN

```
IN Module
├── Danh mục
│   └── INDMVT_ - Danh mục vật tư
│
├── Báo cáo
│   ├── Bảng kê
│   │   ├── INRptBK01 - Bảng kê NX tồn (theo tháng)
│   │   ├── INRptBKN04 - Bảng kê nhập kho chi tiết
│   │   └── INRptBKX04 - Bảng kê xuất kho chi tiết
│   │
│   ├── Chi tiết vật tư
│   │   ├── INRptCD01 - Chi tiết vật tư
│   │   ├── INRptCD02 - Chi tiết vật tư (mẫu 2)
│   │   └── INRptF5CD01 - Drill down từ CD01
│   │
│   ├── Chi tiết theo chứng từ
│   │   ├── INRptCTVT01 - Chi tiết theo chứng từ
│   │   └── INRptCTVT02 - Chi tiết theo CT (mẫu 2)
│   │
│   └── Tổng hợp
│       ├── INRptTHN01 - Tổng hợp nhập kho
│       ├── INRptTHN02 - Tổng hợp nhập (mẫu 2)
│       ├── INRptTHX01 - Tổng hợp xuất kho
│       └── INRptTHX02 - Tổng hợp xuất (mẫu 2)
│
└── Voucher
    ├── INVchIN2 - Phiếu xuất kho (Xuất bán)
    ├── INVchIN3 - Phiếu chuyển kho
    ├── INVchIN5 - Phiếu nhập kho (Nhập mua)
    └── INVchIN6 - Phiếu nhập kho khác
```

---

## Tổng kết

| Loại | Số lượng |
|------|----------|
| Chứng từ | 5 |
| Danh mục | 7 |
| Báo cáo | 12 |
| Tiện ích | 6 |
| **Tổng cộng** | **30 DLL** |

---

## Ngày cập nhật

*2026-03-30*
