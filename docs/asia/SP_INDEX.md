# Stored Procedures Index - ASIA ERP

Tài liệu này liệt kê các Stored Procedures được gọi từ các DLL đã phân tích.

## Danh Sách SP Theo Module

### AP (Accounts Payable)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asAPInsPH1 | Insert phiếu AP header | ApVchAP4 |
| asAPInsCt1 | Insert chi tiết AP | ApVchAP4 |
| asAPUpdPH1 | Update phiếu AP | ApVchAP4 |
| asAPDelPH1 | Delete phiếu AP | ApVchAP4 |
| asAPGetPH1 | Lấy phiếu AP | ApVchAP4 |
| asAPFilt1 | Filter danh sách AP | APRptBK01, APRptBK02, APRptBK03 |
| asAPPost2TT | Post thanh toán AP | APTT |
| asAPGetDMNCC | Lấy danh mục NCC | ApVchAP4 |
| asAPGetDMBP | Lấy danh mục BP | ApVchAP4 |

### AR (Accounts Receivable)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asARInsPH1 | Insert phiếu AR header | ARVchAR4 |
| asARInsCt1 | Insert chi tiết AR | ARVchAR4 |
| asARUpdPH1 | Update phiếu AR | ARVchAR4 |
| asARDelPH1 | Delete phiếu AR | ARVchAR4 |
| asARGetPH1 | Lấy phiếu AR | ARVchAR4 |
| asARFilt1 | Filter danh sách AR | ARRptBCCN01-06, ARRptBK01-03 |
| asARPost2TT | Post thanh toán AR | ARTT, ARPost2TT |
| asARGetDMKH | Lấy danh mục KH | ARVchAR4 |
| asARRecalCustBalance | Tính lại số dư KH | ARRecalCustBalance |

### CA (Cash)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asCAInsPH1 | Insert phiếu CA header | CAVchCA1-5 |
| asCAInsCt1 | Insert chi tiết CA | CAVchCA1-5 |
| asCAUpdPH1 | Update phiếu CA | CAVchCA1-5 |
| asCADelPH1 | Delete phiếu CA | CAVchCA1-5 |
| asCAGetPH1 | Lấy phiếu CA | CAVchCA1-5 |
| asCAFilt1 | Filter danh sách CA | CARptTMNH01-07 |
| asCACalLaiKu | Tính lãi khế ước | CACalLaiKu |
| asCADelLaiKu | Xóa lãi khế ước | CADelLaiKu |
| asCAGetDMKU | Lấy danh mục KU | CADMKU |
| asCAGetCDKU | Lấy số dư KU | CACDKU |

### CO (Cost)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asCOCalcCost | Tính giá thành | CoCalcCost |
| asCOGetBOM | Lấy BOM | CODMBOM |
| asCOInsBOM | Insert BOM | CODMBOM |
| asCOUpdBOM | Update BOM | CODMBOM |
| asCODelBOM | Delete BOM | CODMBOM |
| asCOGetCPTP | Lấu chi phí TP | CoRptCTPBCPTT |
| asCOGetGT | Lấy giá thành | CORptGt01-03 |
| asCOGetKHCPTP | Lấy KH chi phí TP | CoRptKHCPTT |

### FA (Fixed Asset)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asFAInsTSCD | Insert TSCD | FARptBCPT01-10 |
| asFAUpdTSCD | Update TSCD | FARptBCPT01-10 |
| asFADelTSCD | Delete TSCD | FARptBCPT01-10 |
| asFACalKHTS | Tính khấu hao TSCD | FACalKHTS |
| asFAGetTSCD | Lấy TSCD | FARptBCTS01-09 |
| asFAGetSoSD | Lấy sổ sử dụng | FARptSoSD |
| asFAGetSoTSCD | Lấy sổ TSCD | FARptSoTSCD |
| asFAPostCC2GL | Post CCDC sang GL | FAPostCC2GL |

### GL (General Ledger)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asGLInsPh1 | Insert phiếu GL | GLPost2GL |
| asGLInsCt1 | Insert chi tiết GL | GLPost2GL |
| asGLUpdPh1 | Update phiếu GL | GLDMTK, GLDMKC |
| asGLDelCt1 | Delete chi tiết GL | GLDMTK, GLDMKC |
| asGLDelPh1 | Delete phiếu GL | GLDMTK, GLDMKC |
| asGLGetPh1 | Lấy phiếu GL | GLPost2GL |
| asGLGetCt1 | Lấy chi tiết GL | GLPost2GL |
| asGLFilt1 | Filter danh sách GL | GLRptNKC01-08 |
| asGLGetDMTK | Lấy danh mục TK | GLDMTK |
| asGLInsDMTK | Insert danh mục TK | GLDMTK |
| asGLUpdDMTK | Update danh mục TK | GLDMTK |
| asGLDelDMTK | Delete danh mục TK | GLDMTK |
| asGLGetDMKC | Lấy danh mục KC | GLDMKC |
| asGLInsDMKC | Insert danh mục KC | GLDMKC |
| asGLUpdDMKC | Update danh mục KC | GLDMKC |
| asGLDelDMKC | Delete danh mục KC | GLDMKC |
| asPost2GL | Post chứng từ lên sổ cái | GLPost2GL, FAPostCC2GL |
| asPostGlPh1_glct | Post phiếu GL sang GlCt | GLPost2GL |
| asGLCrtKC | Tạo bút toán kết chuyển | GLDMKC |
| asGLDelKC | Xóa bút toán kết chuyển | GLDMKC |
| asGLCalSumCdTk | Tính tổng số dư TK | GLDMTK |
| asGLRptNKC01 | Báo cáo NKC 01 | GlRptNkc01 |
| asGLRptNKC02 | Báo cáo NKC 02 | GlRptNkc02 |
| asGLRptCTGS01 | Báo cáo CTGS 01 | GLRptCTGS01 |
| asGLRptBCTC01 | Báo cáo BCTC 01 | GlRptBctc01 |
| asGLRptBCPT01 | Báo cáo BCPT 01 | GLRptBCPT01 |

### IN (Inventory)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asINInsPH1 | Insert phiếu IN header | INVchIN2-6 |
| asINInsCt1 | Insert chi tiết IN | INVchIN2-6 |
| asINUpdPH1 | Update phiếu IN | INVchIN2-6 |
| asINDelPH1 | Delete phiếu IN | INVchIN2-6 |
| asINGetPH1 | Lấy phiếu IN | INVchIN2-6 |
| asINFilt1 | Filter danh sách IN | INRptBK01, INRptCD01-02 |
| asINGetDMVT | Lấy danh mục VT | INDMVT_, INVchIN2-6 |
| asINGetDMKHO | Lấy danh mục kho | INRptBK01 |
| asINGetTonKho | Lấy tồn kho | INRptCTVT01-02 |
| asINGetCDVT | Lấy số dư đầu kỳ VT | INRptCD01-02 |

### PO (Purchase Order)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asPOInsOrder | Insert đơn hàng PO | POVchPO3-7 |
| asPOInsCt1 | Insert chi tiết PO | POVchPO3-7 |
| asPOUpdOrder | Update đơn hàng PO | POVchPO3-7 |
| asPODelOrder | Delete đơn hàng PO | POVchPO3-7 |
| asPOGetOrder | Lấy đơn hàng PO | POVchPO3-7 |
| asPOFilt1 | Filter danh sách PO | PORptBK01-03, PORptTH01-03 |
| asPOGetDMNCC | Lấy danh mục NCC | POVchPO3-7 |
| asPOGetDMBP | Lấy danh mục BP | POVchPO3-7 |

### SO (Sales Order)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asSOInsOrder | Insert đơn hàng SO | SOVchSO3-5 |
| asSOInsCt1 | Insert chi tiết SO | SOVchSO3-5 |
| asSOUpdOrder | Update đơn hàng SO | SOVchSO3-5 |
| asSODelOrder | Delete đơn hàng SO | SOVchSO3-5 |
| asSOGetOrder | Lấy đơn hàng SO | SOVchSO3-5 |
| asSOFilt1 | Filter danh sách SO | SORptBK01-02, SORptTH01-02 |
| asSOGetDMKH | Lấy danh mục KH | SOVchSO3-5 |
| asSOGetGiaban | Lấy giá bán | SOVchSO3-5 |
| asSOGetDMKM | Lấy khuyến mãi | SOVchSO3-5 |

## SP Hệ Thống (Framework)

| SP | Mô tả | DLL gọi |
|----|-------|---------|
| asGetRight | Kiểm tra quyền user | Tất cả |
| asGetTygia | Lấy tỷ giá ngoại tệ | Tất cả |
| asGetSoCt | Lấy số chứng từ | Tất cả |
| asGetSoCtByYear | Lấy số CT theo năm | Tất cả |
| asGetSoDuKh | Lấy số dư khách hàng | AR, AP |
| asGetSttRec | Lấy số thứ tự bản ghi | Tất cả |
| asGetStoredProcedureParameters | Lấy tham số SP | Tất cả |
| asGetTaIn | Lấy dữ liệu tạm nhập | Tất cả |
| asGetTaOut | Lấy dữ liệu tạm xuất | Tất cả |
| asGetTonKhoTucThoiAll | Lấy tồn kho tức thời | IN |
| asGetTonKhoTucThoi | Lấy tồn kho | IN |
| asGetVoucherInfo | Lấy thông tin chứng từ | Tất cả |
| asGetVoucherHistory | Lấy lịch sử chứng từ | Tất cả |
| asGetVoucher2Post | Lấy CT cần post | GLPost2GL |
| asProcessCt | Xử lý chi tiết | Tất cả |
| asChkCodeExists | Kiểm tra mã tồn tại | Tất cả |

## Tổng Kết

| Module | Số lượng SP chính |
|--------|-------------------|
| AP | ~10 |
| AR | ~10 |
| CA | ~10 |
| CO | ~8 |
| FA | ~10 |
| GL | ~25 |
| IN | ~10 |
| PO | ~10 |
| SO | ~10 |
| Framework | ~15 |
| **Tổng** | **~118** |
