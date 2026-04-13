exec [diepxuan].[sys].[sp_procedure_params_100_managed] @procedure_name=N'asGLChuyenSdTk',@procedure_schema=N'dbo'

declare @p3 int
set @p3=0
exec dbo.asGLChuyenSdTk @pMa_cty=N'001',@pNgay_cnt='2026-12-31 00:00:00',@pRet=@p3 output
select @p3