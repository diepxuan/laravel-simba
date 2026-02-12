# Batch 2026-02-12 subagent-55

Danh sách các stored procedures đã chuyển đổi sang PHP class.

| Procedure | Class | Parameters | Description |
|-----------|-------|------------|-------------|
| asSIInsDMHTTT | AsSIInsDMHTTT | pMa_cty, pMa_httt, pModuleid, pTen_httt, pTk, pTk_thue_gtgt_mua, pTk_thue_gtgt_ban, pTk_thue_nk, pTk_thue_xk, pTk_gtgt_nk_no, pTk_gtgt_nk_co, pTk_thue_gtgt_xk, pTK_thue_ttdb, pTk_ck, pKsd, pLUser, pRet | ================================================ |
| asHrGetTDDeThi | AsHrGetTDDeThi | pMa_cty, pMa_yctd, pVong_so, pMa_mon_thi, pDe_so | ============================================= |
| asChkCodeExistsBeforeChange | AsChkCodeExistsBeforeChange | pMa_Cty, pTable_name, pCode_name, pOldValue, pNewValue, paramsdef | ----------------------------------------  |
| asINFilt3 | AsINFilt3 | pKeyPh, pKeyCt, pKeyct | ================================================ |
| asPostInPh5_FaCc | AsPostInPh5_FaCc | pMa_cty, pStt_rec | Post vao so cong cu |
| asCARptTMNH07 | AsCARptTMNH07 | pMa_cty, pTk, pMa_ku, pNgay_ctk, pNgay_cdk, pMa_nt | =================================================================== |
| asProcessSoPh5 | AsProcessSoPh5 | pMa_cty, pStt_rec, pMode, pstt_rec | AsiaSoft, Oct 25 2005  8:19AM |
| asINRptBKX01 | AsINRptBKX01 | pMa_cty, pNgay1, pNgay2, pGroupType, pCtu1, pCtu2, pMa_kh, pMa_NhKh, pMa_PlKh1, pMa_PlKh2, pMa_PlKh3, pMa_Hd, pMa_nx, pMa_kho, pMa_spct, pMa_bp, pLoai_px, pMa_Nt, pMa_vt, ptk_vt, pTk_Du, pDVT, pMa_Cty, pMa_nhkh, pMa_plkh1, pMa_plkh2, pMa_plkh3, pMa_Kh, pMa_nt | =================================== |
| asGetTygia | AsGetTygia | pMa_Cty, pMa_nt, pNgay_ct, pTy_gia, pMa_cty |  |
| asGLUpdDMDGTG | AsGLUpdDMDGTG | pMa_cty, pLoai_dg, pTk_dgtg, pStt, pTk_lai_cltg, pTk_lo_cltg, pTk_cltg_cn, pTen_bt, pDg_kh, pDg_bp, pDg_hd, pDg_spct, pDg_phi, pSo_ct, pKsd, pLUser, pRet | ================================================================================================ |
| asDelreportDrilldownInfo | AsDelreportDrilldownInfo | pMenuid, pMa_mau, pPress_key_name, pRet | ---------------------------------------------------------------- |
| asGLUpdMauBs | AsGLUpdMauBs | pma_cty, pQd_cdkt, pmau, pma_so, pchi_tieu, pcach_tinh, ptk, ptien0, ptien, ptien_nt0, ptien_nt, pstt, pbold, pin_ck, pts_nv, pcong_no, pngoai_bang, psodu_duong, pxtag, pxstt, ptm |  |
| asCoRptKHCPTT | AsCoRptKHCPTT | pMa_Cty, pNgay1, pNgay2, pMa_bpsd, pMa_cp, pTk_pb, pTk_cp, pMa_phi, pMa_spct, pMa_cty | ================================================= |
| asPOGetPH5 | AsPOGetPH5 | pMa_cty, pStt_rec, pMa_ct, pStruct | ================================================ |
| asGetInforNVL | AsGetInforNVL | pSo_lich_sx, pMa_vt, pNgay | select |
| asGetGroupRightMenu | AsGetGroupRightMenu | pGroupName | AsiaSoft, Aug 22 2005  9:09AM |
| asPOChkRightStatusPO3 | AsPOChkRightStatusPO3 | pMa_cty, pStt_rec, pLanguage | Kiem tra trang thai chung tu truoc khi sua/xoa |
| asInsDictionaryComplexResx | AsInsDictionaryComplexResx | pCode_name, pLanguage, pFormated_col_list, pViewform_size, pRet | ----*/ |
| asGLRptNKCTSoCai | AsGLRptNKCTSoCai | pMa_cty, pNgay1, pNgay2, pTk, pThang1, pThang2, pNam | ----------------------------------------------- |
| asSiDelUpdateLogCT | AsSiDelUpdateLogCT | pId, pRet | 0: duoc xoa, 1 - khong xoa |
| asPostGlPh1_glct_1n | AsPostGlPh1_glct_1n | pMa_cty, pSTT_rec, pNh_dk, pNamTC, pThangTC, pNgay_ct, pMa_nt0, pStt_rec, pma_cty, pnh_dk, pstt_rec | AsiaSoft, Nov 11 2005 |
| asSIUpdDMHTTT | AsSIUpdDMHTTT | pMa_cty, pMa_httt, pModuleid, pTen_httt, pTk, pTk_thue_gtgt_mua, pTk_thue_gtgt_ban, pTk_thue_nk, pTk_thue_xk, pTk_gtgt_nk_no, pTk_gtgt_nk_co, pTk_thue_gtgt_xk, pTK_thue_ttdb, pTk_ck, pKsd, pLUser, pRet | ================================================ |
| asUpdSysVar | AsUpdSysVar | pMa_cty, pPhan_he, pFieldName, pValue, params | ========================================================= |
| asINRptCTVT02_crys | AsINRptCTVT02_crys | pMa_cty, pNgay1, pNgay2, pXml, pMa_vt, pMa_kho, pMa_vitri, pMau_bc, pMa_nt, pSysMsg1, pSysMsg2, pSysMsg3, pma_vt | Duongvm	 |
| asHrInsChamCongKhac | AsHrInsChamCongKhac | pMa_cty, pNam, pThang, pNgay, pId, pMa_cham_cong, pKh_cham_cong, pGio_vao, pPhut_vao, pGio_ra, pPhut_ra, pThem_gio, pCuser, pRet | ============================================= |
| asSIDelDMBP | AsSIDelDMBP | pMa_cty, pMa_bp, pRet | ================================================ |
| asPORptF5TH02 | AsPORptF5TH02 | pma_cty, pLoai, pMa_ct, pThang, pNam, pSo_ky, pMa_nt, pMa_vt, pKy | ============================================= |
| asGetReportDrilldownInfo | AsGetReportDrilldownInfo | pMenuID |  |
| asHrDelQTNghiCheDo | AsHrDelQTNghiCheDo | pMa_cty, pId, pId_qtncd, pRet | ============================================= |
| asInGetSetup | AsInGetSetup | pMa_Cty | AsiaSoft, Sep  9 2005  9:23AM |

## Chi tiết từng procedure

### asSIInsDMHTTT

```sql
-- ================================================
-- asSIInsDMHTTT
-- Created by: TRANGNT
-- Created date: Dec 17 2009 10:36PM
-- ================================================
CREATE PROCEDURE [dbo].[asSIInsDMHTTT] 		@pMa_cty	nvarchar(3),	@pMa_httt	nvarchar(20),	@pModuleid	nvarchar(2),	@pTen_httt	nvarchar(50),	@pTk	nvarchar(20),	@pTk_thue_gtgt_mua	nvarchar(20),	@pTk_thue_gtgt_ban	nvarchar(20),	@pTk_thue_nk	nvarchar(20),	@pTk_thue_xk	nvarchar(20),	@pTk_gtgt_nk_no	nvarchar(20),	@pTk_gtgt_nk_co	nvarchar(20),	@pTk_thue_gtgt_xk	nvarchar(20),	@pTK_thue_ttdb	nvarchar(20),	@pTk_ck nvarchar(20),	@pKsd	bit,	@pLUser	nvarchar(20),	@pRet	int output
AS 

IF EXISTS (SELECT 1 FROM SIDMHTTT WHERE ma_cty=@pMa_cty AND moduleid=@pModuleid AND ma_httt=@pMa_httt) BEGIN
	SET @pRet=50011
	RETURN
END

	Insert SIDMHTTT(
		ma_cty,		ma_httt,		moduleid,		ten_httt,		tk,		tk_thue_gtgt_mua,		tk_thue_gtgt_ban,		tk_thue_nk,		tk_thue_xk,		tk_gtgt_nk_no,		tk_gtgt_nk_co,		tk_thue_gtgt_xk,		tk_thue_ttdb,		Tk_ck,		ksd,		cdate,		cuser,		ldate,		luser)
	Values (
		@pMa_cty,		@pMa_httt,		@pModuleid,		@pTen_httt,		@pTk,		@pTk_thue_gtgt_mua,		@pTk_thue_gtgt_ban,		@pTk_thue_nk,		@pTk_thue_xk,		@pTk_gtgt_nk_no,		@pTk_gtgt_nk_co,		@pTk_thue_gtgt_xk,		@pTK_thue_ttdb,		@pTk_ck,		@pKsd,		getdate(),		@pLUser,		getdate(),		@pLUser)	Set @pRet = @@error

GO


```

### asHrGetTDDeThi

```sql
-- =============================================
-- Author:		HieuLQ
-- Create date: 01/07/2014
-- Description:	Lấy đề thi tuyển dụng
-- =============================================
CREATE PROCEDURE [dbo].[asHrGetTDDeThi] 
	@pMa_cty NVARCHAR(3) = '001',
	@pMa_yctd NVARCHAR(20) = '',
	@pVong_so NVARCHAR(3) = '',
	@pMa_mon_thi NVARCHAR(20) = '',
	@pDe_so NVARCHAR(50) = ''
AS
BEGIN
	IF @pMa_yctd IS NULL
	    SET @pMa_yctd = ''
	
	IF @pVong_so IS NULL
	    SET @pVong_so = ''
	
	IF @pMa_mon_thi IS NULL
	    SET @pMa_mon_thi = ''
	
	IF @pDe_so IS NULL
	    SET @pDe_so = ''
	
	SELECT *
	FROM   HrTDDeThi
	WHERE  Ma_cty = @pMa_cty
	       AND Ma_yctd = @pMa_yctd
	       AND Vong_so LIKE @pVong_so + '%'
	       AND Ma_mon_thi LIKE @pMa_mon_thi + '%'
	       AND De_so LIKE @pDe_so + '%'
END

GO


```

### asChkCodeExistsBeforeChange

```sql
------------------------------------------ 
-- Kiem tra ton tai ma trong danh muc
-- Dung cho cac thu tuc Ins Danh muc
-- Chi dung cho cac danh muc co 1 truong ma (Khach hang, Vat tu, Hop dong, Bo phan, Kho...
-- Goi truc tiep tu Base - FrameWork.dll
-- Created by ChinhVD - 7/12/2012
------------------------------------------
-- <Table_name> : Ten table
-- <Code_name> : ten truong kiem tra
-- <Code_value> : Gia tri cua truong can kiem tra
-- <OldCode_value> : Gia tri cu
------------------------------------------
-- [asChkCodeExistsBeforeChange] '100','ardmkh','ma_kh','3333','333'
CREATE proc [dbo].[asChkCodeExistsBeforeChange] 
(
	@pMa_Cty nvarchar(3),
	@pTable_name sysname,
	@pCode_name sysname,
	@pOldValue nvarchar(20),
	@pNewValue nvarchar(20)
)
as
BEGIN
	IF @pTable_name = 'GLDMTK' SET @pOldValue = ''
	
	declare @sql nvarchar(512), @paramsdef nvarchar(100),@Ret int
	if @pOldValue <> ''
	begin
		set @sql = 'SELECT @count=count(' + @pCode_name + ') FROM ' + @pTable_name 
				+ ' WHERE (' + @pCode_name + ' LIKE @value + ''%'' OR ''' + @pNewValue + ''' LIKE ' + @pCode_name + '+''%'')'  
				+ ' AND ' + @pCode_name + ' <> @oldValue '   
				+ ' AND ma_cty=' + '''' + @pMa_Cty + '''' 
	end
	else
	begin
		set @sql = 'SELECT @count=count(' + @pCode_name + ') FROM ' + @pTable_name 
				+ ' WHERE ' + @pCode_name + ' = @value ' 
				+ ' AND ma_cty=' + '''' + @pMa_Cty + '''' 
	end
	PRINT @sql
	set @paramsdef = '@value sysname, @oldValue sysname, @count int output'
	exec sp_executesql @sql,@paramsdef, @value=@pNewValue, @oldValue=@pOldValue, @count=@Ret OUT
	
	select @Ret
	
END

GO


```

### asINFilt3

```sql
-- ================================================
-- asInFilt3
-- Created by: TRANGNT
-- Created date: Jan 17 2010  6:57PM-- ================================================

CREATE PROCEDURE [dbo].[asINFilt3]
    @pKeyPh   nvarchar(1000),
    @pKeyCt   nvarchar(1000)
AS 
Declare @sqlStr nvarchar(4000)

set @sqlStr = 'Select 	cast(0 as bit) as chon,
	p.ma_cty,    p.stt_rec,    p.ma_ct,    p.ma_gd,    p.ngay_ct,    p.ngay_lct,    p.so_ct,    p.so_pn,
    p.PX_GDD,    p.ma_kh,
    dmkh.ten_kh,
    dmkh.Dia_chi,
    dmkh.Ma_so_Thue,
    dmkh.Gh_No,    p.nguoi_gd,    p.dien_giai,      p.ma_nx,    p.t_so_luong,    p.ma_nt,    p.ty_gia,    p.t_tien_nt,    p.t_tien,       p.post2gl,    p.post2in,    p.cdate,    p.cuser,    p.ldate,    p.luserfrom  InPh3 p
left join ardmkh dmkh on dmkh.ma_cty=p.ma_cty and dmkh.ma_kh=p.ma_kh ' 

set @sqlstr =	@sqlStr + ' where stt_rec in (select stt_rec from InCT3 where ' + @pKeyct + 
				' and stt_rec in (select stt_rec from InPH3 where ' + @pKeyPh + '))'

set @sqlStr = @sqlStr + ' order by ngay_ct, so_ct '
-- PH
exec sp_executesql @sqlstr

-- CT
set @sqlStr = 'Select
		c.ma_cty,    c.stt_rec,    c.stt_rec0,    c.ma_khon,
    dmkhoN.Ten_kho as ten_khon,
    dmkhoN.dia_chi as dia_chin,
    c.ma_khox,
    dmkhoX.Ten_kho as ten_khox,
    dmkhoX.dia_chi as dia_chix,
    c.ma_vitrin as ma_vitrin,
    dmvitrin.ten_vitri as ten_vitrin,
    c.ma_vitrix as ma_vitrix,
    dmvitrix.ten_vitri as ten_vitrix,
    c.ma_lo,
    dmlo.ten_lo,    c.ma_nx,	c.tk_no,	tkno.ten_tk as ten_tk_no,	c.tk_vt,	tkvt.ten_tk as ten_tk_vt,    c.ma_spct,
    dmspct.ten_spct,    c.ma_vt,
    c.ten_vt,
    c.dvt,    vt.gia_ton,    c.ma_bp,
    dmbp.ten_bp,    c.ma_phi,
    dmphi.ten_phi,    c.ma_hd,    hd.ten_hd,    c.so_luong,	c.so_luong_qd,    c.gia_nt,    c.gia,    c.tien_nt,    c.tien,	cast(0 as decimal(19,4)) as tonx,	cast(0 as decimal(19,4)) as tonx_mua,	cast(0 as decimal(19,4)) as tonx_ban,	cast(0 as decimal(19,4)) as tonn,	cast(0 as decimal(19,4)) as tonn_mua,	cast(0 as decimal(19,4)) as tonn_ban,	cast(0 as decimal(19,4)) as ton_all,	cast(0 as decimal(19,4)) as ton_mua_all,	cast(0 as decimal(19,4)) as ton_ban_all    		   		from  InCt3 c
left join indmvt vt on c.ma_cty = vt.ma_cty and c.ma_vt = vt.ma_vt
left join InDmVt dmvt on dmvt.ma_cty = c.ma_cty and dmvt.ma_vt = c.ma_vt
left join SiDmBp dmbp on dmbp.ma_cty = c.ma_cty and dmbp.ma_bp = c.ma_bp
left join InDmKho dmkhon on dmkhon.ma_cty = c.ma_cty and dmkhon.ma_kho = c.ma_khon
left join InDmKho dmkhox on dmkhox.ma_cty = c.ma_cty and dmkhox.ma_kho = c.ma_khox
left join gldmtk tkvt on c.ma_cty = tkvt.ma_cty and c.tk_vt = tkvt.tkleft join gldmtk tkno on c.ma_cty = tkno.ma_cty and c.tk_no = tkno.tk
left join SiDmPhi dmphi on dmphi.ma_cty = c.ma_cty and dmphi.ma_phi = c.ma_phi
left join sidmhd hd on c.ma_cty = hd.ma_cty and c.ma_hd = hd.ma_hd
left join CoDmSpct dmspct on dmspct.ma_cty = c.ma_cty and dmspct.ma_spct = c.ma_spct
left join InDmVitri dmvitrin on dmvitrin.ma_cty = c.ma_cty and dmvitrin.ma_vitri = c.ma_vitrin  and dmvitrin.ma_kho=c.ma_khon
left join InDmVitri dmvitrix on dmvitrix.ma_cty = c.ma_cty and dmvitrix.ma_vitri = c.ma_vitrix and dmvitrix.ma_kho=c.ma_khox
left join InDmLo dmLo on dmLo.ma_cty = c.ma_cty and dmLo.ma_lo = c.ma_lo
left join siDmhttt dmnx on dmnx.ma_cty=c.ma_cty and dmnx.ma_httt=c.ma_nx and dmnx.moduleid=''IN'' '
set @sqlstr =	@sqlStr + ' where stt_rec in (select stt_rec from InCT3 where ' + @pKeyct + 
					' and stt_rec in (select stt_rec from InPH3 where ' + @pKeyPh + '))'

set @sqlStr = @sqlStr + ' order by stt_rec, stt_rec0 '

-- CT
exec sp_executesql @sqlstr

GO


```

### asPostInPh5_FaCc

```sql
-- Post vao so cong cu
-- Created by TrangNt on Sep  8 2008
-- Post inPh5 -> Facc

CREATE proc [dbo].[asPostInPh5_FaCc]

	@pMa_cty nvarchar(3),
	@pStt_rec  nvarchar(20)

AS

if (select ngay_ct from inPh5 where ma_cty = @pMa_cty and stt_rec = @pStt_rec) <= (select ngay_ks from siSetup where ma_cty = @pMa_Cty)
	begin 
		return 
	end

Delete FaDmCc where ma_cty = @pMa_cty and stt_rec = @pStt_rec and tg=1
insert into FaDmcc(
	ma_cty,
	ma_cc,
	moduleid,
	stt_rec,
	stt_rec0,
	ten_cc,
	dvt,
	so_luong,
	don_gia,
	ng_gia,
	gt_da_kh,
	gt_cl,
	so_ct,
	ngay_ct,
	ngay_gt_cl,
	ngay_bdkh,
	ma_bpsd,
	ma_spct,
	ma_phi,
	tk_cc,
	tk_cp,
	ky_pb,
	so_ky,
	kh_ky,
	is_giam,
	tinh_kh,
	cdate,
	cuser,
	ldate,
	luser,
	ksd,
	tg)
select
	p.ma_cty,
	c.ma_vt as ma_cc,
	'IN' as moduleid,
	c.stt_rec,
	c.stt_rec0,
	c.ten_vt as ten_cc,
	c.dvt,
	c.so_luong,
	c.gia as don_gia,
	c.tien as ng_gia,
	0 as gt_da_kh,
	c.tien as gt_cl,
	p.so_ct,
	p.ngay_ct,
	p.ngay_ct as ngay_gt_cl,
	p.ngay_ct as ngay_bdkh,
	c.ma_bpsd,
	c.ma_spct,
	c.ma_phi,
	c.tk_no as tk_cc,
	c.tk_cp as tk_cp,
	1 as ky_pb,--c.ky_pb,
	c.so_ky,
	round(c.tien/case c.so_ky when 0 then 1 else c.so_ky end,0) as kh_ky,
	'0' as is_giam,
	'1' as tinh_kh,
	p.cdate,
	p.cuser,
	p.ldate,
	p.luser,
	'0' as ksd,
	1 as tg
from inPh5 p, InCt5 c
where	p.ma_cty = @pMa_cty and
	p.stt_rec = @pStt_rec and
	p.ma_cty = c.ma_cty and
	p.stt_rec = c.stt_rec

select @@error

GO


```

### asCARptTMNH07

```sql
-- ===================================================================
-- Created by:		HIEULQ
-- Created date:	11/2012
-- Description:		Bảng cân đối phát sinh các khế ước
-- [asCARptTMNH07] 'Q15', '311', '', '01/01/2012', '12/31/2012'
-- ===================================================================
CREATE PROCEDURE [dbo].[asCARptTMNH07]
	@pMa_cty NVARCHAR(3),
	@pTk NVARCHAR(20) = '',
	@pMa_ku NVARCHAR(20) = '',
	@pNgay_ctk SMALLDATETIME,
	@pNgay_cdk SMALLDATETIME,
	@pMa_nt NVARCHAR(3) = ''
AS
BEGIN
	SELECT
		ma_cty,
		ma_ku,
		ten_ku,
		tk,
		ma_nt,
		SUM(Du_no) AS No_dk,
		SUM(Du_co) AS Co_dk,
		SUM(Du_no_nt) AS No_dk_nt,
		SUM(Du_co_nt) AS Co_dk_nt,
		SUM(PS_no) AS PS_no,
		SUM(PS_co) AS PS_co,
		SUM(PS_no_nt) AS PS_no_nt,
		SUM(PS_co_nt) AS PS_co_nt,
		CASE WHEN SUM(Du_no) - SUM(Du_co) + SUM(PS_no) - SUM(PS_co) > 0 THEN SUM(Du_no) - SUM(Du_co) + SUM(PS_no) - SUM(PS_co)
			 ELSE 0 END AS No_ck,
		CASE WHEN SUM(Du_co) - SUM(Du_no) + SUM(PS_co) - SUM(PS_no) > 0 THEN SUM(Du_co) - SUM(Du_no) + SUM(PS_co) - SUM(PS_no)
			 ELSE 0 END AS Co_ck,
		CASE WHEN SUM(Du_no_nt) - SUM(Du_co_nt) + SUM(PS_no_nt) - SUM(PS_co_nt) > 0 THEN SUM(Du_no_nt) - SUM(Du_co_nt) + SUM(PS_no_nt) - SUM(PS_co_nt)
			 ELSE 0 END AS No_ck_nt,
		CASE WHEN SUM(Du_co_nt) - SUM(Du_no_nt) + SUM(PS_co_nt) - SUM(PS_no_nt) > 0 THEN SUM(Du_co_nt) - SUM(Du_no_nt) + SUM(PS_co_nt) - SUM(PS_no_nt)
			 ELSE 0 END AS Co_ck_nt
	INTO #KQ
	FROM
	(
		--Tính phát sinh đầu kỳ
		SELECT
			c.ma_cty,
			c.ma_ku,
			c.ten_ku,
			a.Tk,
			c.Ma_nt,
			a.Du_no,
			a.Du_co,
			a.Du_no_nt,
			a.Du_co_nt,
			0 AS PS_no,
			0 AS PS_co,
			0 AS PS_no_nt,
			0 AS PS_co_nt
		FROM
			[afDuDauTkKu] (@pMa_cty, @pTk, @pMa_ku, @pNgay_ctk, @pMa_nt) a
				INNER JOIN cadmku c ON c.ma_cty = @pMa_cty AND a.ma_ku = c.ma_ku
		
		UNION ALL
		
		--Tính phát sinh trong kỳ
		SELECT 
			g.ma_cty,
			g.ma_ku,
			c.ten_ku,
			g.tk,
			g.ma_nt,
			0 AS Du_no,
			0 AS Du_co,
			0 AS Du_no_nt,
			0 AS Du_co_nt,
			SUM(g.ps_no) AS PS_no,
			SUM(g.ps_co) AS PS_co,
			SUM(g.ps_no_nt) AS PS_no_nt,
			SUM(g.ps_co_nt) AS PS_co_nt
		FROM glct g INNER JOIN cadmku c
			ON g.ma_cty = c.ma_cty AND c.ma_ku = g.ma_ku
		WHERE g.ma_cty = @pMa_cty
			AND c.ma_ku LIKE @pMa_ku + '%'
			AND g.tk LIKE @pTk + '%'
			AND c.ma_nt LIKE @pMa_nt + '%'
			AND g.ngay_ct BETWEEN @pNgay_ctk AND @pNgay_cdk
		GROUP BY g.ma_cty, g.ma_ku, c.ten_ku, g.tk, g.ma_nt, g.nam
	) a
	GROUP BY a.ma_cty, a.ma_ku, a.ten_ku, a.tk, a.ma_nt

	-- Kết quả
	SELECT * FROM #KQ
END

GO


```

### asProcessSoPh5

```sql
-- AsiaSoft, Oct 25 2005  8:19AM
-- Created by LocPv
-- Process soPh1

CREATE PROCEDURE [dbo].[asProcessSoPh5]

	@pMa_cty nvarchar(3),
	@pStt_rec nvarchar(20),
	@pMode	nvarchar(1)  -- 1-Moi, 2-Sua

AS
	if @pMode = '1' or @pMode = '2'
		begin
			-- post vao so cai ngay sau khi luu chung tu 
			if (select postafsave from siSetUp where ma_cty = @pMa_cty) = '1'
				exec asPostSoPh5_glct @pma_cty, @pstt_rec

			-- post vao so ban hang
			exec asPostSoPh5_SoCt @pma_cty, @pstt_rec
		
			-- post vao so phai thu
			exec asPostSoPh5_artt @pma_cty, @pstt_rec

			-- Cap nhat so du
			exec asARUpdTt_SoDuSo5 @pma_cty, @pstt_rec
		
			-- post vao so thue VAT
			exec asPostSoPh5_taout @pma_cty, @pstt_rec

			-- so du tuc thoi
			declare @nam int
			declare @ma_kh nvarchar(20)
			select @nam = year(ngay_ct), @ma_kh = ma_kh from soph5 where ma_cty = @pMa_cty and stt_rec = @pStt_rec
			exec asArRecalCustBalance @pMa_cty, @ma_kh, @nam
			
		end

GO


```

### asINRptBKX01

```sql
-- ===================================
-- asINRptBKX01: Bảng kê phiếu xuất kho
-- Created by: TRANGNT
-- Created date: Dec 17 2009  9:10AM
-- ===================================
CREATE PROCEDURE [dbo].[asINRptBKX01] 
	@pMa_cty	nvarchar(3),
	@pNgay1		smalldatetime,
	@pNgay2		smalldatetime,	
	@pGroupType	nvarchar(128),
	@pCtu1		nvarchar(12)	='',
	@pCtu2		nvarchar(12)	='',
	@pMa_kh		nvarchar(20)	='',	
	@pMa_NhKh	nvarchar(8)		='',	
	@pMa_PlKh1	nvarchar(20)	='',	
	@pMa_PlKh2	nvarchar(20)	='',	
	@pMa_PlKh3	nvarchar(20)	='',	
	@pMa_Hd		nvarchar(20)	='',	
	@pMa_nx		nvarchar(20)	='',
	@pMa_kho	nvarchar(8)		='',
	@pMa_spct	nvarchar(20)	='',
	@pMa_bp		nvarchar(20)	='',	
	@pLoai_px	nvarchar(3)		='',
	@pMa_Nt		nvarchar(3)		='',
	@pMa_vt		nvarchar(20)	='',
	@PMa_nhvt	nvarchar(8)		='',
	@ptk_vt		nvarchar(20)	='',
	@pTk_Du		nvarchar(20)	='',
	@pDVT		nvarchar(1)		='' --0 chung tu / 1 kho / 2 mua / 3 ban

as
	If isnull(@pCtu1, '') = ''
		set @pCtu1 = SPACE(12)
	If isnull(@pCtu2, '') = ''
		set @pCtu2 = 'zzzzzzzzzzzz'

	--Danh muc vat tu
	select ma_cty, ma_vt,dvt,dvt_ban,dvt_mua,hs_Dvtmua,hs_Dvtban,ten_vt
		into #indmvt 
		from indmvt 
	where ma_Cty like @pMa_Cty + '%' and
		ma_vt like @pMa_vt + '%' and
		ma_nhvt in (select ma_nhvt from dbo.afInGetInNhvtSubtree(@pMa_cty,@PMa_nhvt)) --Dieu kien ma nhom vat tu
		and ton_kho = '1'
		
	--Danh muc khach hang
	select ma_cty, ma_kh,ten_kh
		into #ardmkh 
		from ardmkh 
	where ma_Cty like @pMa_Cty + '%' and
		ma_kh like @pMa_kh + '%' and
		ma_nhkh like @pMa_nhkh + '%' and
		ma_plkh1 like @pMa_plkh1 + '%' and
		ma_plkh2 like @pMa_plkh2 + '%' and
		ma_plkh3 like  @pMa_plkh3 + '%' 
	
	if @pMa_Kh = ''
		insert into #ardmkh (ma_cty, ma_kh,ten_kh) values (@pma_Cty, '', '')
		
	--Phần thông tin chung				
	SELECT
		s.stt_rec,
		s.ma_ct,
		s.ma_kh,
		s.so_ct,
		s.ngay_ct,
		s.dien_giai,
		s.tk_du,
		s.ma_vt,
		s.gia_nt,
		s.gia,
		s.tien_xuat_nt,
		s.tien_xuat,
		s.ten_vt,
		s.dvt,
		v.Dvt as Dvt_kho,
		isnull(v.Dvt_ban,s.dvt) as Dvt_ban,
		isnull(v.Dvt_mua,s.dvt) as Dvt_mua,
		s.ma_kho,
		s.ma_nt,
		s.ty_gia,
		isnull(s.sl_xuat_qd,0) as sl_xuat_qd,
		s.ma_spct
	INTO #BKPX
	FROM inct s 
		inner join #indmvt v on s.ma_cty=v.ma_cty and s.ma_vt=v.ma_vt
		inner join #ardmkh kh on s.ma_cty = kh.ma_cty and s.ma_kh = kh.ma_kh  
	WHERE
		s.ma_cty like @pMa_cty + '%' and		
		s.ngay_ct between @pNgay1 and @pNgay2 and	
		s.so_ct between @pCtu1 and @pCtu2  and
		s.ma_ct like @pLoai_px + '%' and
		s.ma_nt like @pMa_nt + '%' and
		s.tk_vt like @ptk_vt +'%' and
		s.nxt=2 and
		s.ma_kh like @pMa_kh + '%' and
		s.ma_kho like @pMa_kho + '%' and
		s.ma_bp like @pMa_bp + '%' and			
		s.ma_nx like @pMa_nx +'%'and	
		s.tk_du like @pTk_Du + '%'  and  
		s.ma_hd like @pMa_Hd + '%' AND
		s.ma_spct like @pMa_spct + '%' 

	--Kết quả cho Master
	SELECT
		s.stt_rec,
		s.ma_ct,
		s.ma_kh,
		s.so_ct,
		s.ngay_ct,
		s.dien_giai,
		SUM(s.tien_xuat) as tien_xuat,
		SUM(s.tien_xuat_nt) as tien_xuat_nt,
		SUM(s.sl_xuat_qd) as so_luong,
		s.ma_nt,
		s.ty_gia, 	
		isnull(c.ten_kh,'') AS ten_kh
	FROM #BKPX s
		left join (select ma_kh,ten_kh from #ardmkh WHERE ma_cty LIKE @pMa_cty + '%') c on s.ma_kh=c.ma_kh 
	GROUP BY s.stt_rec,
		s.ma_ct,
		s.ma_kh,
		s.so_ct,
		s.ngay_ct,
		s.dien_giai,s.ma_nt,
		s.ty_gia,c.ten_kh
	ORDER BY  s.ngay_ct,s.so_ct	
			
	--Phân thông tin chi tiết
	SELECT
		s.stt_rec,
		s.ma_ct,
		s.ma_kh,
		isnull(c.ten_kh,'') AS ten_kh,
		s.so_ct,
		s.ngay_ct,
		s.dien_giai,
		s.ma_nx,
		isnull(i.ten_nx,'') as ten_nx,	
		s.tk_du,
		s.ma_vt,
		isnull(s.gia_nt,0) as gia_nt,
		isnull(s.gia,0) as gia,
		isnull(s.tien_xuat_nt,0) as tien_xuat_nt,
		isnull(s.tien_xuat,0) as tien_xuat,
		s.ten_vt,
		s.dvt,
		v.Dvt as Dvt_kho,
		isnull(v.Dvt_ban,s.dvt) as Dvt_ban,
		isnull(v.Dvt_mua,s.dvt) as Dvt_mua,
		s.ma_kho,
		s.ma_nt,
		s.ty_gia,
		isnull(s.sl_xuat_qd,0) as so_luong,
		s.ma_spct,
		s.tk_vt,
		s.ma_vitri,
		s.ma_lo,
		s.ma_bp,
		s.ma_phi
	FROM inct s 
		inner join #indmvt v on s.ma_cty=v.ma_cty and s.ma_vt=v.ma_vt
		left join (select ma_kh,ten_kh from #ardmkh WHERE ma_cty LIKE @pMa_cty + '%') c on s.ma_kh=c.ma_kh 
		left join (select ma_nx,ten_nx from indmnx WHERE ma_cty like @pMa_cty + '%') i on  s.ma_nx=i.ma_nx
	WHERE
		s.ma_cty like @pMa_cty + '%' and		
		s.ngay_ct between @pNgay1 and @pNgay2 and	
		s.so_ct between @pCtu1 and @pCtu2  and
		s.ma_ct like @pLoai_px + '%' and
		s.ma_nt like @pMa_nt + '%' and
		s.tk_vt like @ptk_vt +'%' and
		s.nxt=2 and
		s.ma_kh like @pMa_kh + '%' and
		s.ma_kho like @pMa_kho + '%' and
		s.ma_bp like @pMa_bp + '%' and			
		s.ma_nx like @pMa_nx +'%'and	
		s.tk_du like @pTk_Du + '%'  and  
		s.ma_hd like @pMa_Hd + '%' AND
		s.ma_spct like @pMa_spct + '%' 
	ORDER BY  s.ngay_ct,s.so_ct

GO


```

### asGetTygia

```sql
CREATE PROCEDURE [dbo].[asGetTygia]
    @pMa_Cty   nvarchar(3),    @pMa_nt    nvarchar(3),
    @pNgay_ct  smalldatetime,
    @pTy_gia   DECIMAL(19,4) output 
AS 
	set @pTy_gia=(select top 1 isnull(ty_gia,0) as ty_gia
			 from sidmtgnt
			 where ma_cty = @pMa_cty and ma_nt = @pMa_nt and ngay_tg <= @pNgay_ct
			 order by ngay_tg desc)

	if @pTy_gia is null
		set @pTy_gia = 0

GO


```

### asGLUpdDMDGTG

```sql
-- ================================================================================================
-- Copyright©  2001-2010 by Asia Software Developement JSC, allrights reserved -- asGLUpdDMDGTG
-- Created by: TANVM
-- Created date: Aug 31 2010  3:27PM
-- ================================================================================================
CREATE PROCEDURE [dbo].[asGLUpdDMDGTG] 		@pMa_cty	nvarchar(3),	@pLoai_dg	nvarchar(1),	@pTk_dgtg	nvarchar(20),	@pStt		int,	@pTk_lai_cltg	nvarchar(20),	@pTk_lo_cltg	nvarchar(20),	@pTk_cltg_cn	nvarchar(20),	@pTen_bt	nvarchar(50),	@pDg_kh	bit,	@pDg_bp	bit,	@pDg_hd	bit,	@pDg_spct	bit,	@pDg_phi	bit,	@pSo_ct	nvarchar(12),	@pKsd	bit,	@pLUser	nvarchar(20),	@pRet	int output
AS 
	Update GLDMDGTG	set 		stt			= @pStt,		Tk_lai_cltg	= @pTk_lai_cltg,		Tk_lo_cltg	= @pTk_lo_cltg,		Tk_cltg_cn	= @pTk_cltg_cn,		Ten_bt	= @pTen_bt,		Dg_kh	= @pDg_kh,		Dg_bp	= @pDg_bp,		Dg_hd	= @pDg_hd,		Dg_spct	= @pDg_spct,		Dg_phi	= @pDg_phi,		So_ct	= @pSo_ct,		Ksd	= @pKsd,		Ldate	= getdate(),		Luser	= @pLUser	where Ma_cty = @pMa_cty and Loai_dg = @pLoai_dg and Tk_dgtg = @pTk_dgtg	Set @pRet = @@error

GO


```

### asDelreportDrilldownInfo

```sql
/*------------------------------------------------------------------
Copyright AsiaSoft, Jun  5 2012  2:42PM
Created by Duongvm
------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[asDelreportDrilldownInfo]
    @pMenuid NVARCHAR(8) ,
    @pMa_mau NVARCHAR(8) ,
    @pPress_key_name NVARCHAR(50) ,
    @pRet INT OUTPUT   -- 0: duoc xoa, 1 - khong xoa
AS 
    DELETE  sysreportDrilldownInfo
    WHERE   Menuid = @pMenuid
            AND Ma_mau = @pMa_mau
            AND Press_key_name = @pPress_key_name

    SET @pRet = @@ERROR   -- duoc xoa

GO


```

### asGLUpdMauBs

```sql
CREATE PROCEDURE [dbo].[asGLUpdMauBs]
    @pma_cty AS NVARCHAR(3) ,    
	@pQd_cdkt 	nvarchar(10),
    @pmau AS NVARCHAR(10) ,
    @pma_so AS NVARCHAR(8) ,
    @pchi_tieu AS NVARCHAR(70) ,
    @pcach_tinh AS NVARCHAR(255) ,
    @ptk AS NVARCHAR(20) ,
    @ptien0 AS DECIMAL(19, 4) ,
    @ptien AS DECIMAL(19, 4) ,
    @ptien_nt0 AS DECIMAL(19, 4) ,
    @ptien_nt AS DECIMAL(19, 4) ,
    @pstt AS INT ,
    @pbold AS BIT ,
    @pin_ck AS BIT ,
    @pts_nv AS BIT ,
    @pcong_no AS BIT ,
    @pngoai_bang AS BIT ,
    @psodu_duong AS BIT ,
    @pxtag AS INT ,
    @pxstt AS INT ,
    @ptm AS NVARCHAR(16)
AS 
    
    UPDATE  dbo.glmaubctc02
    SET     ma_cty = @pma_cty ,
            mau = @pmau ,
            so_qd = @pQd_cdkt ,
            ma_so = @pma_so ,
            chi_tieu = @pchi_tieu ,
            cach_tinh = @pcach_tinh ,
            tk = @ptk ,
            tien0 = @ptien0 ,
            tien = @ptien ,
            tien_nt0 = @ptien_nt0 ,
            tien_nt = @ptien_nt ,
            stt = @pstt ,
            bold = @pbold ,
            in_ck = @pin_ck ,
            ts_nv = @pts_nv ,
            cong_no = @pcong_no ,
            ngoai_bang = @pngoai_bang ,
            sodu_duong = @psodu_duong ,
            xtag = @pxtag ,
            xstt = @pxstt ,
            tm = @ptm
    WHERE   ( dbo.glmaubctc02.ma_cty = @pma_cty )
            AND ( dbo.glmaubctc02.mau = @pmau )
            AND ( dbo.glmaubctc02.ma_so = @pma_so )
            AND ( dbo.glmaubctc02.so_qd = @pQd_cdkt )

GO


```

### asCoRptKHCPTT

```sql
-- =================================================
-- Created by:		HIEULQ
-- Created date:	09/2012
-- Description:		Bảng tính khấu hao chi phí trả trước
-- [asCoRptKHCPTT] 'Q15', '01/01/2012', '12/31/2012', ''
-- =================================================
CREATE PROCEDURE [dbo].[asCoRptKHCPTT]
	@pMa_Cty NVARCHAR(3)='111',
	@pNgay1 SMALLDATETIME='20170101',
	@pNgay2 SMALLDATETIME='20170131',
	@pMa_bpsd NVARCHAR(20) = '',
	@pMa_cp NVARCHAR(20) = 'CP03',
	@pTk_pb NVARCHAR(20) = '',
	@pTk_cp NVARCHAR(20) = '',
	@pMa_phi NVARCHAR(20) = '',
	@pMa_spct NVARCHAR(20) = ''
AS
	IF @pMa_bpsd = ''
	    SET @pMa_bpsd = '%'
	IF @pMa_cp = ''
	    SET @pMa_cp = '%'
	IF @pTk_pb = ''
	    SET @pTk_pb = '%'
	IF @pTk_cp = ''
	    SET @pTk_cp = '%'
	IF @pMa_phi = ''
	    SET @pMa_phi = '%'
	IF @pMa_spct = ''
	    SET @pMa_spct = '%'
	
	SELECT a.ma_cptt,
	       b.ten_cptt,
	       b.tk_cptt,
	       b.tk_cp,
	       b.ngay_bdkh,
	       b.so_ky,
	       SUM(a.ng_gia) AS ng_gia,
	       SUM(a.gt_da_kh + a.pb_lk_dk) AS pb_lk_dk,
	       SUM(a.ng_gia - a.pb_lk_dk -a.gt_da_kh) AS cl_dk,
	       SUM(a.pb_tk) AS pb_tk,
	       SUM(a.pb_tk + a.pb_lk_dk + a.gt_da_kh) AS pb_lk_ck,
	       SUM(a.ng_gia - a.pb_lk_dk - a.pb_tk -a.gt_da_kh) AS cl_ck
	FROM   (
	           --Nguyên giá
	           SELECT ma_cptt,
	                  ma_cty,
	                  ng_gia,
	                  gt_da_kh,
	                  CAST(0 AS DECIMAL(19, 4)) AS pb_lk_dk,
	                  CAST(0 AS DECIMAL(19, 4)) AS pb_tk
			   FROM   codmcptt
	           WHERE  ma_cty = @pMa_cty
					  AND ma_cptt LIKE @pMa_cp + '%'
					  AND tk_cptt LIKE @pTk_pb + '%'
	                  AND tk_cp LIKE @pTk_cp + '%'
	                  AND ma_bpsd LIKE @pMa_bpsd + '%'
	                  AND ma_spct LIKE @pMa_spct + '%'
	                  AND ma_phi LIKE @pMa_phi + '%'
	                  AND ngay_bdkh <= @pNgay2
	           UNION ALL
	           -- Phân bổ luỹ kế đến đầu kỳ
	           SELECT ma_cptt,
	                  ma_cty,
	                  0,
	                  0,
	                  SUM(khau_hao) AS pb_lk_dk,
	                  0
			   FROM   cokhcptt
	           WHERE  ma_cty = @pMa_cty
					  AND ma_cptt LIKE @pMa_cp + '%'
	                  AND ma_bpsd LIKE @pMa_bpsd + '%'
	                  AND ma_spct LIKE @pMa_spct + '%'
	                  AND ma_phi LIKE @pMa_phi + '%'
	                  AND ((thang < MONTH(@pNgay1) and nam=YEAR(@pNgay1))or( nam <YEAR(@pNgay1)))
	                  --AND nam <= YEAR(@pNgay1)
	           GROUP BY
	                  ma_cptt,
	                  ma_cty
	           UNION ALL
	           -- Phân bổ trong kỳ
	           SELECT ma_cptt,
	                  ma_cty,
	                  0,
	                  0,
	                  0,
	                  SUM(khau_hao) AS pb_tk
	           FROM   cokhcptt
	           WHERE  ma_cty = @pMa_cty
	                  AND ma_cptt LIKE @pMa_cp + '%'
	                  AND ma_bpsd LIKE @pMa_bpsd + '%'
	                  AND ma_spct LIKE @pMa_spct + '%'
	                  AND ma_phi LIKE @pMa_phi + '%'
	                  AND thang >= MONTH(@pNgay1)
	                  AND nam = YEAR(@pNgay1)
	                  AND thang <= MONTH(@pNgay2)
	                  AND nam = YEAR(@pNgay2)
	           GROUP BY
	                  ma_cptt,
	                  ma_cty
	       ) a
	       LEFT OUTER JOIN codmcptt b
	            ON  a.ma_cty = b.ma_cty
	            AND a.ma_cptt = b.ma_cptt
	GROUP BY
		   b.tk_cptt,
		   b.tk_cp,
	       a.ma_cptt,
	       ten_cptt,
	       ngay_bdkh,
	       so_ky

GO


```

### asPOGetPH5

```sql
-- ================================================
-- asPOGetPH5
-- Created by: TRANGNT
-- Created date: Sep 17 2010  4:15PM-- ================================================
CREATE PROCEDURE [dbo].[asPOGetPH5] 	@pMa_cty	nvarchar(3) = null,	@pStt_rec	nvarchar(20) = null,	@pMa_ct	nvarchar(3) = null,	@pStruct nvarchar(1)='0'AS 	--If @pMa_cty	 is null set @pMa_cty = '%'	If @pStt_rec	 is null set @pStt_rec = '%'	If @pStruct is null set @pStruct = '0'	-- Loc chung tu cuoi cung, loc truoc khi join de tang toc do.
	Select top 1 * 
	into #POPH5
	from POPH5
	where ma_cty = @pMa_cty and ma_ct = @pMa_ct and stt_rec LIKE @pStt_rec + '%'
	order by ngay_ct desc, so_ct desc

	Select top 1		cast(0 as bit) as chon,		a.ma_cty,		a.stt_rec,		a.ma_ct,		a.ma_gd,		a.so_seri_mhd,		a.so_seri,		a.so_ct,		a.ngay_ct,		a.ngay_lct,		a.ma_kh,		a.ten_kh_vat,		a.dia_chi_vat,		a.ma_so_thue,		a.nguoi_gd,		a.ma_httt,		httt.ten_httt,		a.tk_pt,		a.tk_thue,		a.dien_giai,		a.ma_nt,		a.ty_gia,		a.t_tien,		a.t_tien_nt,		a.t_thue,		a.t_thue_nt,		a.t_tt,		a.t_tt_nt,		a.tao_tu_pn,		a.t_so_luong,
		a.gia_dd,		a.trang_thai,		a.post2gl,		a.post2in,		a.cdate,		a.cuser,		a.ldate,		a.luser	from  #POPH5 a	left join (select ma_cty,ma_httt,ten_httt from sidmhttt where ma_cty = @pMa_cty and moduleid = 'PO') httt on httt.ma_httt = a.ma_httt	--left join ardmkh kh on a.ma_cty = kh.ma_cty and a.ma_kh = kh.ma_kh	where 	a.Ma_cty = @pMa_cty and 
		a.Ma_ct = @pMa_ct and
		a.Stt_rec	like @pStt_rec + '%' and 
		@pStruct = '0'
	order by ngay_ct desc, so_ct desc

GO


```

### asGetInforNVL

```sql
CREATE proc [dbo].[asGetInforNVL]
@pSo_lich_sx nvarchar(50),
@pMa_vt nvarchar(50),
@pNgay smalldatetime
as
--select
--coph.ma_spct,
--(select ten_vt from indmvt where ma_vt = coph.ma_spct) as 'ten_spct',
-- co.ma_vt as 'Ma_vt',
-- it.ten_vt ,
-- it.dvt ,
-- co.so_luong as 'dinh_muc',
-- c1.so_luong,
-- co.so_luong*c1.so_luong as 'so_luong_cd',
-- cd.so_luong_ton as 'so_luong_ton'
-- --sum(co.so_luong*c1.so_luong) - cd.so_luong_ton as 'Số lượng cần nhập'
-- --into #slcd
-- from pmph1 p1 left join pmct1 c1 on p1.stt_rec = c1.stt_rec
--	left join codmbomph coph on c1.ma_vt = coph.ma_spct
--	left join codmbomct co on coph.ma_spct = co.ma_spct
--	left join indmvt it on it.ma_vt = co.ma_vt
--	left join PMCDVT cd on co.ma_vt = cd.ma_vt
--where p1.so_ct = @pSo_lich_sx  and c1.ma_vt in (select ma_spct from codmbomph)
--	  and co.ma_vt = @pMa_vt and xn_xuat = 0 
--	   and  ngay =  (select max(ngay) from pmcdvt where ngay < @pNgay )
--group by co.ma_vt,it.ten_vt,it.dvt,cd.so_luong_ton


select
coph.ma_spct,
(select ten_vt from indmvt where ma_vt = coph.ma_spct) as 'ten_spct',
 co.ma_vt ,
 it.ten_vt ,
 it.dvt,
 co.so_luong as 'dinh_muc',
 --co.so_luong,
 c1.so_luong,
 CAST(co.so_luong*c1.so_luong as decimal(19,4))as 'so_luong_cd',
c1.tong_lo,
c1.ma_lo
 into #slcd
 from pmph1 p1 left join pmct1 c1 on p1.stt_rec = c1.stt_rec
	left join codmbomph coph on c1.ma_vt = coph.ma_spct
	left join codmbomct co on coph.ma_spct = co.ma_spct
	left join indmvt it on it.ma_vt = co.ma_vt
where
	co.ma_vt = @pMa_vt
	 and p1.so_ct = @pSo_lich_sx  and c1.ma_vt in (select ma_spct from codmbomph)
	  and xn_xuat = 0
	  and  coph.ngay1 =  (select max(ngay1) from codmbomph where  ngay1 <= @pNgay and c1.ma_vt = ma_spct)
	 

--select * from #slcd
select
s.ma_spct,
s.ten_spct,
 s.ma_vt,
 s.ten_vt,
 s.dvt,
 s.dinh_muc,
 s.so_luong,
 s.so_luong_cd,
 isnull(p.so_luong_ton,0) as 'so_luong_ton',
 s.so_luong_cd - isnull(p.so_luong_ton,0) as 'sl_cn',
 s.tong_lo,
 s.ma_lo
 --(select isnull((select MAX(ngay) from PMCDVT where isnull(datediff(day,ngay,@pNgay),0) >=0 and ma_vt = s.ma_vt),p.ngay)),
 --p.ngay
 from #slcd s left join PMCDVT p on s.ma_vt = p.ma_vt
 where isnull(p.ngay,GETDATE()) = isnull((select MAX(ngay) from PMCDVT where isnull(datediff(day,ngay,@pNgay),0) >=0 and ma_vt = s.ma_vt),GETDATE())

GO


```

### asGetGroupRightMenu

```sql
-- AsiaSoft, Aug 22 2005  9:09AM
CREATE PROCEDURE [dbo].[asGetGroupRightMenu]
    @pGroupName NVARCHAR(20)
AS 
    SELECT  a.MenuID ,
            a.Bar ,
            a.BasicRight ,
            SUBSTRING(a.MenuID, 4, 2) AS LinkDetail ,
            SUBSTRING(a.MenuID, 1, 2) AS Link ,
            ISNULL(b.ViewRight, '0') AS ViewRight ,
            ISNULL(b.UpdateRight, '0') AS UpdateRight ,
            ISNULL(b.DeleteRight, '0') AS DeleteRight ,
            ISNULL(b.InsertRight, '0') AS InsertRight
    FROM    sysGroupRight b
            RIGHT JOIN sysMenu a ON a.MenuID = b.MenuID
                                 AND b.GroupName = @pGroupName
    WHERE   SUBSTRING(a.MenuId, 7, 2) <> '00'
            AND RTRIM(a.Bar) <> ''
    ORDER BY a.stt --a.MenuID

GO


```

### asPOChkRightStatusPO3

```sql
--Kiem tra trang thai chung tu truoc khi sua/xoa
CREATE proc [dbo].[asPOChkRightStatusPO3]
	@pMa_cty nvarchar(3),
	@pStt_rec nvarchar(20),
	@pLanguage nvarchar(5)='vi-VN'
as	
begin	
	declare @DateFormat int = 101
	if @pLanguage = 'vi-VN' set @DateFormat = 103

	declare @retMess nvarchar(128)
	--PO
	set nocount off	
	select top 1 @retMess=ma_ct + ' | ' + convert(nvarchar(20),ngay_ct,@DateFormat) + ' | ' + so_ct from poct where ma_cty = @pMa_cty and stt_rec_hd = @pStt_rec
	if @@rowcount>0 begin select @retMess; return end
	
	--APTT
	select @retMess=ma_ct + ' | ' + convert(nvarchar(20),ngay_ct,@DateFormat) + ' | ' + so_ct from aptt where ma_cty = @pMa_cty and stt_rec_hd = @pStt_rec
	if @@rowcount>0 begin select @retMess; return end
	
	--CA
	select top 1 ma_ct + ' | ' + convert(nvarchar(20),ngay_ct,@DateFormat) + ' | ' + so_ct as MessContent from caph2 where ma_cty = @pMa_cty and stt_rec_hd = @pStt_rec	
end

GO


```

### asInsDictionaryComplexResx

```sql
/*
Copyright AsiaSoft, May  4 2012  2:10PM
Created by Duongvm
------*/
CREATE PROCEDURE [dbo].[asInsDictionaryComplexResx]
    @pCode_name NVARCHAR(50) ,
    @pLanguage NVARCHAR(5) ,
    @pFormated_col_list NVARCHAR(4000) ,
    @pViewform_size VARCHAR ,
    @pRet INT OUTPUT
AS 
    INSERT  sysDictionaryComplexResx
            ( code_name ,
              language ,
              formated_col_list ,
              viewform_size
            )
    VALUES  ( @pCode_name ,
              @pLanguage ,
              @pFormated_col_list ,
              @pViewform_size
            )

-- catch error 
    SET @pRet = @@error

GO


```

### asGLRptNKCTSoCai

```sql
-------------------------------------------------
-- SO CAI - NHAT KY CHUNG TU
-- Created by LocPV
-- 16 Jul 2012
-- [asGLRptNKCTSoCai] '901', '01/01/2012','06/30/2012','111'
-------------------------------------------------
CREATE proc [dbo].[asGLRptNKCTSoCai]
	@pMa_cty nvarchar(3),
	@pNgay1 SMALLDATETIME,
	@pNgay2 SMALLDATETIME,
	@pTk nvarchar(20) -- Tài khoản :*
AS
declare @pThang1 int, @pThang2 int, @pNam int
	, @Tk_cn bit
-- Tai khoan cong no
select @Tk_cn = tk_cn from gldmtk where ma_cty = @pMa_cty and tk = @pTk 

set @pThang1 = MONTH(@pNgay1)
set @pThang2 = MONTH(@pNgay2)
set @pNam = YEAR(@pNgay2)

declare @i int, @sql nvarchar(1000), @sql_select nvarchar(1000), @sql_cong nvarchar(1000)
-- Table kq
create table #Kq (tk_du nvarchar(20), ps bigint, sort int, thang int, bold bit not null default 0)

-- Chi tiet phat sinh
insert #Kq (tk_du, ps, thang, sort)	
select tk_du, SUM(ps_no), thang, 0
from glct 
where ma_cty=@pMa_cty 
	and tk like @pTk + '%'
	and nam = @pNam 
	and thang between @pThang1 and @pThang2
	and ps_no <> 0
group by tk_du, thang

-- Tong ps no
insert #Kq (tk_du, ps, thang, sort, bold)	
select N'Tổng PS nợ', SUM(ps_no), thang, 1,1
from glct 
where ma_cty=@pMa_cty 
	and tk like @pTk + '%'
	and nam = @pNam 
	and thang between @pThang1 and @pThang2
	and ps_no <> 0
group by thang

-- Tong ps co
insert #Kq (tk_du, ps, thang, sort, bold)	
select N'Tổng PS có', SUM(ps_co), thang, 2, 1
from glct 
where ma_cty=@pMa_cty 
	and tk like @pTk + '%'
	and nam = @pNam 
	and thang between @pThang1 and @pThang2
	and ps_co <> 0
group by thang

set @sql_select = 'select tk_du'
set @sql_cong = 'SUM(0'
set @i = @pThang1
while @i <= @pThang2
begin
	-- Them truong so lieu theo thang
	set @sql = 'ALTER TABLE #Kq ADD T' + cast(@i as nvarchar) +  ' decimal(19,4) DEFAULT 0'
	execute(@sql)
	set @sql = 'UPDATE #Kq SET T' + cast(@i as nvarchar) + '=0'
	execute(@sql)

	-- So du
	if @Tk_cn = 1
		begin
			-- So du dau thang 
			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư nợ đầu tháng', sum(Du_no) , @i, -2, 1
			From dbo.afDuDauTkKh(@pMa_cty, @pTk, '', dbo.afBeginOfMonth(@i , @pNam),'')
			
			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư có đầu tháng', sum(Du_co) , @i, -1, 1
			From dbo.afDuDauTkKh(@pMa_cty, @pTk, '', dbo.afBeginOfMonth(@i , @pNam),'')

			-- So du cuoi thang
			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư nợ cuối tháng', sum(Du_no), @i, 4 as sort, 1 as bold
			From dbo.afDuCuoiTkKh(@pMa_cty, @pTk, '', dbo.afEndOfMonth(@i, @pNam),'')
			-- having SUM(du_no - du_co) > 0

			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư có cuối tháng', sum(Du_co), @i, 5 as sort, 1 as bold
			From dbo.afDuCuoiTkKh(@pMa_cty, @pTk, '', dbo.afEndOfMonth(@i, @pNam),'')

		end 
	else
		begin
			-- So du dau thang 
			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư nợ đầu tháng', sum(Du_no - Du_co) , @i, -1, 1
			From dbo.afDuDauTk(@pMa_cty, @pTk, dbo.afBeginOfMonth(@i , @pNam),'')
			having SUM(du_no-du_co) > 0
			
			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư có đầu tháng', sum(Du_co - Du_no) , @i, -1, 1
			From dbo.afDuDauTk(@pMa_cty, @pTk, dbo.afBeginOfMonth(@i , @pNam),'')
			having SUM(du_co-du_no) > 0

			-- So du cuoi thang
			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư nợ cuối tháng', sum(Du_no - Du_co), @i, 4 as sort, 1 as bold
			From dbo.afDuCuoiTk(@pMa_cty, @pTk, dbo.afEndOfMonth(@i, @pNam),'')
			having SUM(du_no - du_co) > 0

			insert #Kq (tk_du, ps, thang, sort, bold)
			Select N'Dư có cuối tháng', sum(Du_co - Du_no), @i, 4 as sort, 1 as bold
			From dbo.afDuCuoiTk(@pMa_cty, @pTk, dbo.afEndOfMonth(@i, @pNam),'')
			having SUM(du_co - du_no) > 0		
		end 		
	
	-- Update vao cot tuong ung
	set @sql = 'UPDATE #Kq SET T' + cast(@i as nvarchar) + '=Ps where thang=' + cast(@i as nvarchar)
	execute(@sql)
	
	-- chuoi tao ra truong tong cong
	set @sql_cong = @sql_cong + '+T' + cast(@i as nvarchar)
	
	-- chuoi ket qua	
	set @sql_select = @sql_select + ',SUM(t' + cast(@i as nvarchar) + ') as T' + cast(@i as nvarchar)
	set @i = @i + 1
end 

-- Ket qua
set @sql_select = @sql_select + ',' + @sql_cong +') AS Cong,Bold FROM #Kq GROUP BY Sort, Tk_du, Bold ORDER BY Sort,Tk_du,Bold'
execute(@sql_select)

GO


```

### asSiDelUpdateLogCT

```sql
/*****************************************************************
     * Time: /2013
     * Author: DUONGVM
     * Comments: 
     *****************************************************************/
     
CREATE PROCEDURE [dbo].[asSiDelUpdateLogCT]
	@pId INT,
	@pRet INT OUTPUT -- 0: duoc xoa, 1 - khong xoa
AS
	
	    DELETE SiUpdateLogCT
	    WHERE  Id = @pId
	    
	    SET @pRet = @@ERROR -- duoc xoa
	
	------------------------------------------------------------

GO


```

### asPostGlPh1_glct_1n

```sql
-- AsiaSoft, Nov 11 2005
-- Created by LocPv
-- Post phieu ke toan cho 1 nhom dk. Truong hop 1 no nhieu co

CREATE  PROCEDURE [dbo].[asPostGlPh1_glct_1n]
    @pMa_cty NVARCHAR(3) ,
    @pSTT_rec NVARCHAR(20) ,
    @pNh_dk NVARCHAR(3)
AS 
    DECLARE @pNamTC INT ,
        @pThangTC INT ,
        @pNgay_ct SMALLDATETIME ,
        @pMa_nt0 AS NVARCHAR(3)
       
    SELECT  @pNgay_ct = ngay_ct
    FROM    glph1
    WHERE   ma_cty = @pMa_cty
            AND stt_rec = @pStt_rec
	
    SELECT  @pMa_nt0 = ma_nt0
    FROM    dbo.sisetup
    WHERE   ma_cty = @pMa_cty
	
    SELECT  @pNamTC = dbo.afNamTC(@pMa_cty, @pNgay_ct) ,
            @pThangTC = dbo.afThangTC(@pMa_cty, @pNgay_ct)

	-- tk ghi no lam tk
    INSERT  INTO glct
            ( ma_cty ,
              stt_rec ,
              stt_rec0 ,
              ma_ct ,
              ngay_ct ,
              thang ,
              nam ,
              ngay_lct ,
              so_ct ,
              dien_giai ,
              nhom_dk ,
              tk ,
              tk_du ,
              ps_no_nt ,
              ps_co_nt ,
              ma_nt ,
              ty_gia ,
              ps_no ,
              ps_co ,
              ma_kh ,
              ma_bp ,
              ma_hd ,
              ma_phi ,
              ma_spct ,
              ma_lo,
              ma_ku ,
              cdate ,
              cuser ,
              ldate ,
              luser
            )
            SELECT  @pma_cty AS ma_cty ,
                    a.stt_rec ,
                    b.stt_rec0 ,
                    a.ma_ct ,
                    a.ngay_ct ,
                    a.thang AS thang ,
                    a.nam AS nam ,
                    a.ngay_lct ,
                    a.so_ct ,
                    a.dien_giai ,
                    a.nh_dk AS nhom_dk ,
                    a.tk ,
                    b.tk AS tk_du ,
                    CASE a.ma_nt
                      WHEN @pMa_nt0 THEN 0
                      ELSE b.ps_co_nt
                    END AS ps_no_nt ,
                    CASE a.ma_nt
                      WHEN @pMa_nt0 THEN 0
                      ELSE b.ps_no_nt
                    END AS ps_co_nt ,
                    a.ma_nt ,
                    a.ty_gia ,
                    b.ps_co AS ps_no ,
                    b.ps_no AS ps_no ,
                    a.ma_kh ,
                    a.ma_bp ,
                    a.ma_hd ,
                    a.ma_phi ,
                    a.ma_spct ,
                    a.ma_lo,
                    a.ma_ku ,
                    a.cdate ,
                    a.cuser ,
                    a.ldate ,
                    a.luser
            FROM    ( SELECT    p.stt_rec ,
                                p.ma_ct ,
                                p.ngay_ct ,
                                @pThangTC AS thang ,
                                @pNamTC AS nam ,
                                p.ngay_lct ,
                                p.so_ct ,
                                c.dien_giai ,
                                c.nh_dk ,
                                c.tk AS tk ,
                                c.ma_nt ,
                                c.ty_gia ,
                                c.ma_kh ,
                                c.ma_bp ,
                                c.ma_hd ,
                                c.ma_phi ,
                                c.ma_spct ,
                                c.ma_lo,
                                c.ma_ku ,
                                p.cdate ,
                                p.cuser ,
                                p.ldate ,
                                p.luser
                      FROM      glct1 c ,
                                glph1 p
                      WHERE     c.stt_rec = p.stt_rec
                                AND p.stt_rec = @pSTT_rec
                                AND p.ma_cty = @pma_cty
                                AND c.nh_dk = @pnh_dk
                                AND ps_no <> 0
                    ) a ,
                    ( SELECT    c.tk ,
                                c.stt_rec0 ,
                                ( CASE c.ma_nt
                                    WHEN @pMa_nt0 THEN 0
                                    ELSE c.ps_no_nt
                                  END ) AS ps_no_nt ,
                                ( CASE c.ma_nt
                                    WHEN @pMa_nt0 THEN 0
                                    ELSE c.ps_co_nt
                                  END ) AS ps_co_nt ,
                                c.ps_no ,
                                c.ps_co
                      FROM      glct1 c ,
                                glph1 p
                      WHERE     p.stt_rec = @pstt_rec
                                AND p.stt_rec = c.Stt_rec
                                AND c.stt_rec = @pStt_rec
                                AND c.nh_dk = @pNh_dk
                                AND c.ps_co <> 0
                    ) b


	-- tk ghi co lam tk
    INSERT  INTO glct
            ( ma_cty ,
              stt_rec ,
              stt_rec0 ,
              ma_ct ,
              ngay_ct ,
              thang ,
              nam ,
              ngay_lct ,
              so_ct ,
              dien_giai ,
              nhom_dk ,
              tk ,
              tk_du ,
              ps_no_nt ,
              ps_co_nt ,
              ma_nt ,
              ty_gia ,
              ps_no ,
              ps_co ,
              ma_kh ,
              ma_bp ,
              ma_hd ,
              ma_phi ,
              ma_spct ,
              ma_lo,
              ma_ku ,
              cdate ,
              cuser ,
              ldate ,
              luser
            )
            SELECT  @pma_cty AS ma_cty ,
                    a.stt_rec ,
                    a.stt_rec0 ,
                    a.ma_ct ,
                    a.ngay_ct ,
                    a.thang AS thang ,
                    a.nam AS nam ,
                    a.ngay_lct ,
                    a.so_ct ,
                    a.dien_giai ,
                    a.nh_dk AS nhom_dk ,
                    a.tk ,
                    b.tk AS tk_du ,
                    CASE a.ma_nt
                      WHEN @pMa_nt0 THEN 0
                      ELSE a.ps_no_nt
                    END ,
                    CASE a.ma_nt
                      WHEN @pMa_nt0 THEN 0
                      ELSE a.ps_co_nt
                    END ,
                    a.ma_nt ,
                    a.ty_gia ,
                    a.ps_no ,
                    a.ps_co ,
                    a.ma_kh ,
                    a.ma_bp ,
                    a.ma_hd ,
                    a.ma_phi ,
                    a.ma_spct ,
                    a.ma_lo,
                    a.ma_ku ,
                    a.cdate ,
                    a.cuser ,
                    a.ldate ,
                    a.luser
            FROM    ( SELECT    p.stt_rec ,
                                c.stt_rec0 ,
                                p.ma_ct ,
                                p.ngay_ct ,
                                @pThangTC AS thang ,
                                @pNamTC AS nam ,
                                p.ngay_lct ,
                                p.so_ct ,
                                c.dien_giai ,
                                c.nh_dk ,
                                c.tk AS tk ,
                                c.ma_nt ,
                                c.ty_gia ,
                                ( CASE c.ma_nt
                                    WHEN @pMa_nt0 THEN 0
                                    ELSE c.ps_no_nt
                                  END ) AS ps_no_nt ,
                                ( CASE c.ma_nt
                                    WHEN @pMa_nt0 THEN 0
                                    ELSE c.ps_co_nt
                                  END ) AS ps_co_nt ,
                                c.ps_no ,
                                c.ps_co ,
                                c.ma_kh ,
                                c.ma_bp ,
                                c.ma_hd ,
                                c.ma_phi ,
                                c.ma_spct ,
                                c.ma_lo,
                                c.ma_ku ,
                                p.cdate ,
                                p.cuser ,
                                p.ldate ,
                                p.luser
                      FROM      glct1 c ,
                                glph1 p
                      WHERE     c.stt_rec = p.stt_rec
                                AND p.stt_rec = @pSTT_rec
                                AND p.ma_cty = @pma_cty
                                AND c.nh_dk = @pnh_dk
                                AND c.ps_co <> 0
                    ) a ,
                    ( SELECT    tk
                      FROM      glct1
                      WHERE     stt_rec = @pstt_rec
                                AND nh_dk = @pNh_dk
                                AND ps_no <> 0
                    ) b

GO


```

### asSIUpdDMHTTT

```sql
-- ================================================
-- asSIUpdDMHTTT
-- Created by: TRANGNT
-- Created date: Dec 17 2009 10:36PM
-- ================================================
CREATE PROCEDURE [dbo].[asSIUpdDMHTTT] 		@pMa_cty	nvarchar(3),	@pMa_httt	nvarchar(20),	@pModuleid	nvarchar(2),	@pTen_httt	nvarchar(50),	@pTk	nvarchar(20),	@pTk_thue_gtgt_mua	nvarchar(20),	@pTk_thue_gtgt_ban	nvarchar(20),	@pTk_thue_nk	nvarchar(20),	@pTk_thue_xk	nvarchar(20),	@pTk_gtgt_nk_no	nvarchar(20),	@pTk_gtgt_nk_co	nvarchar(20),	@pTk_thue_gtgt_xk	nvarchar(20),	@pTK_thue_ttdb	nvarchar(20),	@pTk_ck nvarchar(20),	@pKsd	bit,	@pLUser	nvarchar(20),	@pRet	int output
AS 
	Update SIDMHTTT	set 		Ten_httt	= @pTen_httt,		Tk	= @pTk,		Tk_thue_gtgt_mua	= @pTk_thue_gtgt_mua,		Tk_thue_gtgt_ban	= @pTk_thue_gtgt_ban,		Tk_thue_nk	= @pTk_thue_nk,		Tk_thue_xk	= @pTk_thue_xk,		Tk_gtgt_nk_no	= @pTk_gtgt_nk_no,		Tk_gtgt_nk_co	= @pTk_gtgt_nk_co,		Tk_thue_gtgt_xk	= @pTk_thue_gtgt_xk,		tk_thue_ttdb=@pTK_thue_ttdb,		Tk_ck =@pTk_ck,		Ksd	= @pKsd,		Ldate	= getdate(),		Luser	= @pLUser	where Ma_cty = @pMa_cty and Ma_httt = @pMa_httt and Moduleid = @pModuleid	Set @pRet = @@error

GO


```

### asUpdSysVar

```sql
-- =========================================================
-- asUpdSysVar - Cập nhật dữ liệu của bảng phân hệ + 'setup'
-- Created by: TRANGNT
-- Created date: Dec 17 2009  9:10AM
-- Alter date: Aug 04 2010 02:53 PM
-- =========================================================
CREATE PROCEDURE [dbo].[asUpdSysVar]
      @pMa_cty NVARCHAR(3) ,
      @pPhan_he NVARCHAR(2) ,
      @pFieldName NVARCHAR(100) ,
      @pValue SQL_VARIANT
AS 

      DECLARE @sql NVARCHAR(200) ,
              @datatype NVARCHAR(100) ,
              @character_maxlength int,
              @numeric_precision VARCHAR(10) ,
              @numeric_scale VARCHAR(10) ,
              @tblName NVARCHAR(50) ,
              @ParamDefines NVARCHAR(50)
	
      SET @tblName = @pPhan_he + 'setup'
      SELECT    @datatype = data_type ,
                @numeric_precision = numeric_precision ,
                @numeric_scale = numeric_scale,
                @character_maxlength = character_maximum_length
      FROM      information_schema.columns 
      WHERE     table_name = @tblName AND
                column_name = @pFieldName
		 
      SET @ParamDefines = N'@Value sql_variant'
	
    
      SET @sql = 'Update ' + @tblName + ' set ' + @pFieldName +
          '  =  cast(@Value as ' + @datatype +
          CASE WHEN @numeric_scale IS NULL THEN ''
			   WHEN @numeric_scale = 0 THEN ''
			   WHEN @datatype = 'nvarchar' THEN  '('+ LTRIM(RTRIM(@character_maxlength)) +')'
               ELSE '(' + @numeric_precision + ',' + @numeric_scale + ')'
          END + ') where ma_cty = ' + CHAR(39) + @pMa_cty + CHAR(39)  
select @sql,@tblName

      EXEC sp_executesql @stmt = @sql , @params = @ParamDefines ,
        @Value = @pValue

GO


```

### asINRptCTVT02_crys

```sql
--Duongvm	
--26/08/2011
--Thẻ kho in tất cả
-- [asINRptCTVT02_crys] '999', '01/01/2012', '12/31/2012',''

CREATE PROCEDURE [dbo].[asINRptCTVT02_crys]
	@pMa_cty NVARCHAR(3),
	@pNgay1 SMALLDATETIME,
	@pNgay2 SMALLDATETIME,
	@pXml XML,
	@pMa_vt NVARCHAR(20) = '',
	@pMa_kho NVARCHAR(8) = '',
	@pMa_vitri NVARCHAR(8) = '',
	@pMau_bc NVARCHAR(20) = '02',	--01: So chi tiet vat tu; 02: the kho
	@pMa_nt NVARCHAR(3) = 'VND'
AS
	-- XML to test : <NewDataSet><Table1><Ma_vt>101</Ma_vt></Table1><Table1><Ma_vt>102</Ma_vt></Table1><Table1><Ma_vt>103</Ma_vt></Table1><Table1><Ma_vt>104</Ma_vt></Table1><Table1><Ma_vt>105</Ma_vt></Table1><Table1><Ma_vt>106</Ma_vt></Table1></NewDataSet>
	DECLARE @ton_dau    DECIMAL(19, 4),
	        @du_dau     DECIMAL(19, 4),
	        @du_dau_nt  DECIMAL(19, 4)
	        
    
    DECLARE @ton_cuoi    DECIMAL(19, 4),
			@du_cuoi     DECIMAL(19, 4),
			@du_cuoi_nt  DECIMAL(19, 4)
	
    DECLARE @pSysMsg1 NVARCHAR(50) = N'Tồn đầu kỳ'     --N'#INRpt_TDK' -- N'Tồn đầu kỳ'
    DECLARE @pSysMsg2 NVARCHAR(50) = N'Tổng phát sinh' --N'#INRpt_TPS' -- N'Tổng phát sinh'
    DECLARE @pSysMsg3 NVARCHAR(50) = N'Tồn cuối kỳ'    --N'#INRpt_TCK' -- N'Tồn cuối kỳ'
	DECLARE @sql NVARCHAR(400)=''
	CREATE TABLE #Result
	(
		ma_vt         NVARCHAR(20) NOT NULL DEFAULT(''),
		ma_kho        NVARCHAR(20) NOT NULL DEFAULT(''),
		stt_rec       NVARCHAR(20) NOT NULL DEFAULT(''),
		stt_rec0      NVARCHAR(3) NOT NULL DEFAULT(''),
		ma_ct         NVARCHAR(3) NOT NULL DEFAULT(''),
		ngay_ct       SMALLDATETIME NOT NULL DEFAULT(''),
		so_ct         NVARCHAR(20) NOT NULL DEFAULT(''),
		ma_kh         NVARCHAR(20) NOT NULL DEFAULT(''),
		ten_kh        NVARCHAR(255) NOT NULL DEFAULT(''),
		ma_nx         NVARCHAR(20) NOT NULL DEFAULT(''),
		tk_du         NVARCHAR(20) NOT NULL DEFAULT(''),
		dien_giai     NVARCHAR(255) NOT NULL DEFAULT(''),
		sl_nhap       DECIMAL(19, 4) NOT NULL DEFAULT(0),
		sl_xuat       DECIMAL(19, 4) NOT NULL DEFAULT(0),
		gia           DECIMAL(19, 4) NOT NULL DEFAULT(0),
		tien_nhap     DECIMAL(19, 4) NOT NULL DEFAULT(0),
		tien_xuat     DECIMAL(19, 4) NOT NULL DEFAULT(0),
		ma_nt         NVARCHAR(3) NOT NULL DEFAULT(''),
		ty_gia        DECIMAL(19, 4) NOT NULL DEFAULT(0),
		gia_nt        DECIMAL(19, 4) NOT NULL DEFAULT(0),
		tien_nhap_nt  DECIMAL(19, 4) NOT NULL DEFAULT(0),
		tien_xuat_nt  DECIMAL(19, 4) NOT NULL DEFAULT(0),
		ton           DECIMAL(19, 4) NOT NULL DEFAULT(0),
		du            DECIMAL(19, 4) NOT NULL DEFAULT(0),
		du_nt         DECIMAL(19, 4) NOT NULL DEFAULT(0),
		fsort         NVARCHAR(1) NOT NULL DEFAULT(''),
		bold          INT,
		has_sysmsg	NVARCHAR(1) NOT NULL DEFAULT('0')
	)
	
	DECLARE @idoc INT
	EXEC sp_xml_preparedocument @idoc OUTPUT,
	     @pXml
	
	DECLARE controXML CURSOR  
	FOR
	    SELECT MA_VT
	    FROM   OPENXML(@idoc, '/NewDataSet/Table1', 2)
	           WITH (Ma_vt NVARCHAR(20))
	
	OPEN controXML
	FETCH NEXT FROM controXML INTO @pMa_vt
	WHILE @@FETCH_STATUS = 0
	BEGIN
	    SELECT @ton_dau = SUM(ISNULL(so_luong, 0)),
	           @du_dau = SUM(ISNULL(tien, 0)),
	           @du_dau_nt = SUM(ISNULL(tien_nt, 0))
	    FROM   afGetTonDauVt(
	               @pma_cty,
	               @pma_vt,
	               '',
	               @pma_kho,
	               @pMa_vitri,
	               '',
	               @pNgay1,
	               @pMa_nt
	    )
	    IF OBJECT_ID('tempdb.#tmpTC') IS NOT NULL  
		DROP TABLE #tmpTable1
	    
	    SELECT 
	    *
	    INTO #tmpTC
	    FROM   afGetTonCuoiVt (
	               @pma_cty,
	               @pma_vt,
	               '',
	               @pma_kho,
	               @pMa_vitri,
	               '',
	               @pNgay2,
	               @pMa_nt
	           )
	    
	    
	    SELECT @sql = 
	    case 
	    WHEN
	      @pMa_vitri <> '' THEN 
	    '
	    SELECT  Ma_vitri,
				@ton_cuoi = SUM(ISNULL(so_luong, 0)),
	            @du_cuoi = SUM(ISNULL(tien, 0)),
	            @du_cuoi = SUM(ISNULL(tien_nt, 0))
	    FROM #tmpTC  
	    GROUP BY Ma_vitri'
	    ELSE	'
	    SELECT  
				@ton_cuoi = SUM(ISNULL(so_luong, 0)),
	            @du_cuoi = SUM(ISNULL(tien, 0)),
	            @du_cuoi = SUM(ISNULL(tien_nt, 0))
	    FROM #tmpTC   '
	   END 
	   
	   PRINT @sql
	   
	    -- Tồn đầu kỳ
	    INSERT #Result
	      (
	        Ma_kho,
	        Ma_vt,
	        fsort,
	        bold,
	        has_sysmsg,
	        dien_giai,
	        ton,
	        du,
	        du_nt
	      )
	    VALUES
	      (
	        @pMa_kho,
	        @pma_vt,
	        '0',
	        1,
	        '1',
	        @pSysMsg1,
	        ISNULL(@ton_dau, 0),
	        ISNULL(@du_dau, 0),
	        ISNULL(@du_dau_nt, 0)
	      )
	    
	    -- Chi tiết phát sinh trong kỳ
	    INSERT #result
	    SELECT a.ma_vt,
	           a.ma_kho,
	           a.stt_rec,
	           a.stt_rec0,
	           a.ma_ct,
	           a.ngay_ct,
	           a.so_ct,
	           a.ma_kh,
	           ISNULL(c.ten_kh, ''),
	           a.ma_nx,
	           a.tk_du,
	           a.dien_giai,
	           a.sl_nhap_qd AS sl_nhap,
	           a.sl_xuat_qd AS sl_xuat,
	           a.gia,
	           a.tien_nhap,
	           a.tien_xuat,
	           a.ma_nt,
	           a.ty_gia,
	           a.gia_nt,
	           a.tien_nhap_nt,
	           a.tien_xuat_nt,
	           0 AS ton,
	           0 AS du,
	           0 AS du_nt,
	           '1' AS fsort,
	           0 AS bold,
	           '0' AS has_sysmsg
	    FROM   inct a
	           LEFT JOIN ardmkh c
	                ON  a.ma_cty = c.ma_cty
	                AND a.ma_kh = c.ma_kh
	           LEFT JOIN indmvt i
	                ON  a.ma_cty = i.ma_cty
	                AND i.ma_vt = a.ma_vt
	    WHERE  a.ma_cty LIKE @pMa_cty + '%'
	           AND a.ngay_ct BETWEEN @pNgay1 AND @pNgay2
	           AND a.ma_vt LIKE @pMa_vt + '%'
	           AND a.ma_kho LIKE @pMa_kho + '%'
	           AND a.ma_vitri LIKE @pMa_vitri + '%'
	           AND a.ma_nt LIKE @pMa_nt + '%'
	    ORDER BY
	           ngay_ct,
	           so_ct
	    
	    -- Tổng phát sinh
	    INSERT #Result
	      (
	        ma_kho,
	        ma_vt,
	        fsort,
	        bold,
	        has_sysmsg,
	        dien_giai,
	        sl_nhap,
	        sl_xuat,
	        tien_nhap,
	        tien_xuat,
	        tien_nhap_nt,
	        tien_xuat_nt
	      )
	    SELECT @pMa_kho,
	           ma_vt,
	           '2' AS fsort,
	           '1' AS bold,
	           '1' AS has_sysmsg,
	           @pSysMsg2 AS dien_giai,
	           SUM(sl_nhap),
	           SUM(sl_xuat),
	           SUM(tien_nhap),
	           SUM(tien_xuat),
	           SUM(tien_nhap_nt),
	           SUM(tien_xuat_nt)
	    FROM   #Result
	    WHERE  ma_vt = @pma_vt
	    GROUP BY
	           ma_vt
	    
	    
	    -- Tồn cuối mới giao dịch
	    DECLARE @stt_rec NVARCHAR(20), @stt_rec0 nvarchar(20)
	    
	    DECLARE contro CURSOR  
	    FOR
	        SELECT stt_rec,stt_rec0
	        FROM   #result
	        WHERE  bold <> '1'
	               AND ma_vt = @pMa_vt
	        ORDER BY
	               ngay_ct,
	               so_ct,
	               ABS(sl_nhap) DESC
	    
	    OPEN contro
	    FETCH NEXT FROM contro INTO @Stt_Rec, @stt_rec0
	    WHILE @@FETCH_STATUS = 0
	    BEGIN
	        UPDATE #result
	        SET    ton = ISNULL(@ton_dau, 0) + sl_nhap - sl_xuat,
	               du = ISNULL(@du_dau, 0) + tien_nhap - tien_xuat,
	               du_nt = ISNULL(@du_dau_nt, 0) + tien_nhap_nt - tien_xuat_nt
	        WHERE  stt_rec = @Stt_Rec
	               AND ma_kho = @pMa_kho and stt_rec0 = @stt_rec0 

	        SELECT @ton_dau = ton,
	               @du_dau = du,
	               @du_dau_nt = du_nt
	        FROM   #result
	        WHERE  stt_rec = @Stt_Rec
	               AND ma_kho = @pMa_kho AND Stt_rec0 = @stt_rec0 
	        FETCH NEXT FROM contro INTO @Stt_Rec, @stt_rec0
	    END
	    CLOSE contro
	    DEALLOCATE contro

	    -- Tồn cuối
	    INSERT #Result
	      (
	        ma_kho,
	        ma_vt,
	        fsort,
	        bold,
	        has_sysmsg,
	        dien_giai,
	        ton,
	        du,
	        du_nt
	      )
	    VALUES
	      (
	        @pMa_kho,
	        @pMa_vt,
	        '3',
	        1,
	        '1',
	        @pSysMsg3,
	        ISNULL(@ton_cuoi, 0),
	        ISNULL(@du_cuoi, 0),
	        ISNULL(@du_cuoi_nt, 0)
	      )
	    DROP TABLE #tmpTC
	    FETCH NEXT FROM controXML INTO @pMa_vt
	END
	CLOSE controXML
	DEALLOCATE controXML
	
	-- Kết quả
	SELECT r.*,
	       i.ten_vt,
	       i.dvt,
	       k.ten_kho,
	       i.tk_vt,
	       t.ten_tk AS ten_tk_vt
	FROM   #result r,
	       indmvt i,
	       indmkho k,
	       gldmtk t
	WHERE  i.ma_cty = @pMa_cty
	       AND r.ma_vt = i.ma_vt
	       AND k.ma_cty = @pMa_cty
	       AND r.ma_kho = k.ma_kho
	       AND t.ma_cty = @pMa_cty
	       AND i.tk_vt = t.tk
	ORDER BY
	       ma_vt,
	       fsort,
	       ngay_ct,
	       so_ct

	DROP TABLE #result

GO


```

### asHrInsChamCongKhac

```sql
-- =============================================
-- Author:		HieuLQ
-- Create date: 02/07/2014
-- Description:	Thêm mới chấm công khác
-- =============================================
CREATE PROCEDURE [dbo].[asHrInsChamCongKhac] 
	@pMa_cty NVARCHAR(3),
	@pNam INT,
	@pThang INT,
	@pNgay INT,
	@pId NVARCHAR(20),
	@pMa_cham_cong NVARCHAR(20),
	@pKh_cham_cong NVARCHAR(20),
	@pGio_vao INT,
	@pPhut_vao INT,
	@pGio_ra INT,
	@pPhut_ra INT,
	@pThem_gio BIT,
	@pCuser NVARCHAR(20),
	@pRet INT OUTPUT
AS
BEGIN
	INSERT INTO HrChamCongKhac
	(
		Ma_cty,
		Nam,
		Thang,
		Ngay,
		Id,
		Ma_cham_cong,
		Kh_cham_cong,
		Gio_vao,
		Phut_vao,
		Gio_ra,
		Phut_ra,
		Them_gio,
		Cdate,
		Ldate,
		Cuser,
		Luser
	)
	VALUES
	(
		@pMa_cty,
		@pNam,
		@pThang,
		@pNgay,
		@pId,
		@pMa_cham_cong,
		@pKh_cham_cong,
		@pGio_vao,
		@pPhut_vao,
		@pGio_ra,
		@pPhut_ra,
		@pThem_gio,
		GETDATE(),
		GETDATE(),
		@pCuser,
		@pCuser
	)
	
	SET @pRet = @@ERROR
END

GO


```

### asSIDelDMBP

```sql
-- ================================================
-- asSIDelDMBP
-- Created by: TRANGNT
-- Created date: Dec 17 2009 10:36PM
-- ================================================
CREATE PROCEDURE [dbo].[asSIDelDMBP] 	@pMa_cty	nvarchar(3),	@pMa_bp	nvarchar(20),
	@pRet	int output   -- 0: duoc xoa, <>0 - khong xoa
AS 
exec @pRet=dbo.afChkExistsCodeDict @pMa_cty,SIDMBP,Ma_bp,@pMa_bp
IF @pRet <> 0 
BEGIN
	SET @pRet=50004
	RETURN
END

	Delete SIDMBP
	 where Ma_cty = @pMa_cty and Ma_bp = @pMa_bp


	set @pRet = @@error

GO


```

### asPORptF5TH02

```sql
-- =============================================
-- Author:		Duongvm	
-- Create date: 05/12
-- Description: f5	Tổng hợp mua hàng theo kỳ
-- [asPORptF5TH02] 'A07','THANG','PO2','1',2012,'2','' 
-- =============================================
CREATE PROCEDURE [dbo].[asPORptF5TH02]--'A07','THANG','PO2','1',2012,'2','' 
    @pma_cty NVARCHAR(3) ,
    @pLoai NVARCHAR(5) , -- 'THANG' - Theo tháng; 'QUY' - Theo quý; 'NAM' - Theo Năm
    @pMa_ct NVARCHAR(10) ,--'PO2'-Phiếu nhập mua, - 'PO3': Hóa đơn mua hàng
    @pThang INT ,
    @pNam INT ,
    @pSo_ky INT ,
    @pMa_nt NVARCHAR(3) = '' ,
    @pMa_vt NVARCHAR(20)
AS 
    BEGIN
        DECLARE @Ngay1 SMALLDATETIME
        DECLARE @Ngay2 SMALLDATETIME
        DECLARE @Ngay_dau SMALLDATETIME
        DECLARE @Ngay_cuoi SMALLDATETIME -- ngay cuoi ky bao cao
        DECLARE @Buoc_nhay_thang INT 

		-- Lay ngay dau nam
        SET @Ngay_dau =  dbo.afNgay_DTTC(@pMa_cty, @pThang, @pNam) --CAST(@pThang AS NVARCHAR(2)) + '/01/' + CAST(@pNam AS NVARCHAR(4))
        
		-- tinh ngay cuoi ky bao cao
        SET @Buoc_nhay_thang = CASE @pLoai
                                 WHEN 'THANG' THEN 1
                                 WHEN 'QUY' THEN 3
                                 ELSE 12
                               END
        SET @Ngay_cuoi = DATEADD(month, @pSo_ky * @Buoc_nhay_thang, @Ngay_dau)
        SET @Ngay_cuoi = DATEDIFF(day, 1, @Ngay_cuoi)
	
		-- bang chua du lieu hien thi tren crystal
        CREATE TABLE #result
            (
              ma_cty NVARCHAR(3) ,
              stt_rec NVARCHAR(20) ,
              stt_rec0 NVARCHAR(3) ,
              ky INT ,
              ngay1 SMALLDATETIME ,
              ngay2 SMALLDATETIME ,
              ngay_ct SMALLDATETIME ,
              ma_vt NVARCHAR(20) ,
              ten_vt NVARCHAR(100) ,
              dvt NVARCHAR(8) ,
              ma_ct NVARCHAR(3) ,
              ma_nt NVARCHAR(3) ,
              so_luong DECIMAL(19, 4) ,
              tien DECIMAL(19, 4) ,
              tien_nt DECIMAL(19, 4) ,
              t_tien DECIMAL(19, 4) ,
              t_tien_nt DECIMAL(19, 4) ,
              cp DECIMAL(19, 4) ,
              cp_nt DECIMAL(19, 4) ,
              thue_nk DECIMAL(19, 4) ,
              thue_nk_nt DECIMAL(19, 4) ,
              thue_gtgt DECIMAL(19, 4) ,
              thue_gtgt_nt DECIMAL(19, 4) ,
              thue_ttdb DECIMAL(19, 4) ,
              thue_ttdb_nt DECIMAL(19, 4) ,
              tt DECIMAL(19, 4) ,
              tt_nt DECIMAL(19, 4) NOT NULL
                                   DEFAULT ( '' )
            )
        DECLARE @pKy AS INT  = 1 
        SET @Ngay1 = @Ngay_dau
        SET @Ngay2 = DATEDIFF(day, 1, DATEADD(month, @Buoc_nhay_thang, @Ngay1))
        WHILE @Ngay2 <= @Ngay_cuoi 
            BEGIN
				--Lọc DL theo các điều kiện: ma_cty,ma_nt,ngay dau,ngay cuoi,loai,loại_ct
                INSERT  INTO #result
                        SELECT  p.ma_cty ,
                                p.stt_rec ,
                                p.stt_rec0 ,
                                @pKy AS Ky ,
                                @ngay1 AS ngay1 ,
                                @Ngay2 AS ngay2 ,
                                p.ngay_ct ,
                                p.ma_vt ,
                                i.ten_vt ,
                                i.dvt ,
                                p.ma_ct ,
                                p.ma_nt ,
                                p.so_luong ,
                                p.tien0 AS tien ,
                                p.tien_nt0 AS tien_nt ,
                                p.tien AS t_tien ,
                                p.tien_nt AS t_tien_nt ,
                                p.cp ,
                                p.cp_nt ,
                                p.thue_nk ,
                                p.thue_nk_nt ,
                                p.thue_gtgt ,
                                p.thue_gtgt_nt ,
                                p.thue_ttdb ,
                                p.thue_ttdb_nt ,
                                p.tt ,
                                p.tt_nt
                        FROM    poct p
                                INNER JOIN indmvt i ON p.ma_cty = i.ma_cty
                                                       AND p.ma_vt = i.ma_vt
                        WHERE   p.ma_cty LIKE @pma_cty + '%'
                                AND p.ngay_ct BETWEEN @ngay1 AND @Ngay2
                                AND p.ma_ct LIKE @pMa_ct + '%'
                                AND (@pMa_nt = '' OR p.ma_nt LIKE @pMa_nt + '%')
                                AND (@pMa_vt = '' OR p.ma_vt LIKE @pMa_vt + '%')
                                
                SET @Ngay1 = DATEADD(month, @Buoc_nhay_thang, @Ngay1)
                SET @Ngay2 = DATEDIFF(day, 1, DATEADD(month, @Buoc_nhay_thang, @Ngay1))
                SET @pKy = @pKy + 1
            END

	
        SELECT  *
        FROM    #result --4 gridview (datasource)
    END

GO


```

### asGetReportDrilldownInfo

```sql
CREATE PROCEDURE [dbo].[asGetReportDrilldownInfo]
	@pMenuID nvarchar(8)=''
AS

SELECT 
	a.menuid
	,a.ma_mau
	,a.press_key_name
	,a.drilldown_menuid
	,a.drilldown_menuid1
	,a.drilldown_menuid2
	,a.drilldown_menuid3
	,a.drilldown_menuid4
	,a.dllName
	,command
	,[description]
FROM sysReportDrillDownInfo a
WHERE a.MenuID = @pMenuID

GO


```

### asHrDelQTNghiCheDo

```sql
-- =============================================
-- Author:		HieuLQ
-- Create date: 26/06/2014
-- Description:	Xoá quá trình nghỉ chế độ
-- =============================================
CREATE PROCEDURE [dbo].[asHrDelQTNghiCheDo] 
	@pMa_cty NVARCHAR(3),
	@pId NVARCHAR(20),
	@pId_qtncd NVARCHAR(3),
	@pRet INT OUTPUT
AS
BEGIN
	DELETE 
	FROM   HrQTNghiCheDo
	WHERE  Ma_cty = @pMa_cty
	       AND Id = @pId
	       AND Id_qtncd = @pId_qtncd
	
	SET @pRet = @@ERROR
END

GO


```

### asInGetSetup

```sql
-- AsiaSoft, Sep  9 2005  9:23AM
CREATE PROCEDURE [dbo].[asInGetSetup]
	@pMa_Cty nvarchar(3)AS 
    Select *    from  InSetup    where ma_cty=@pMa_Cty

GO


```

