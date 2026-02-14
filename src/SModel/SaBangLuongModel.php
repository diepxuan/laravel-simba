<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SaBangLuongModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SaBangLuong';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'ma_cty';

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = false;

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
        'ma_cty',
        'thang',
        'nam',
        'ma_bp',
        'ten_bp',
        'id_nv',
        'ma_nv',
        'ten_nv',
        'diem',
        'hs_diem',
        'luong_trich_diem',
        'tl_bhxh',
        'loai',
        'hs_loai',
        'hsl_cb',
        'hsl_cv',
        'hs_pc',
        'hs_dc',
        'hspc_kv',
        'hspc_cv',
        'hspc_dd',
        'hspc_dh',
        'luong_pcdh',
        'hspc_tn',
        'pc_tn',
        'pc_th',
        'luong_th',
        'luong_cung',
        'muc_an',
        'cong_cb',
        'cong',
        'cong_sp',
        'cong_le',
        'cong_phep',
        'cong_om',
        'cong_co',
        'cong_ts',
        'cong_khh',
        'tcong_bh',
        'cong_khac',
        'luong_cd',
        'luong_cb',
        'luong_cong',
        'luong_sp',
        'luong_le',
        'luong_phep',
        'luong_tn',
        'gio_lt',
        'cong_tg',
        'luong_tg',
        'cong75',
        'cong100',
        'cong130',
        'cong150',
        'cong180',
        'cong200',
        'cong230',
        'cong300',
        'cong330',
        'luong75',
        'luong100',
        'luong130',
        'luong150',
        'luong180',
        'luong200',
        'luong230',
        'luong300',
        'luong330',
        'luong_bh',
        'luong_khac',
        'an_ca',
        'tru_an_ca',
        'phu_cap',
        'thuong',
        'con_bu',
        'viec_rieng',
        'tong_luong',
        'tam_ung',
        'bhyt',
        'bhxh',
        'dpcd',
        'dp',
        'kpcd',
        'thue_tn',
        'tru_khac',
        'luong_pt',
        'thuc_linh',
        'da_linh',
        'luy_ke',
        'nop_bhxh',
        'doan_vien',
        'dang_vien',
        'bp_khac',
        'tk_nv',
        'cuser',
        'luser',
        'cdate',
        'ldate',
        'khoa',
        'pass'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'thang' => 'integer',
        'nam' => 'integer',
        'diem' => 'float',
        'hs_diem' => 'float',
        'luong_trich_diem' => 'float',
        'tl_bhxh' => 'float',
        'hs_loai' => 'float',
        'hsl_cb' => 'float',
        'hsl_cv' => 'float',
        'hs_pc' => 'float',
        'hs_dc' => 'float',
        'hspc_kv' => 'float',
        'hspc_cv' => 'float',
        'hspc_dd' => 'float',
        'hspc_dh' => 'float',
        'luong_pcdh' => 'float',
        'hspc_tn' => 'float',
        'pc_tn' => 'float',
        'pc_th' => 'float',
        'luong_th' => 'float',
        'luong_cung' => 'float',
        'muc_an' => 'float',
        'cong_cb' => 'float',
        'cong' => 'float',
        'cong_sp' => 'float',
        'cong_le' => 'float',
        'cong_phep' => 'float',
        'cong_om' => 'float',
        'cong_co' => 'float',
        'cong_ts' => 'float',
        'cong_khh' => 'float',
        'tcong_bh' => 'float',
        'cong_khac' => 'float',
        'luong_cd' => 'float',
        'luong_cb' => 'float',
        'luong_cong' => 'float',
        'luong_sp' => 'float',
        'luong_le' => 'float',
        'luong_phep' => 'float',
        'luong_tn' => 'float',
        'gio_lt' => 'float',
        'cong_tg' => 'float',
        'luong_tg' => 'float',
        'cong75' => 'float',
        'cong100' => 'float',
        'cong130' => 'float',
        'cong150' => 'float',
        'cong180' => 'float',
        'cong200' => 'float',
        'cong230' => 'float',
        'cong300' => 'float',
        'cong330' => 'float',
        'luong75' => 'float',
        'luong100' => 'float',
        'luong130' => 'float',
        'luong150' => 'float',
        'luong180' => 'float',
        'luong200' => 'float',
        'luong230' => 'float',
        'luong300' => 'float',
        'luong330' => 'float',
        'luong_bh' => 'float',
        'luong_khac' => 'float',
        'an_ca' => 'float',
        'tru_an_ca' => 'float',
        'phu_cap' => 'float',
        'thuong' => 'float',
        'con_bu' => 'float',
        'viec_rieng' => 'float',
        'tong_luong' => 'float',
        'tam_ung' => 'float',
        'bhyt' => 'float',
        'bhxh' => 'float',
        'dpcd' => 'float',
        'dp' => 'float',
        'kpcd' => 'float',
        'thue_tn' => 'float',
        'tru_khac' => 'float',
        'luong_pt' => 'float',
        'thuc_linh' => 'float',
        'da_linh' => 'float',
        'luy_ke' => 'float',
        'cdate' => 'datetime',
        'ldate' => 'datetime',
    ];
}
