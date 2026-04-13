# SimbaSql - Chi Tiết Luồng Công Việc (Workflows)

Tài liệu này mô tả chi tiết các luồng công việc nghiệp vụ trong hệ thống SimbaSql.

---

## Mục Lục

1. [Luồng Bán Hàng](#luồng-bán-hàng)
2. [Luồng Mua Hàng](#luồng-mua-hàng)
3. [Luồng Thu Chi](#luồng-thu-chi)
4. [Luồng Kho](#luồng-kho)
5. [Luồng Công Nợ](#luồng-công-nợ)
6. [Luồng Tài Sản Cố Định](#luồng-tài-sản-cố-định)
7. [Luồng Tính Giá Thành](#luồng-tính-giá-thành)
8. [Luồng Post Sổ Cái](#luồng-post-sổ-cái)

---

## Luồng Bán Hàng

### Tổng Quan
```
SO (Đơn hàng) → SI (Hóa đơn) → AR (Công nợ) → GL (Sổ cái)
     ↓              ↓              ↓              ↓
   Đặt hàng    Xuất HĐ      Theo dõi thu    Bút toán KT
```

### Bước 1: Tạo Đơn Hàng Bán (SO)

#### Form
- **DLL**: SOVchSO1.dll
- **Form**: frmSoVchSO1
- **Chức năng**: Tạo đơn hàng bán

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asSOGetDMKH | Lấy danh mục khách hàng |
| asSOGetGiaban | Lấy giá bán sản phẩm |
| asSOGetDMKM | Lấy khuyến mãi |
| asSoInsPh1 | Insert header đơn hàng |
| asSoInsCt1 | Insert chi tiết đơn hàng |

#### Tables
| Table | Vai trò |
|-------|---------|
| SoPh1 | Header đơn hàng |
| SoCt1 | Chi tiết sản phẩm |
| SoDmGiaBan | Danh mục giá bán |
| SoDmKm | Danh mục khuyến mãi |

#### Luồng xử lý
```
1. User mở form frmSoVchSO1
        ↓
2. Nhập thông tin header:
   - Chọn khách hàng → asSOGetDMKH
   - Ngày đơn hàng
   - Điều kiện thanh toán
        ↓
3. Nhập chi tiết sản phẩm:
   - Chọn mã vật tư → asINGetDMVT
   - Số lượng
   - Kiểm tra giá → asSOGetGiaban
   - Kiểm tra KM → asSOGetDMKM
        ↓
4. Validate dữ liệu:
   - Kiểm tra tồn kho
   - Kiểm tra credit limit
        ↓
5. Save đơn hàng:
   - asSoInsPh1 (SoPh1)
   - asSoInsCt1 (SoCt1)
        ↓
6. Trạng thái: "Chờ duyệt"
```

### Bước 2: Duyệt Đơn Hàng

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asSOChkRightStatusSO1 | Kiểm tra quyền duyệt |
| asSOUpdPH1 | Update trạng thái đơn hàng |

#### Luồng xử lý
```
1. User mở đơn hàng cần duyệt
        ↓
2. Kiểm tra quyền → asSOChkRightStatusSO1
        ↓
3. Validate:
   - Kiểm tra tồn kho
   - Kiểm tra credit limit khách hàng
   - Kiểm tra giá
        ↓
4. Duyệt đơn hàng:
   - Update trạng thái = "Đã duyệt"
   - asSOUpdPH1
        ↓
5. Đơn hàng sẵn sàng cho xuất HĐ
```

### Bước 3: Xuất Hóa Đơn Bán Hàng (SI/AR1)

#### Form
- **DLL**: SIVchSI1.dll / ARVchAR4.dll
- **Form**: frmSiVchSI1 / frmArVchAR1
- **Chức năng**: Xuất hóa đơn GTGT

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asSOGetPh1 | Lấy đơn hàng gốc |
| asSOGetCT1 | Lấy chi tiết ĐH |
| asARInsPH1 | Insert hóa đơn header |
| asARInsCT1 | Insert chi tiết HĐ |
| asINInsCT2 | Insert xuất kho (tự động) |
| asINInsPH2 | Insert phiếu xuất kho |

#### Tables
| Table | Vai trò |
|-------|---------|
| ArPh1 | Header hóa đơn |
| ArCt1 | Chi tiết hóa đơn |
| InPh2 | Phiếu xuất kho |
| InCt2 | Chi tiết xuất kho |

#### Luồng xử lý
```
1. User chọn tạo HĐ từ đơn hàng
        ↓
2. Lookup đơn hàng → asSOGetPh1, asSOGetCT1
        ↓
3. Nhập thông tin HĐ:
   - Số hóa đơn GTGT
   - Ngày xuất HĐ
   - Thông tin khách hàng (từ SO)
        ↓
4. Chi tiết HĐ (copy từ SO):
   - Mã vật tư
   - Số lượng
   - Giá bán
   - Thuế GTGT
        ↓
5. Tự động tạo phiếu xuất kho:
   - asINInsPH2 (InPh2)
   - asINInsCT2 (InCt2)
        ↓
6. Save HĐ:
   - asARInsPH1 (ArPh1)
   - asARInsCT1 (ArCt1)
        ↓
7. Trạng thái: "Chờ post"
```

### Bước 4: Post Hóa Đơn Sang GL

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asARPostPh1_glct | Post HĐ sang GlCt |
| asARPostPh1_artt | Post HĐ sang ArTt |
| asPost2GL | Post tổng hợp |

#### Bút toán tự động
```
Nợ TK 131 (Phải thu KH)          Có TK 511 (Doanh thu)
Nợ TK 131 (Phải thu KH)          Có TK 3331 (Thuế GTGT đầu ra)
Nợ TK 632 (Giá vốn hàng bán)     Có TK 156 (Hàng hóa)
```

#### Luồng xử lý
```
1. User chọn Post HĐ
        ↓
2. Kiểm tra điều kiện post
        ↓
3. Post sang ArTt:
   - asARPostPh1_artt
   - Cập nhật công nợ khách hàng
        ↓
4. Post sang GlCt:
   - asARPostPh1_glct
   - Tạo bút toán kế toán
        ↓
5. Update trạng thái:
   - ArPh1.Post2GL = 1
   - InPh2.Post2GL = 1
```

---

## Luồng Mua Hàng

### Tổng Quan
```
PO (Đơn hàng mua) → IN (Nhập kho) → AP (Công nợ) → GL (Sổ cái)
        ↓               ↓               ↓              ↓
     Đặt hàng      Nhận hàng      Theo dõi trả    Bút toán KT
```

### Bước 1: Tạo Đơn Hàng Mua (PO0)

#### Form
- **DLL**: POVchPO1.dll
- **Form**: frmPoVchPO0
- **Chức năng**: Tạo đơn hàng mua

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asPOGetDmGiaMua | Lấy giá mua |
| asPOInsPH0 | Insert đơn hàng mua |
| asPOInsCT0 | Insert chi tiết ĐH mua |

#### Tables
| Table | Vai trò |
|-------|---------|
| PoPh0 | Header đơn hàng mua |
| PoCt0 | Chi tiết ĐH mua |
| PoDmGiaMua | Danh mục giá mua |

#### Luồng xử lý
```
1. User mở form frmPoVchPO0
        ↓
2. Nhập thông tin header:
   - Chọn nhà cung cấp
   - Ngày đơn hàng
   - Điều kiện thanh toán
        ↓
3. Nhập chi tiết sản phẩm:
   - Chọn mã vật tư
   - Số lượng đặt
   - Kiểm tra giá → asPOGetDmGiaMua
        ↓
4. Save đơn hàng:
   - asPOInsPH0 (PoPh0)
   - asPOInsCT0 (PoCt0)
        ↓
5. Trạng thái: "Chờ nhận hàng"
```

### Bước 2: Nhận Hàng (PO1)

#### Form
- **DLL**: POVchPO1.dll
- **Form**: frmPoVchPO1
- **Chức năng**: Nhận hàng từ NCC

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asPOLookupDhPn | Lookup đơn hàng |
| asPOGetPH0 | Lấy đơn hàng gốc |
| asPOGetCT0 | Lấy chi tiết ĐH |
| asPOInsPH1 | Insert nhận hàng |
| asPOInsCT1 | Insert chi tiết nhận hàng |

#### Tables
| Table | Vai trò |
|-------|---------|
| PoPh1 | Phiếu nhận hàng |
| PoCt1 | Chi tiết nhận hàng |

#### Luồng xử lý
```
1. User mở form nhận hàng
        ↓
2. Lookup đơn hàng → asPOLookupDhPn
        ↓
3. Chọn đơn hàng gốc → asPOGetPH0, asPOGetCT0
        ↓
4. Nhập thông tin nhận:
   - Ngày nhận
   - Số lượng thực nhận (có thể khác ĐH)
   - Chất lượng
        ↓
5. Save nhận hàng:
   - asPOInsPH1 (PoPh1)
   - asPOInsCT1 (PoCt1)
        ↓
6. Update đơn hàng:
   - Cập nhật số lượng đã nhận trên PoCt0
        ↓
7. Trạng thái: "Đã nhận hàng"
```

### Bước 3: Nhập Hóa Đơn Mua (PO2/AP)

#### Form
- **DLL**: POVchPO1.dll / APPost2TT.dll
- **Form**: frmPoVchPO2
- **Chức năng**: Nhập HĐ mua từ NCC

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asPOLookupDn4Dh | Lookup nhận hàng |
| asPOGetPH1 | Lấy phiếu nhận hàng |
| asPOInsPH2 | Insert HĐ mua |
| asPOInsCT2 | Insert chi tiết HĐ mua |
| asAPInsPH1 | Insert vào AP (tự động) |

#### Tables
| Table | Vai trò |
|-------|---------|
| PoPh2 | Hóa đơn mua |
| PoCt2 | Chi tiết HĐ mua |
| ApPh1 | Công nợ phải trả |
| ApCt1 | Chi tiết công nợ |

#### Luồng xử lý
```
1. User mở form nhập HĐ
        ↓
2. Lookup nhận hàng → asPOLookupDn4Dh
        ↓
3. Chọn phiếu nhận → asPOGetPH1
        ↓
4. Nhập thông tin HĐ:
   - Số hóa đơn GTGT
   - Ngày HĐ
   - Giá, thuế GTGT
        ↓
5. Save HĐ mua:
   - asPOInsPH2 (PoPh2)
   - asPOInsCT2 (PoCt2)
        ↓
6. Tạo công nợ tự động:
   - asAPInsPH1 (ApPh1)
   - asAPInsCT1 (ApCt1)
        ↓
7. Trạng thái: "Chờ post"
```

### Bước 4: Post Sang GL

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asAPPostPh1_glct | Post HĐ mua sang GlCt |
| asAPPostPh1_aptt | Post sang ApTt |
| asPostPoPh2_GlCt | Post PO2 sang GL |

#### Bút toán tự động
```
Nợ TK 156 (Hàng hóa)             Có TK 331 (Phải trả NCC)
Nợ TK 133 (Thuế GTGT được khấu trừ)  Có TK 331 (Phải trả NCC)
```

---

## Luồng Kho

### Tổng Quan
```
Nhập kho (IN1) ← PO / Mua trực tiếp
      ↓
Tồn kho (InCdVt, InCdFifo)
      ↓
Xuất kho (IN2) → SO / Bán hàng / Xuất nội bộ
```

### Nhập Kho (IN1)

#### Form
- **DLL**: INVchIN1.dll
- **Form**: frmInVchIN1

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asINGetDMVT | Lấy vật tư |
| asINGetDMKHO | Lấy kho |
| asINInsPH1 | Insert nhập kho |
| asINInsCT1 | Insert chi tiết nhập |
| asPostInPh1_glct | Post sang GL |

#### Bút toán
```
Nợ TK 156 (Hàng hóa)             Có TK 331/111/112 (NCC/TM/NH)
```

### Xuất Kho (IN2)

#### Form
- **DLL**: INVchIN1.dll
- **Form**: frmInVchIN2

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asINGetTonVtAll | Kiểm tra tồn kho |
| asINInsPH2 | Insert xuất kho |
| asINInsCT2 | Insert chi tiết xuất |
| asINCalGiaTB_Post_INCT2GLCT | Tính giá xuất kho |

#### Tính giá xuất kho
```
1. Kiểm tra phương pháp tính giá:
   - FIFO: First In First Out
   - Weighted Average: Bình quân gia quyền
        ↓
2. Tính giá vốn xuất kho:
   - asINCalGiaTB_Post_INCT2GLCT
        ↓
3. Cập nhật tồn kho
```

---

## Luồng Thu Chi

### Thu Tiền (CA1)

#### Form
- **DLL**: CAVchCA1.dll
- **Form**: frmCaVchCA1

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asCAGetDMKU | Lấy quỹ |
| asARGetPH1 | Lấy HĐ cần thu |
| asCAInsPH1 | Insert phiếu thu |
| asCAInsCT1 | Insert chi tiết thu |
| asPostCaPh1_glct | Post sang GL |

#### Luồng xử lý
```
1. Tạo phiếu thu
        ↓
2. Chọn quỹ → asCAGetDMKU
        ↓
3. Chọn HĐ cần thu → asARGetPH1
        ↓
4. Nhập số tiền thu
        ↓
5. Save:
   - asCAInsPH1 (CaPh1)
   - asCAInsCT1 (CaCt1)
        ↓
6. Update công nợ:
   - Cập nhật ArTt
        ↓
7. Post sang GL:
   - asPostCaPh1_glct
```

#### Bút toán
```
Nợ TK 111/112 (Tiền mặt/NH)      Có TK 131 (Phải thu KH)
```

### Chi Tiền (CA2)

#### Form
- **DLL**: CAVchCA1.dll
- **Form**: frmCaVchCA2

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asCAGetDMKU | Lấy quỹ |
| asAPGetPH1 | Lấy HĐ cần chi |
| asCAInsPH2 | Insert phiếu chi |
| asCAInsCT2 | Insert chi tiết chi |
| asPostCaPh2_glct | Post sang GL |

#### Bút toán
```
Nợ TK 331 (Phải trả NCC)         Có TK 111/112 (Tiền mặt/NH)
```

---

## Luồng Công Nợ

### Công Nợ Phải Thu (AR)

#### Theo dõi công nợ
| SP | Chức năng |
|----|-----------|
| asARGetPH1 | Lấy hóa đơn |
| asARGetTT | Lấy thanh toán |
| asARRecalCustBalance | Tính lại số dư KH |

#### Bù trừ công nợ (AR4)
```
1. Tạo chứng từ bù trừ
        ↓
2. Chọn hóa đơn cần bù trừ
        ↓
3. Chọn phiếu thu/điều chỉnh
        ↓
4. Save → asARInsPH4, asARInsCT4
        ↓
5. Update số dư công nợ
```

### Công Nợ Phải Trả (AP)

#### Theo dõi công nợ
| SP | Chức năng |
|----|-----------|
| asAPGetPH1 | Lấy hóa đơn mua |
| asAPGetTT | Lấy thanh toán |
| asAPReCalAP14Relate | Tính lại AP1-AP4 |

---

## Luồng Tài Sản Cố Định

### Ghi Tăng TSCĐ (FA1)

#### Form
- **DLL**: FADGTS.dll
- **Form**: frmFADGTSEdit

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asFAInsDMTS | Insert TSCĐ |
| asFAGetDMTS | Lấy TSCĐ |
| asFAPost2GlCt | Post sang GL |

#### Bút toán ghi tăng
```
Nợ TK 211 (TSCĐ)                 Có TK 331/111/112 (NCC/TM/NH)
```

### Tính Khấu Hao

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asFACalKHTS | Tính khấu hao |
| asFAGetKHTS | Lấy khấu hao |
| asFAPost2GlCt | Post sang GL |

#### Luồng xử lý
```
1. Chọn kỳ tính khấu hao
        ↓
2. Tính khấu hao → asFACalKHTS
   - Phương pháp: Đường thẳng/Số dư giảm dần
        ↓
3. Tạo bút toán khấu hao
        ↓
4. Post sang GL → asFAPost2GlCt
```

#### Bút toán khấu hao
```
Nợ TK 642 (Chi phí QLDN)         Có TK 214 (Khấu hao TSCĐ)
```

### Ghi Giảm TSCĐ (FAGiamTS)

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asFAInsDTSD | Insert điều chỉnh |
| asFAUpdGiamTS | Update giảm TSCĐ |
| asFADelGiamTS | Xóa giảm TSCĐ |

---

## Luồng Tính Giá Thành

### Quản Lý BOM

#### Form
- **DLL**: CODMBOM.dll
- **Form**: frmCODMBOM

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asCOInsDMCoBomPH | Insert BOM header |
| asCOInsDMCoBomCT | Insert BOM chi tiết |
| asCOGetDMCoBomPH | Lấy BOM |
| asCOGetDMCoBomCT | Lấy chi tiết BOM |

### Tính Phân Bổ Chi Phí

#### SP được gọi
| SP | Chức năng |
|----|-----------|
| asCOCalcPb | Tính phân bổ |
| asCOCalcHsPb | Tính hệ số phân bổ |
| asCOUpdateCost | Update giá thành |
| asCOPostCp2GlCt | Post sang GL |

#### Luồng xử lý
```
1. Định nghĩa phân bổ chi phí
        ↓
2. Nhập chi phí phát sinh
        ↓
3. Tính hệ số phân bổ → asCOCalcHsPb
        ↓
4. Phân bổ chi phí → asCOCalcPb
        ↓
5. Tính giá thành SP → asCOUpdateCost
        ↓
6. Post sang GL → asCOPostCp2GlCt
```

---

## Luồng Post Sổ Cái

### Post Tổng Hợp

#### SP chính: asPost2GL
```sql
CREATE PROCEDURE [dbo].[asPost2GL]
    @pMa_Cty nvarchar(3),
    @pStt_rec nvarchar(20),
    @pMa_ct nvarchar(3),
    @pPostUnpost nvarchar(1)  -- 1=Post, 0=Unpost
```

#### Cơ chế hoạt động
```
1. User chọn chứng từ cần post
        ↓
2. Gọi asPost2GL
        ↓
3. Kiểm tra @pPostUnpost:
   - Nếu = '1': Post
     + Lấy SP_Post từ SiDmCt
     + Exec SP_Post tương ứng
     + Insert vào GlCt
   - Nếu = '0': Unpost
     + Delete khỏi GlCt
     + Update Post2GL = 0
        ↓
4. Update trạng thái phiếu gốc
```

### Mapping Chứng Từ → SP Post

| Loại CT | Mã CT | SP Post | Bảng nguồn |
|---------|-------|---------|------------|
| Phiếu KT | GL1 | asPostGlPh1_glct | GlPh1, GlCt1 |
| Hóa đơn bán | AR1 | asARPostPh1_glct | ArPh1, ArCt1 |
| Phiếu thu | AR3 | asARPostPh3_glct | ArPh3, ArCt3 |
| Hóa đơn mua | AP1 | asAPPostPh1_glct | ApPh1, ApCt1 |
| Phiếu chi | AP3 | asAPPostPh3_glct | ApPh3, ApCt3 |
| Nhập kho | IN1 | asPostInPh1_glct | InPh1, InCt1 |
| Xuất kho | IN2 | asPostInPh1_glct | InPh2, InCt2 |
| Phiếu thu | CA1 | asPostCaPh1_glct | CaPh1, CaCt1 |
| Phiếu chi | CA2 | asPostCaPh2_glct | CaPh2, CaCt2 |

---

## Luồng Dữ Liệu Tổng Quan

```
┌─────────────────────────────────────────────────────────────────┐
│                         SIMBA SQL WORKFLOWS                      │
└─────────────────────────────────────────────────────────────────┘

    ┌──────────┐      ┌──────────┐      ┌──────────┐
    │   SO     │ ───→ │   SI     │ ───→ │   AR     │
    │  (Bán)   │      │ (Hóa đơn)│      │(Công nợ) │
    └──────────┘      └──────────┘      └────┬─────┘
                                              │
    ┌──────────┐      ┌──────────┐           │
    │   PO     │ ───→ │   IN     │ ←─────────┘
    │  (Mua)   │      │  (Kho)   │
    └──────────┘      └────┬─────┘
                           │
    ┌──────────┐           │
    │   AP     │ ←─────────┘
    │(Công nợ) │
    └────┬─────┘
         │
         ↓
    ┌──────────┐      ┌──────────┐
    │   CA     │      │   GL     │
    │(Thu/Chi) │ ───→ │(Sổ cái)  │
    └──────────┘      └──────────┘
                           ↑
    ┌──────────┐           │
    │   FA     │ ──────────┤
    │(TSCĐ)    │           │
    └──────────┘           │
                           │
    ┌──────────┐           │
    │   CO     │ ──────────┘
    │(Giá thành)│
    └──────────┘
```

---

## Luồng Post → GL Chi Tiết

### Bút Toán Tự Động Theo Nghiệp Vụ

| Nghiệp vụ | Nợ | Có |
|-----------|----|----|
| Bán hàng (AR1) | 131 | 511, 3331 |
| | 632 | 156 |
| Thu tiền (CA1) | 111/112 | 131 |
| Mua hàng (AP1) | 156, 133 | 331 |
| Chi tiền (CA2) | 331 | 111/112 |
| Nhập kho (IN1) | 156 | 331/111/112 |
| Xuất kho (IN2) | 632 | 156 |
| Khấu hao TSCĐ | 642 | 214 |
| Ghi tăng TSCĐ | 211 | 331/111/112 |
| Lương (HR) | 642, 622 | 334, 338 |
| Chi phí SX | 154 | 621, 622, 627 |
| Nhập thành phẩm | 155 | 154 |
