exec sp_reset_connection 
go
exec asSiGetSetupByName @pMa_Cty=N'001',@pTen_bien=N'ngay_ks'
go
declare @p4 int
set @p4=0
exec asCADelPH2 @pMa_cty=N'001',@pStt_rec=N'001wCA40000000698522',@pLUser=N'DUCTN',@pRet=@p4 output
select @p4
go