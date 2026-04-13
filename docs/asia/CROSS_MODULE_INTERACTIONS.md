# Cross-Module Interactions - ASIA ERP

Tài liệu này mô tả luồng dữ liệu và tương tác giữa các module trong ASIA ERP.

## Luồng Nghiệp Vụ Chính

### 1. Bán Hàng: SO → SI → AR → GL

```
┌─────────┐    ┌─────────┐    ┌─────────┐    ┌─────────┐
│   SO    │ →  │   SI    │ →  │   AR    │ →  │   GL    │
│(Đơn hàng)│    │(Hóa đơn)│    │(Công nợ)│    │(Sổ cái) │
└─────────┘    └─────────┘    └─────────┘    └─────────┘
```

**Chi tiết:**
1. **SO (Sales Order)** - Tạo đơn hàng bán
   - Form: frmSoVchSO1
   - SP: asSOInsOrder, asSOInsCt1
   - Tables: SoPh1, SoCt1

2. **SI (Sales Invoice)** - Xuất hóa đơn
   - Form: frmSIVchSI1
   - SP: asSIInsInvoice
   - Tables: SiPh1, SiCt1

3. **AR (Accounts Receivable)** - Ghi công nợ
   - Form: frmArVchAR4
   - SP: asARInsPH1, asARInsCt1
   - Tables: ArPh1, ArCt1

4. **GL (General Ledger)** - Post lên sổ cái
   - Form: frmGLPost2GL
   - SP: asPost2GL
   - Tables: GlPh1, GlCt1

**SP Posting chính:**
- `asPost2GL` - Post chứng từ lên sổ cái
- `asPostGlPh1_glct` - Post phiếu GL sang GlCt

---

### 2. Mua Hàng: PO → IN → AP → GL

```
┌─────────┐    ┌─────────┐    ┌─────────┐    ┌─────────┐
│   PO    │ →  │   IN    │ →  │   AP    │ →  │   GL    │
│(Đơn mua)│    │(Nhập kho)│   │(Công nợ)│    │(Sổ cái) │
└─────────┘    └─────────┘    └─────────┘    └─────────┘
```

**Chi tiết:**
1. **PO (Purchase Order)** - Tạo đơn hàng mua
   - Forms: frmPOVchPO3, frmPOVchPO4, frmPOVchPO5, frmPOVchPO6, frmPOVchPO7
   - SP: asPOInsOrder, asPOInsCt1
   - Tables: PoPh1, PoCt1

2. **IN (Inventory)** - Nhập kho
   - Forms: frmINVchIN2, frmINVchIN3, frmINVchIN5, frmINVchIN6
   - SP: asINInsPH1, asINInsCt1
   - Tables: InPh1, InCt1

3. **AP (Accounts Payable)** - Ghi công nợ phải trả
   - Form: frmApVchAP4
   - SP: asAPInsPH1, asAPInsCt1
   - Tables: ApPh1, ApCt1

4. **GL (General Ledger)** - Post lên sổ cái
   - SP: asPost2GL

---

### 3. Thu Chi: CA → GL

```
┌─────────┐    ┌─────────┐
│   CA    │ →  │   GL    │
│(Thu/Chi)│    │(Sổ cái) │
└─────────┘    └─────────┘
```

**Chi tiết:**
1. **CA (Cash)** - Thu chi tiền mặt/ngân hàng
   - Forms: frmCaVchCA1, frmCaVchCA2, frmCaVchCA3, frmCaVchCA4, frmCaVchCA5
   - SP: asCAInsPH1, asCAInsCt1
   - Tables: CaPh1, CaCt1

2. **GL** - Post lên sổ cái
   - SP: asPost2GL

---

### 4. Tài Sản Cố Định: FA → GL

```
┌─────────┐    ┌─────────┐
│   FA    │ →  │   GL    │
│(TSCD)   │    │(Sổ cái) │
└─────────┘    └─────────┘
```

**Chi tiết:**
1. **FA (Fixed Asset)** - Quản lý TSCD
   - Forms: frmFACalKHTS (Tính khấu hao), các form báo cáo FARpt*
   - SP: asFAInsTSCD, asFACalKHTS
   - Tables: FaTscd, FaKhts

2. **GL** - Post khấu hao
   - Form: frmFAPostCC2GL
   - SP: asPost2GL

---

### 5. Tính Giá Thành: CO → GL

```
┌─────────┐    ┌─────────┐
│   CO    │ →  │   GL    │
│(Giá thành)│   │(Sổ cái) │
└─────────┘    └─────────┘
```

**Chi tiết:**
1. **CO (Cost)** - Tính giá thành
   - Forms: frmCoCalcCost, các form báo cáo CORpt*
   - SP: asCOCalcCost
   - Tables: CoBom, CoDd

2. **GL** - Post giá thành
   - SP: asPost2GL

---

## Danh Sách SP Posting Chính

| SP | Mô tả | Module gọi |
|----|-------|------------|
| asPost2GL | Post chứng từ lên sổ cái | Tất cả |
| asPostGlPh1_glct | Post phiếu GL sang GlCt | GL |
| asARPost2TT | Post thanh toán AR | AR |
| asAPPost2TT | Post thanh toán AP | AP |
| asFACalKHTS | Tính khấu hao TSCD | FA |
| asCOCalcCost | Tính giá thành | CO |
| asCALaiKu | Tính lãi khế ước | CA |

## Module Hub: GL (General Ledger)

GL là module trung tâm nhận dữ liệu từ tất cả các module khác:

```
        ┌─────────────────────────────────────────┐
        │                  GL                     │
        │              (Sổ Cái)                   │
        └─────────────────────────────────────────┘
           ↑      ↑      ↑      ↑      ↑      ↑
          SO     SI     AR     AP     CA     FA     CO     PO     IN
```

## Ghi chú

- Mọi chứng từ đều phải qua GL để tạo báo cáo tài chính
- Posting có thể thực hiện theo lô (batch) hoặc từng chứng từ
- Có thể unpost (hủy post) để sửa chứng từ
