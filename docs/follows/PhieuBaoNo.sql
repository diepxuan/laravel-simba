-- Mo Phieu Bao No
exec [diepxuan].[sys].[sp_procedure_params_100_managed] @procedure_name=N'asCAGetPH2'
go
exec asCAGetPH2 @pMa_cty=N'002',@pStt_rec=default,@pMa_ct=N'CA4',@pStruct=NULL
go
exec [diepxuan].[sys].[sp_procedure_params_100_managed] @procedure_name=N'asCAGetCT2'
go
exec asCAGetCT2 @pMa_cty=N'002',@pStt_rec=default,@pStruct=NULL
go
exec [diepxuan].[sys].[sp_procedure_params_100_managed] @procedure_name=N'asGetTain'
go
exec asGetTain @pMa_cty=N'002',@pStt_rec=default
go
-- Mo Form them phieu bao no
exec sp_reset_connection 
go
declare @p4 char(12)
set @p4='00001       '
exec asGetSoCt @pMa_cty=N'002',@pMa_Ct=N'CA4',@pNgay_Ct='2026-03-30 23:13:02.133',@pSo_Ct=@p4 output
select @p4
go
exec sp_reset_connection 
go
exec asValid @pMa_Cty=N'002',@pCodeName=N'TK',@pCodeValue=N'11211',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''002'' AND KSd=0 AND chi_tiet=1'
go
-- Dien Ma nha cung cap, Ma tk
exec asValid @pMa_Cty=N'002',@pCodeName=N'TK',@pCodeValue=N'11211',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''002'' AND KSd=0 AND chi_tiet=1'
go
exec sp_reset_connection 
go
exec asValid @pMa_Cty=N'002',@pCodeName=N'MA_KH',@pCodeValue=N'CONGTY',@pFieldList=N'ten_kh,dia_chi,nguoi_gd,ma_httt_po',@pTableName=N'ARDMKH',@pWhere=N'Ma_Cty=''002'' AND KSd=0'
go
exec sp_reset_connection 
go
exec asValid @pMa_Cty=N'002',@pCodeName=N'TK',@pCodeValue=N'331',@pFieldList=N'',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''002'' AND KSd=0 AND chi_tiet=1'
go
exec sp_reset_connection 
go
exec asValid @pMa_Cty=N'002',@pCodeName=N'TK',@pCodeValue=N'331',@pFieldList=N'ten_tk,tk_cn',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''002'' AND KSd=0 AND chi_tiet=1'
go
exec sp_reset_connection 
-- Dien so tien
exec dbo.asGetSoDuKh @pMa_Cty=N'002',@pMa_kh=N'CONGTY',@pTk=N'331',@pNgay='2026-03-30 00:00:00'
go
-- Luu phieu bao no
exec sp_reset_connection 
go
exec asValid @pMa_Cty=N'002',@pCodeName=N'TK',@pCodeValue=N'11211',@pFieldList=N'TEN_TK',@pTableName=N'GLDMTK',@pWhere=N'Ma_Cty=''002'' AND KSd=0 AND chi_tiet=1'
go
exec sp_reset_connection 
go
exec asValid @pMa_Cty=N'002',@pCodeName=N'MA_KH',@pCodeValue=N'CONGTY',@pFieldList=N'ten_kh,dia_chi,nguoi_gd,ma_httt_po',@pTableName=N'ARDMKH',@pWhere=N'Ma_Cty=''002'' AND KSd=0'
go
exec sp_reset_connection 
go
exec asSiGetSetupByName @pMa_Cty=N'002',@pTen_bien=N'ngay_ks'
go
exec sp_reset_connection 
go
declare @p6 float
set @p6=0
exec asChkSoCt @pMa_Cty=N'002',@pMa_Ct=N'CA4',@pStt_Rec=N'0',@pSo_ct=N'00001',@pNgay_ct='2026-03-30 00:00:00',@pRet=@p6 output
select @p6
go
exec sp_reset_connection 
go
declare @p3 nvarchar(20)
set @p3=N'002wCA40000000688516'
exec asGetSttRec @pMa_cty=N'002',@pMa_Ct=N'CA4',@pStt_Rec=@p3 output
select @p3
go
exec sp_reset_connection 
go
exec asGetStoredProcedureParameters @spName=N'asCAInsPH2'
go
declare @p23 int
set @p23=0
exec asCAInsPH2 @pMa_cty=N'002',@pStt_rec=N'002wCA40000000688516',@pMa_ct=N'CA4',@pSo_ct=N'00001',@pNgay_ct='2026-03-30 00:00:00',@pNgay_lct='2026-03-30 00:00:00',@pKht_tain=0,@pMa_kh=N'CONGTY',@pDia_chi=N'',@pNguoi_gd=N'',@pDien_giai=N'',@pTk_co=N'11211',@pMa_nt=N'VND',@pTy_gia=1,@pT_tien_nt=1000000,@pT_tien=1000000,@pT_Thue=0,@pT_Tt_nt=1000000,@pT_Tt=1000000,@pTrang_thai=N'',@pPost2gl=N'',@pLUser=N'DUCTN',@pRet=@p23 output
select @p23
go
exec sp_reset_connection 
go
exec asGetStoredProcedureParameters @spName=N'asCAInsCT2'
go
declare @p17 int
set @p17=0
exec asCAInsCT2 @pMa_cty=N'002',@pStt_rec=N'002wCA40000000688516',@pStt_rec0=N'001',@pTk=N'331',@pPs_no=1000000,@pPs_co=0,@pPs_no_nt=1000000,@pPs_co_nt=0,@pDien_giai=N'',@pMa_kh=N'CONGTY',@pMa_ku=N'',@pMa_lo=N'',@pMa_bp=N'',@pMa_hd=N'',@pMa_phi=N'',@pMa_spct=N'',@pRet=@p17 output
select @p17
go
exec asProcessCt @pMa_cty=N'002',@pMa_Ct=N'CA4',@pStt_rec=N'002wCA40000000688516',@pMode=N'1'
go
-- Xoa phieu bao no
exec sp_reset_connection 
go
exec asSiGetSetupByName @pMa_Cty=N'001',@pTen_bien=N'ngay_ks'
go
declare @p4 int
set @p4=0
exec asCADelPH2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000698522',@pLUser=N'DUCTN',@pRet=@p4 output
select @p4
go