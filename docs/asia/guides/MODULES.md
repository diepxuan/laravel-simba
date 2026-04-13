# SimbaSql - Chi Tiết Các Module

Tài liệu này mô tả chi tiết các module trong hệ thống SimbaSql, bao gồm chức năng, stored procedures chính và luồng xử lý.

---

## Tổng Quan Hệ Thống

| Module | Tên Đầy Đủ | Số SP | Mô Tả |
|--------|-----------|-------|-------|
| GL | General Ledger | 310 | Sổ cái kế toán |
| SO | Sales Order | 163 | Quản lý đơn hàng bán |
| SI | Sales Invoice | 50 | Hệ thống thông tin bán hàng |
| AR | Accounts Receivable | 88 | Công nợ phải thu |
| AP | Accounts Payable | 41 | Công nợ phải trả |
| IN | Inventory | 130 | Quản lý kho |
| CA | Cash | 53 | Quản lý quỹ tiền mặt |
| FA | Fixed Asset | 57 | Quản lý tài sản cố định |
| CO | Cost | 36 | Tính giá thành |
| PO | Purchase Order | 126 | Quản lý đơn hàng mua |

---

## Module GL (General Ledger) - Sổ Cái

### Chức năng chính
- Lập phiếu kế toán tổng hợp
- Post chứng từ lên sổ cái
- Quản lý tài khoản kế toán (DMTK)
- Quản lý đối tượng kế toán (DMKC)
- Quản lý dư đầu kỳ (CDTK)
- Báo cáo tài chính (BCTC)
- Quản lý ngân sách (Budget)

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| GlCt1 | Chi tiết phiếu kế toán |
| GlCt | Chi tiết phiếu kế toán (mở rộng) |
| GlPh1 | Phiếu kế toán header |
| GlDmTk | Danh mục tài khoản |
| GlDmKc | Danh mục đối tượng kế toán |
| GlCdTk | Số dư đầu kỳ tài khoản |
| GlBudget | Ngân sách |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asGLInsCt1 | Insert chi tiết phiếu KT | GlCt1 |
| asGLInsPh1 | Insert phiếu KT header | GlPh1 |
| asGLUpdPh1 | Update phiếu KT | GlPh1 |
| asGLDelCt1 | Delete chi tiết phiếu KT | GlCt1 |
| asGLDelPh1 | Delete phiếu KT | GlPh1 |
| asGLInsDMTK | Insert danh mục TK | GlDmTk |
| asGLUpdDMTK | Update danh mục TK | GlDmTk |
| asGLDelDMTK | Delete danh mục TK | GlDmTk |
| asGLInsDMKC | Insert danh mục KC | GlDmKc |
| asGLUpdDMKC | Update danh mục KC | GlDmKc |
| asGLDelDMKC | Delete danh mục KC | GlDmKc |
| asGLInsCdTk | Insert số dư đầu kỳ | GlCdTk |
| asGLUpdCdTk | Update số dư đầu kỳ | GlCdTk |
| asGLDelCdTk | Delete số dư đầu kỳ | GlCdTk |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asGLGetCt1 | Lấy chi tiết phiếu KT |
| asGLGetPh1 | Lấy phiếu KT header |
| asGLFilt1 | Filter danh sách phiếu KT |
| asGLGetDMTK | Lấy danh mục tài khoản |
| asGLGetDMKC | Lấy danh mục đối tượng KC |
| asGLGetCdTk | Lấy số dư đầu kỳ |

#### Post/Process
| SP | Chức năng |
|----|-----------|
| asPost2GL | Post chứng từ lên sổ cái |
| asPostGlPh1_glct | Post phiếu GL sang GlCt |
| asGLCrtKC | Tạo bút toán kết chuyển |
| asGLDelKC | Xóa bút toán kết chuyển |
| asGLCalSumCdTk | Tính tổng số dư TK |

#### Báo cáo
| SP | Chức năng |
|----|-----------|
| asGLRptNKC01 | Báo cáo nhật ký chung |
| asGLRptBCT01 | Báo cáo tài chính |
| asGLRptBCPT01 | Báo cáo phân tích |

### Luồng xử lý

#### 1. Lập phiếu kế toán
```
User nhập liệu → frmGlVchGL1
    ↓
Validate → Kiểm tra tài khoản, số dư
    ↓
Save → asGLInsPh1 (header) + asGLInsCt1 (detail)
    ↓
Post → asPost2GL → Insert GlCt
```

#### 2. Post chứng từ
```
Chọn chứng từ cần post
    ↓
asPost2GL(@pMa_cty, @pStt_rec, @pMa_ct, '1')
    ↓
Gọi SP_Post từ SiDmCt tương ứng với loại chứng từ
    ↓
Insert vào GlCt (sổ cái)
    ↓
Update Post2GL = 1 trên phiếu gốc
```

---

## Module SO (Sales Order) - Đơn Hàng Bán

### Chức năng chính
- Tạo và quản lý đơn hàng bán (SO1)
- Quản lý báo giá (SO2)
- Quản lý hợp đồng (SO3)
- Quản lý đặt hàng (SO4)
- Quản lý khuyến mãi (DMKM)
- Quản lý giá bán (DMGIABAN)

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| SoCt1 | Chi tiết đơn hàng |
| SoCt2 | Chi tiết đặt hàng |
| SoCt3 | Chi tiết báo giá |
| SoCt4 | Chi tiết hợp đồng |
| SoPh1 | Đơn hàng header |
| SoPh2 | Đặt hàng header |
| SoPh3 | Báo giá header |
| SoPh4 | Hợp đồng header |
| SoDmKm | Danh mục khuyến mãi |
| SoDmGiaBan | Danh mục giá bán |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asSoInsCt1 | Insert chi tiết đơn hàng | SoCt1 |
| asSoInsPh1 | Insert đơn hàng header | SoPh1 |
| asSOUpdPH1 | Update đơn hàng | SoPh1 |
| asSODelCT1 | Delete chi tiết đơn hàng | SoCt1 |
| asSODelPH1 | Delete đơn hàng | SoPh1 |
| asSOInsCT3 | Insert chi tiết báo giá | SoCt3 |
| asSOInsPH3 | Insert báo giá | SoPh3 |
| asSOInsCT4 | Insert chi tiết hợp đồng | SoCt4 |
| asSOInsPH4 | Insert hợp đồng | SoPh4 |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asSOGetPh1 | Lấy đơn hàng |
| asSOGetPH3 | Lấy báo giá |
| asSOGetPH4 | Lấy hợp đồng |
| asSOGetCT1 | Lấy chi tiết đơn hàng |
| asSOGetGiaban | Lấy giá bán |
| asSOFilt1 | Filter đơn hàng |

#### Danh mục
| SP | Chức năng |
|----|-----------|
| asSOInsDMKM | Insert khuyến mãi |
| asSOUpdDMKM | Update khuyến mãi |
| asSODelDMKM | Delete khuyến mãi |
| asSOGetDMKM | Lấy khuyến mãi |
| asSOInsDMgiaban | Insert giá bán |
| asSOGetdmgiaban | Lấy giá bán |

### Luồng xử lý

#### 1. Tạo đơn hàng bán
```
User nhập liệu → frmSoVchSO1
    ↓
Chọn khách hàng, sản phẩm
    ↓
Kiểm tra giá → asSOGetGiaban
    ↓
Kiểm tra khuyến mãi → asSOGetDMKM
    ↓
Save → asSoInsPh1 + asSoInsCt1
    ↓
Post → asPost2GL (nếu cần)
```

#### 2. Tạo báo giá
```
User nhập liệu → frmSoVchSO3
    ↓
Nhập sản phẩm, giá
    ↓
Save → asSOInsPH3 + asSOInsCT3
    ↓
Chuyển thành đơn hàng (nếu duyệt)
```

---

## Module SI (System Information) - Hệ Thống

### Chức năng chính
- Quản lý chứng từ (DMCT)
- Quản lý người dùng và phân quyền
- Quản lý cấu hình hệ thống
- Quản lý ngôn ngữ
- Quản lý theme
- Backup/Restore dữ liệu

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| SiDmCt | Danh mục chứng từ |
| SiDmBp | Danh mục bộ phận |
| SiDmHd | Danh mục hóa đơn |
| SiDmNgh | Danh mục ngoại hối |
| SiUserInfo | Thông tin người dùng |
| SiGroupInfo | Nhóm người dùng |

### Các SP chính

#### Danh mục chứng từ
| SP | Chức năng |
|----|-----------|
| asSIGetDMCT | Lấy danh mục chứng từ |
| asSIInsDMCT | Insert chứng từ |
| asSIUpdDMCT | Update chứng từ |
| asSIDelDMCT | Delete chứng từ |

#### Danh mục bộ phận
| SP | Chức năng |
|----|-----------|
| asSIGetDMBP | Lấy danh mục BP |
| asSIInsDMBP | Insert BP |
| asSIUpdDMBP | Update BP |
| asSIDelDMBP | Delete BP |

#### Hệ thống
| SP | Chức năng |
|----|-----------|
| asSIGetDMCTByMa_Ct | Lấy CT theo mã |
| asSIGetTableColumnDefine | Lấy cấu trúc bảng |
| asSiGetSetup | Lấy cấu hình hệ thống |
| asSiScheduleAutoBackupData | Lên lịch backup |

---

## Module AR (Accounts Receivable) - Công Nợ Phải Thu

### Chức năng chính
- Quản lý khách hàng (DMKH)
- Quản lý công nợ phải thu
- Quản lý hóa đơn bán hàng (AR1)
- Quản lý phiếu thu (AR3)
- Quản lý bù trừ công nợ (AR4)
- Tính lại số dư công nợ

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| ArDmKh | Danh mục khách hàng |
| ArCt1 | Chi tiết hóa đơn |
| ArCt3 | Chi tiết phiếu thu |
| ArCt4 | Chi tiết bù trừ |
| ArPh1 | Hóa đơn header |
| ArPh3 | Phiếu thu header |
| ArPh4 | Bù trừ header |
| ArTt | Thanh toán |
| ArCdKh | Số dư đầu kỳ KH |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asARInsPH1 | Insert hóa đơn | ArPh1 |
| asARInsCT1 | Insert chi tiết HĐ | ArCt1 |
| asARInsPH3 | Insert phiếu thu | ArPh3 |
| asARInsCT3 | Insert chi tiết thu | ArCt3 |
| asARInsDMKH | Insert khách hàng | ArDmKh |
| asARUpdDMKH | Update khách hàng | ArDmKh |
| asARDelDMKH | Delete khách hàng | ArDmKh |

#### Post
| SP | Chức năng |
|----|-----------|
| asARPostPh1_artt | Post HĐ sang ArTt |
| asARPostPh1_glct | Post HĐ sang GlCt |
| asARPostPh3_glct | Post phiếu thu sang GlCt |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asARGetPH1 | Lấy hóa đơn |
| asARGetPH3 | Lấy phiếu thu |
| asARGetDMKH | Lấy khách hàng |
| asARFilt1 | Filter hóa đơn |
| asARFilt3 | Filter phiếu thu |

#### Tính toán
| SP | Chức năng |
|----|-----------|
| asARRecalCustBalance | Tính lại số dư KH |
| asARReCalAR14Relate | Tính lại AR1-AR4 |
| asARReCalAR34Relate | Tính lại AR3-AR4 |

### Luồng xử lý

#### 1. Lập hóa đơn bán hàng (AR1)
```
Tạo HĐ từ SO/SI → frmArVchAR1
    ↓
Chọn khách hàng → asARGetDMKH
    ↓
Nhập chi tiết sản phẩm
    ↓
Save → asARInsPH1 + asARInsCT1
    ↓
Post → asARPostPh1_glct (sang GL)
    ↓
      → asARPostPh1_artt (sang ArTt)
```

#### 2. Lập phiếu thu (AR3)
```
Tạo phiếu thu → frmArVchAR3
    ↓
Chọn khách hàng, hóa đơn
    ↓
Kiểm tra số dư công nợ
    ↓
Save → asARInsPH3 + asARInsCT3
    ↓
Post → asARPostPh3_glct
    ↓
Cập nhật ArTt (thanh toán)
```

---

## Module AP (Accounts Payable) - Công Nợ Phải Trả

### Chức năng chính
- Quản lý nhà cung cấp (DMNCC)
- Quản lý công nợ phải trả
- Quản lý hóa đơn mua hàng (AP1)
- Quản lý phiếu chi (AP3)
- Quản lý bù trừ công nợ (AP4)

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| ApCt1 | Chi tiết hóa đơn mua |
| ApCt3 | Chi tiết phiếu chi |
| ApCt4 | Chi tiết bù trừ |
| ApPh1 | Hóa đơn mua header |
| ApPh3 | Phiếu chi header |
| ApPh4 | Bù trừ header |
| ApTt | Thanh toán |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asAPInsPH1 | Insert hóa đơn mua | ApPh1 |
| asAPInsCT1 | Insert chi tiết HĐ mua | ApCt1 |
| asAPInsPH3 | Insert phiếu chi | ApPh3 |
| asAPInsCT3 | Insert chi tiết chi | ApCt3 |
| asAPUpdPH1 | Update hóa đơn | ApPh1 |
| asAPDelPH1 | Delete hóa đơn | ApPh1 |

#### Post
| SP | Chức năng |
|----|-----------|
| asAPPostPh1_aptt | Post HĐ sang ApTt |
| asAPPostPh1_glct | Post HĐ sang GlCt |
| asAPPostPh3_glct | Post phiếu chi sang GlCt |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asAPGetPH1 | Lấy hóa đơn mua |
| asAPGetPH3 | Lấy phiếu chi |
| asAPFilt1 | Filter hóa đơn |
| asAPFilt3 | Filter phiếu chi |
| asAPGetPO1AP1 | Lấy PO cho AP1 |
| asAPGetPO4AP1 | Lấy PO4 cho AP1 |

---

## Module IN (Inventory) - Quản Lý Kho

### Chức năng chính
- Quản lý vật tư (DMVT)
- Quản lý kho (DMKHO)
- Quản lý nhập kho (IN1)
- Quản lý xuất kho (IN2)
- Quản lý chuyển kho (IN3)
- Quản lý kiểm kê (IN5)
- Tính giá xuất kho (FIFO, Weighted Average)

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| InDmVt | Danh mục vật tư |
| InDmKho | Danh mục kho |
| InCt1 | Chi tiết nhập kho |
| InCt2 | Chi tiết xuất kho |
| InCt3 | Chi tiết chuyển kho |
| InCt5 | Chi tiết kiểm kê |
| InPh1 | Nhập kho header |
| InPh2 | Xuất kho header |
| InPh3 | Chuyển kho header |
| InPh5 | Kiểm kê header |
| InCdFifo | Dư đầu kỳ FIFO |
| InCdVt | Dư đầu kỳ vật tư |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asINInsCT1 | Insert chi tiết nhập kho | InCt1 |
| asINInsPH1 | Insert nhập kho | InPh1 |
| asINInsCT2 | Insert chi tiết xuất kho | InCt2 |
| asINInsPH2 | Insert xuất kho | InPh2 |
| asINInsCT3 | Insert chi tiết chuyển kho | InCt3 |
| asINInsPH3 | Insert chuyển kho | InPh3 |
| asINInsDMVT | Insert vật tư | InDmVt |
| asINUpdDMVT | Update vật tư | InDmVt |
| asINDelDMVT | Delete vật tư | InDmVt |
| asINInsDMKHO | Insert kho | InDmKho |
| asINUpdDMKHO | Update kho | InDmKho |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asINGetCT1 | Lấy chi tiết nhập kho |
| asINGetCT2 | Lấy chi tiết xuất kho |
| asINGetPH1 | Lấy nhập kho |
| asINGetPH2 | Lấy xuất kho |
| asINGetDMVT | Lấy vật tư |
| asINGetDMKHO | Lấy kho |
| asINFilt1 | Filter nhập kho |
| asINFilt2 | Filter xuất kho |
| asINGetTonVtAll | Lấy tồn kho |

#### Tính giá
| SP | Chức năng |
|----|-----------|
| asINCalGiaTB_Post_INCT2GLCT | Tính giá TB post sang GL |
| asINPostCDFIFO2CDVT | Post FIFO sang CDVT |
| asINPostCDVT2CDFIFO | Post CDVT sang FIFO |
| asINChuyenTonKho | Chuyển tồn kho |

### Luồng xử lý

#### 1. Nhập kho (IN1)
```
Tạo phiếu nhập → frmInVchIN1
    ↓
Chọn NCC (nếu từ PO) hoặc nhập trực tiếp
    ↓
Nhập chi tiết vật tư
    ↓
Kiểm tra tồn kho, giá
    ↓
Save → asINInsPH1 + asINInsCT1
    ↓
Post → asPostInPh1_glct (sang GL)
    ↓
Cập nhật tồn kho, giá vốn
```

#### 2. Xuất kho (IN2)
```
Tạo phiếu xuất → frmInVchIN2
    ↓
Chọn khách hàng (nếu từ SO/SI)
    ↓
Nhập chi tiết vật tư xuất
    ↓
Kiểm tra tồn kho
    ↓
Save → asINInsPH2 + asINInsCT2
    ↓
Post → asPostInPh1_glct (sang GL)
    ↓
Tính giá vốn xuất kho
```

---

## Module CA (Cash) - Quản Lý Quỹ

### Chức năng chính
- Quản lý quỹ tiền mặt (DMKU)
- Quản lý phiếu thu (CA1)
- Quản lý phiếu chi (CA2)
- Quản lý báo có (CA3)
- Quản lý lãi vay/lãi cho vay

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| CaDmKu | Danh mục quỹ |
| CaCt1 | Chi tiết phiếu thu |
| CaCt2 | Chi tiết phiếu chi |
| CaCt3 | Chi tiết báo có |
| CaPh1 | Phiếu thu header |
| CaPh2 | Phiếu chi header |
| CaPh3 | Báo có header |
| CaTtHu | Thanh toán hợp đồng |
| CaCdKu | Số dư đầu kỳ quỹ |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asCAInsPH1 | Insert phiếu thu | CaPh1 |
| asCAInsCT1 | Insert chi tiết thu | CaCt1 |
| asCAInsPH2 | Insert phiếu chi | CaPh2 |
| asCAInsCT2 | Insert chi tiết chi | CaCt2 |
| asCAInsDMKU | Insert quỹ | CaDmKu |
| asCAUpdDMKU | Update quỹ | CaDmKu |
| asCADelDMKU | Delete quỹ | CaDmKu |

#### Post
| SP | Chức năng |
|----|-----------|
| asPostCaPh1_glct | Post phiếu thu sang GL |
| asPostCaPh2_glct | Post phiếu chi sang GL |
| asPostCaPh3_glct | Post báo có sang GL |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asCAGetPH1 | Lấy phiếu thu |
| asCAGetPH2 | Lấy phiếu chi |
| asCAGetDMKU | Lấy danh mục quỹ |
| asCAFilt1 | Filter phiếu thu |
| asCAFilt2 | Filter phiếu chi |

---

## Module FA (Fixed Asset) - Tài Sản Cố Định

### Chức năng chính
- Quản lý tài sản cố định (DMTS)
- Quản lý công cụ dụng cụ (DMCC)
- Tính khấu hao TSCĐ
- Tính phân bổ CCDC
- Quản lý ghi tăng/giảm TSCĐ

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| FaDmTs | Danh mục TSCĐ |
| FaDmCc | Danh mục CCDC |
| FaDmNhts | Danh mục nhóm TSCĐ |
| FaKhTs | Khấu hao TSCĐ |
| FaKhCc | Phân bổ CCDC |
| FaDtsd | Điều chỉnh TSCĐ |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asFAInsDMTS | Insert TSCĐ | FaDmTs |
| asFAUpdDMTS | Update TSCĐ | FaDmTs |
| asFADelDMTS | Delete TSCĐ | FaDmTs |
| asFAInsDMCC | Insert CCDC | FaDmCc |
| asFAUpdDMCC | Update CCDC | FaDmCc |
| asFADelDMCC | Delete CCDC | FaDmCc |
| asFAInsDTSD | Insert điều chỉnh | FaDtsd |
| asFAUpdDTSD | Update điều chỉnh | FaDtsd |

#### Khấu hao/Phân bổ
| SP | Chức năng |
|----|-----------|
| asFACalKHTS | Tính khấu hao TSCĐ |
| asFAGetKHTS | Lấy khấu hao |
| asFAUpdKHTS | Update khấu hao |
| asFADelKHTS | Xóa khấu hao |
| asFAPost2GlCt | Post KH sang GL |
| asFAPostCc2GlCt | Post CCDC sang GL |

#### Get
| SP | Chức năng |
|----|-----------|
| asFAGetDMTS | Lấy TSCĐ |
| asFAGetDMCC | Lấy CCDC |
| asFAGetDMNHTS | Lấy nhóm TSCĐ |
| asFAGetDTSD | Lấy điều chỉnh |
| asFAGetTenNv | Lấy tên nhân viên |

---

## Module CO (Cost) - Tính Giá Thành

### Chức năng chính
- Quản lý định mức BOM (DMBOM)
- Quản lý phân bổ chi phí (DMPB)
- Tính giá thành sản phẩm
- Quản lý lệnh sản xuất

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| CoDmBomPh | BOM header |
| CoDmBomCt | BOM chi tiết |
| CoDmPb | Phân bổ chi phí |
| CoDmPb1 | Phân bổ chi phí chi tiết |
| CoDmSpct | Danh mục sản phẩm chi tiết |
| CoDmNhSpct | Nhóm sản phẩm CT |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asCOInsDMCoBomPH | Insert BOM PH | CoDmBomPh |
| asCOInsDMCoBomCT | Insert BOM CT | CoDmBomCt |
| asCOUpdDMCoBomPH | Update BOM PH | CoDmBomPh |
| asCOUpdDMCoBomCT | Update BOM CT | CoDmBomCt |
| asCODelDMCoBomPH | Delete BOM PH | CoDmBomPh |
| asCODelDMCoBomCT | Delete BOM CT | CoDmBomCt |
| asCOInsDMPB | Insert phân bổ | CoDmPb |
| asCOInsDMPB1 | Insert phân bổ CT | CoDmPb1 |
| asCOUpdDMPB | Update phân bổ | CoDmPb |
| asCODelDMPB | Delete phân bổ | CoDmPb |
| asCODelDMPB1 | Delete phân bổ CT | CoDmPb1 |
| asCOInsDMSPCT | Insert SPCT | CoDmSpct |
| asCOUpdDMSPCT | Update SPCT | CoDmSpct |

#### Tính toán
| SP | Chức năng |
|----|-----------|
| asCOCalcPb | Tính phân bổ chi phí |
| asCOCalcHsPb | Tính hệ số phân bổ |
| asCOUpdateCost | Update giá thành |
| asCODelUpdateCost | Xóa giá thành |
| asCODelCalcPb | Xóa phân bổ |

#### Post
| SP | Chức năng |
|----|-----------|
| asCOPostCp2GlCt | Post chi phí sang GL |
| asCODelPostCp2GlCt | Xóa post chi phí |

#### Get
| SP | Chức năng |
|----|-----------|
| asCOGetDMCoBomPH | Lấy BOM PH |
| asCOGetDMCoBomCT | Lấy BOM CT |
| asCOGetDMPB | Lấy phân bổ |
| asCOGetDMPB1 | Lấy phân bổ CT |
| asCOGetDMPB12 | Lấy phân bổ 12 |
| asCOGetDMSPCT | Lấy SPCT |
| asCOGetDMNHSPCT | Lấy nhóm SPCT |

---

## Module PO (Purchase Order) - Đơn Hàng Mua

### Chức năng chính
- Quản lý đơn hàng mua (PO1)
- Quản lý nhận hàng (PO2)
- Quản lý hóa đơn mua (PO3)
- Quản lý trả lại hàng mua (PO4)
- Quản lý giá mua (DMGiaMua)
- Quản lý điều kiện thanh toán (DMTT)

### Các Tables chính
| Table | Mô tả |
|-------|-------|
| PoCt0 | Chi tiết đơn hàng mua |
| PoCt1 | Chi tiết nhận hàng |
| PoCt2 | Chi tiết hóa đơn mua |
| PoCt3 | Chi tiết trả lại |
| PoPh0 | Đơn hàng mua header |
| PoPh1 | Nhận hàng header |
| PoPh2 | Hóa đơn mua header |
| PoPh3 | Trả lại header |
| PoDmCp | Danh mục chi phí |
| PoDmGiaMua | Danh mục giá mua |
| PoDmTt | Danh mục điều kiện TT |

### Các SP chính

#### Insert/Update/Delete
| SP | Chức năng | Tables |
|----|-----------|--------|
| asPOInsPH0 | Insert đơn hàng mua | PoPh0 |
| asPOInsCT0 | Insert chi tiết ĐH mua | PoCt0 |
| asPOInsPH1 | Insert nhận hàng | PoPh1 |
| asPOInsCT1 | Insert chi tiết nhận hàng | PoCt1 |
| asPOInsPH2 | Insert hóa đơn mua | PoPh2 |
| asPOInsCT2 | Insert chi tiết HĐ mua | PoCt2 |
| asPOUpdPH0 | Update đơn hàng | PoPh0 |
| asPOUpdPH1 | Update nhận hàng | PoPh1 |
| asPODelPH0 | Delete đơn hàng | PoPh0 |
| asPODelCT0 | Delete chi tiết | PoCt0 |

#### Get/Filter
| SP | Chức năng |
|----|-----------|
| asPOGetPH0 | Lấy đơn hàng mua |
| asPOGetPH1 | Lấy nhận hàng |
| asPOGetPH2 | Lấy hóa đơn mua |
| asPOGetCT0 | Lấy chi tiết ĐH mua |
| asPOGetCT1 | Lấy chi tiết nhận hàng |
| asPOFilt0 | Filter đơn hàng mua |
| asPOFilt1 | Filter nhận hàng |
| asPOFilt2 | Filter hóa đơn mua |
| asPOGetGiaNhap | Lấy giá nhập |

#### Lookup
| SP | Chức năng |
|----|-----------|
| asPOLookupDhPn | Lookup đơn hàng |
| asPOLookupDn4Dh | Lookup nhận hàng cho ĐH |
| asPOLookupPnHd | Lookup nhận hàng/HĐ |
| asPOLookupPn4Px | Lookup nhận hàng cho PX |
| asPOLookupHd4Px | Lookup HĐ cho PX |

#### Danh mục
| SP | Chức năng |
|----|-----------|
| asPOInsDMCP | Insert chi phí |
| asPOUpdDMCP | Update chi phí |
| asPODelDMCP | Delete chi phí |
| asPOGetDMCP | Lấy chi phí |
| asPOInsDmGiaMua | Insert giá mua |
| asPOUpdDmGiaMua | Update giá mua |
| asPODelDmGiaMua | Delete giá mua |
| asPOGetDmGiaMua | Lấy giá mua |

### Luồng xử lý

#### 1. Tạo đơn hàng mua (PO0)
```
Tạo ĐH mua → frmPoVchPO0
    ↓
Chọn NCC, nhập sản phẩm
    ↓
Kiểm tra giá → asPOGetDmGiaMua
    ↓
Save → asPOInsPH0 + asPOInsCT0
    ↓
Duyệt đơn hàng
```

#### 2. Nhận hàng (PO1)
```
Tạo phiếu nhận → frmPoVchPO1
    ↓
Lookup đơn hàng → asPOLookupDhPn
    ↓
Chọn sản phẩm nhận
    ↓
Save → asPOInsPH1 + asPOInsCT1
    ↓
Cập nhật số lượng nhận trên ĐH
    ↓
Post → asPostPoPh1_GlCt (sang GL)
```

#### 3. Nhập hóa đơn mua (PO2)
```
Tạo HĐ mua → frmPoVchPO2
    ↓
Lookup nhận hàng → asPOLookupDn4Dh
    ↓
Nhập giá, thuế
    ↓
Save → asPOInsPH2 + asPOInsCT2
    ↓
Post → asPostPoPh2_GlCt (sang GL)
    ↓
      → asPostPoPh2_apTt (sang AP)
```

---

## Tổng Kết Mapping Module → Tables

| Module | Tables Danh Mục | Tables Chi Tiết | Tables Phiếu |
|--------|----------------|-----------------|--------------|
| GL | GlDmTk, GlDmKc, GlDmCtgs | GlCt1, GlCt | GlPh1 |
| SO | SoDmKm, SoDmGiaBan, SoDmNvkd | SoCt1-SoCt6 | SoPh1-SoPh6 |
| AR | ArDmKh, ArDmNhKh, ArDmPlKh | ArCt1, ArCt3, ArCt4 | ArPh1, ArPh3, ArPh4 |
| AP | - | ApCt1, ApCt3, ApCt4 | ApPh1, ApPh3, ApPh4 |
| IN | InDmVt, InDmKho, InDmLo | InCt1-InCt9 | InPh1-InPh9 |
| CA | CaDmKu | CaCt1, CaCt2, CaCt3 | CaPh1, CaPh2, CaPh3 |
| FA | FaDmTs, FaDmCc, FaDmNhts | - | - |
| CO | CoDmBomPh, CoDmBomCt, CoDmPb | - | - |
| PO | PoDmCp, PoDmGiaMua, PoDmTt | PoCt0-PoCt8 | PoPh0-PoPh8 |
| SI | SiDmCt, SiDmBp, SiDmHd | - | - |

---

## Pattern Đặt Tên Stored Procedures

Pattern chung: `as[Module][Action][Entity]`

| Thành phần | Ý nghĩa | Ví dụ |
|------------|---------|-------|
| as | AsiaSoft prefix | - |
| Module | Mã module (GL, SO, AR, ...) | GL, SO, AR |
| Action | Hành động | Ins, Upd, Del, Get, Filt, Post, Rpt |
| Entity | Đối tượng | Ct1, Ph1, DMTK, DMKH |

### Các Action phổ biến
| Action | Ý nghĩa |
|--------|---------|
| Ins | Insert |
| Upd | Update |
| Del | Delete |
| Get | Lấy dữ liệu theo key |
| Filt | Filter/Lấy danh sách |
| Post | Post sang module khác (thường là GL) |
| Rpt | Report/Báo cáo |
| Cal | Calculate/Tính toán |
| Chk | Check/Kiểm tra |
| Crt | Create/Tạo (thường là tạo bút toán) |
| Lookup | Tìm kiếm/Lookup |
| Save | Lưu dữ liệu liên quan |

### Các Entity phổ biến
| Entity | Ý nghĩa |
|--------|---------|
| Ct1, Ct2, ... | Chi tiết (dòng) |
| Ph1, Ph2, ... | Phiếu header |
| DM* | Danh mục (DMKH, DMTK, ...) |
| CD* | Số dư đầu kỳ (CDTK, CDKH, ...) |
| TT | Thanh toán |
