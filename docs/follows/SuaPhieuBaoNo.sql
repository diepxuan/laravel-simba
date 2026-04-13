exec asProcessCt @pMa_cty=N'001',@pMa_Ct=N'CA4',@pStt_rec=N'001wCA40000000676651',@pMode=N'2'

declare @p3 int
set @p3=0
exec asDelTain @pMa_cty=N'001',@pStt_rec=N'001wCA40000000676651',@pRet=@p3 output
select @p3

declare @p17 int
set @p17=0
exec asCAInsCT2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000676651',@pStt_rec0=N'001',@pTk=N'331',@pPs_no=44637000,@pPs_co=0,@pPs_no_nt=44637000,@pPs_co_nt=0,@pDien_giai=N'thanh toán 10.02.26',@pMa_kh=N'CCTUANANH',@pMa_ku=N'',@pMa_lo=N'',@pMa_bp=N'',@pMa_hd=N'',@pMa_phi=N'',@pMa_spct=N'',@pRet=@p17 output
select @p17

declare @p3 int
set @p3=0
exec asCADelCT2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000676651',@pRet=@p3 output
select @p3

declare @p23 int
set @p23=0
exec asCAUpdPH2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000676651',@pMa_ct=N'CA4',@pSo_ct=N'BN02943',@pNgay_ct='2026-02-16 00:00:00',@pNgay_lct='2026-02-24 00:00:00',@pKht_tain=0,@pMa_kh=N'CCTUANANH',@pDia_chi=N'Hà Nội',@pNguoi_gd=N'Lợi',@pDien_giai=N'thanh toán 16.02.26 hết',@pTk_co=N'11217',@pMa_nt=N'VND',@pTy_gia=1,@pT_tien_nt=44637000,@pT_tien=44637000,@pT_Thue=0,@pT_Tt_nt=44637000,@pT_Tt=44637000,@pTrang_thai=N'',@pPost2gl=N'',@pLUser=N'DUCTN',@pRet=@p23 output
select @p23

declare @p6 float
set @p6=0
exec asChkSoCt @pMa_Cty=N'001',@pMa_Ct=N'CA4',@pStt_Rec=N'001wCA40000000676651',@pSo_ct=N'BN02943',@pNgay_ct='2026-02-16 00:00:00',@pRet=@p6 output
select @p6

exec asSiGetSetupByName @pMa_Cty=N'001',@pTen_bien=N'ngay_ks'

exec asValid @pMa_Cty=N'001',@pCodeName=N'MA_KH',@pCodeValue=N'CCTUANANH',@pFieldList=N'ten_kh,dia_chi,nguoi_gd,ma_httt_po',@pTableName=N'ARDMKH',@pWhere=N'Ma_Cty=''001'' AND KSd=0'

exec asValid @pMa_Cty=N'001',@pCodeName=N'TK',@pCodeValue=N'11217',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''001'' AND KSd=0 AND chi_tiet=1'

exec asValid @pMa_Cty=N'001',@pCodeName=N'MA_KH',@pCodeValue=N'CCTUANANH',@pFieldList=N'ten_kh,dia_chi,nguoi_gd,ma_httt_po',@pTableName=N'ARDMKH',@pWhere=N'Ma_Cty=''001'' AND KSd=0'

exec asSiGetSetupByName @pMa_Cty=N'001',@pTen_bien=N'ngay_ks'