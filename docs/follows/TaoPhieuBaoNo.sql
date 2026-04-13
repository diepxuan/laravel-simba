declare @p4 char(12)
set @p4='BN02944     '
exec asGetSoCt @pMa_cty=N'001',@pMa_Ct=N'CA4',@pNgay_Ct='2026-02-16 00:00:00',@pSo_Ct=@p4 output
select @p4

exec asValid @pMa_Cty=N'001',@pCodeName=N'TK',@pCodeValue=N'11211',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''001'' AND KSd=0 AND chi_tiet=1'

exec asValid @pMa_Cty=N'001',@pCodeName=N'MA_KH',@pCodeValue=N'CCNHUNGGOI',@pFieldList=N'ten_kh,dia_chi,nguoi_gd,ma_httt_po',@pTableName=N'ARDMKH',@pWhere=N'Ma_Cty=''001'' AND KSd=0'

exec asValid @pMa_Cty=N'001',@pCodeName=N'TK',@pCodeValue=N'11217',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''001'' AND KSd=0 AND chi_tiet=1'

exec asValid @pMa_Cty=N'001',@pCodeName=N'TK',@pCodeValue=N'331',@pFieldList=N'',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''001'' AND KSd=0 AND chi_tiet=1'

exec asValid @pMa_Cty=N'001',@pCodeName=N'TK',@pCodeValue=N'331',@pFieldList=N'ten_tk,tk_cn',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''001'' AND KSd=0 AND chi_tiet=1'

exec dbo.asGetSoDuKh @pMa_Cty=N'001',@pMa_kh=N'CCNHUNGGOI',@pTk=N'331',@pNgay='2026-02-12 00:00:00'

exec asValid @pMa_Cty=N'001',@pCodeName=N'TK',@pCodeValue=N'11217',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''001'' AND KSd=0 AND chi_tiet=1'

exec asValid @pMa_Cty=N'001',@pCodeName=N'MA_KH',@pCodeValue=N'CCNHUNGGOI',@pFieldList=N'ten_kh,dia_chi,nguoi_gd,ma_httt_po',@pTableName=N'ARDMKH',@pWhere=N'Ma_Cty=''001'' AND KSd=0'

exec asSiGetSetupByName @pMa_Cty=N'001',@pTen_bien=N'ngay_ks'

declare @p6 float
set @p6=0
exec asChkSoCt @pMa_Cty=N'001',@pMa_Ct=N'CA4',@pStt_Rec=N'0',@pSo_ct=N'BN02944',@pNgay_ct='2026-02-12 00:00:00',@pRet=@p6 output
select @p6

declare @p3 nvarchar(20)
set @p3=N'001wCA40000000676668'
exec asGetSttRec @pMa_cty=N'001',@pMa_Ct=N'CA4',@pStt_Rec=@p3 output
select @p3

declare @p23 int
set @p23=0
exec asCAInsPH2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000676668',@pMa_ct=N'CA4',@pSo_ct=N'BN02944',@pNgay_ct='2026-02-12 00:00:00',@pNgay_lct='2026-02-24 00:00:00',@pKht_tain=0,@pMa_kh=N'CCNHUNGGOI',@pDia_chi=N'',@pNguoi_gd=N'',@pDien_giai=N'thanh toán 12.02.26',@pTk_co=N'11217',@pMa_nt=N'VND',@pTy_gia=1,@pT_tien_nt=142000000,@pT_tien=142000000,@pT_Thue=0,@pT_Tt_nt=142000000,@pT_Tt=142000000,@pTrang_thai=N'',@pPost2gl=N'',@pLUser=N'DUCTN',@pRet=@p23 output
select @p23

declare @p17 int
set @p17=0
exec asCAInsCT2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000676668',@pStt_rec0=N'001',@pTk=N'331',@pPs_no=142000000,@pPs_co=0,@pPs_no_nt=142000000,@pPs_co_nt=0,@pDien_giai=N'thanh toán 12.02.26',@pMa_kh=N'CCNHUNGGOI',@pMa_ku=N'',@pMa_lo=N'',@pMa_bp=N'',@pMa_hd=N'',@pMa_phi=N'',@pMa_spct=N'',@pRet=@p17 output
select @p17

exec asProcessCt @pMa_cty=N'001',@pMa_Ct=N'CA4',@pStt_rec=N'001wCA40000000676668',@pMode=N'1'

