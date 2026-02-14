<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class HrHSNSModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'HrHSNS';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'Ma_cty';

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
        'Ma_cty',
        'Id',
        'Ma_nvns',
        'Ma_uv',
        'Ma_cham_cong',
        'Ho_ten',
        'Ho_dem',
        'Ten',
        'Bi_danh',
        'Ngay_sinh',
        'Gioi_tinh',
        'So_cmnd',
        'Ngay_cap_cmnd',
        'Noi_cap_cmnd',
        'So_hc',
        'Ngay_cap_hc',
        'Ngay_hh_hc',
        'Noi_cap_hc',
        'Trinh_do_pt',
        'Noi_sinh',
        'Noi_sinh_dc',
        'Noi_sinh_xa',
        'Noi_sinh_huyen',
        'Noi_sinh_tinh',
        'Que_quan',
        'Que_quan_dc',
        'Que_quan_xa',
        'Que_quan_huyen',
        'Que_quan_tinh',
        'Ho_khau',
        'Ho_khau_dc',
        'Ho_khau_xa',
        'Ho_khau_huyen',
        'Ho_khau_tinh',
        'Noi_o',
        'Noi_o_dc',
        'Noi_o_xa',
        'Noi_o_huyen',
        'Noi_o_tinh',
        'Ma_ton_giao',
        'Ma_dan_toc',
        'Ma_quoc_tich',
        'Ma_dien_csach',
        'Ma_nghe',
        'Ma_tdql',
        'Ma_tdct',
        'Suc_khoe',
        'Chieu_cao',
        'Can_nang',
        'Nhom_mau',
        'Phone_mobile',
        'Phone_home',
        'Phone_work',
        'Phone_work_ext',
        'Phone_other',
        'Email_home',
        'Email_work',
        'Email_other',
        'Home_page',
        'Facebook',
        'Twitter',
        'Linkedin',
        'Printerest',
        'Skype',
        'Yahoo',
        'Ngay_nop_hs',
        'Ngay_thu_viec',
        'Ngay_lvct',
        'Ngay_bc',
        'Ma_bp',
        'Ma_cvcm',
        'Ma_cvdt',
        'Ma_so_thue',
        'So_tk_nh',
        'Ma_nh',
        'Chu_the',
        'Dong_bhxh',
        'So_sbh',
        'Ngay_cap_sbh',
        'Ma_tinh_dk_kcb',
        'Noi_dk_kcb',
        'Ma_tthn',
        'Ngay_cuoi',
        'So_con',
        'Thoi_viec',
        'Ngay_thoi_viec',
        'So_qd_thoi_viec',
        'Nguoi_qd_thoi_viec',
        'Tien_boi_thuong',
        'Ma_thoi_viec',
        'Goi_lai_lv',
        'Ghi_chu',
        'Anh_dai_dien',
        'Tai_lieu',
        'Hsns_type',
        'Trang_thai',
        'Cdate',
        'Ldate',
        'Cuser',
        'Luser'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'Ngay_sinh' => 'datetime',
        'Ngay_cap_cmnd' => 'datetime',
        'Ngay_cap_hc' => 'datetime',
        'Ngay_hh_hc' => 'datetime',
        'Chieu_cao' => 'float',
        'Can_nang' => 'float',
        'Ngay_nop_hs' => 'datetime',
        'Ngay_thu_viec' => 'datetime',
        'Ngay_lvct' => 'datetime',
        'Ngay_bc' => 'datetime',
        'Dong_bhxh' => 'boolean',
        'Ngay_cap_sbh' => 'datetime',
        'Ngay_cuoi' => 'datetime',
        'So_con' => 'integer',
        'Thoi_viec' => 'boolean',
        'Ngay_thoi_viec' => 'datetime',
        'Tien_boi_thuong' => 'float',
        'Goi_lai_lv' => 'boolean',
        'Cdate' => 'datetime',
        'Ldate' => 'datetime',
    ];
}
