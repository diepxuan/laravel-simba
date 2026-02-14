<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class SiSetupModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'SiSetup';

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
        'ws_id',
        'postafsave',
        'ngay_ks',
        'ngay_dntc',
        'ma_nt0',
        'Round',
        'Round_Nt',
        'Round_Gia',
        'Round_Gia_Nt',
        'LookupList',
        'Quantity_decimal',
        'Price_decimal',
        'FCPrice_decimal',
        'FCAmount_decimal',
        'Kieu_Trung_So_Ct',
        'thu_muc_mau_bang_ke',
        'thu_muc_xuat_bang_ke',
        'Qty_Input_Format',
        'Price_Input_Format',
        'FCPrice_Input_Format',
        'Amount_Input_Format',
        'FCAmount_Input_Format',
        'DM_Alternating_Back_Color_Name',
        'DM_Bakground_Color_Name',
        'tk_tu',
        'view_giavon',
        'ngay_bdsd',
        'updateserver',
        'gia_tri_dieu_chinh_toi_da',
        'gia_tri_dieu_chinh_tien_nt_toi_da',
        'gia_tri_dieu_chinh_gia_toi_da',
        'canh_bao_dieu_chinh',
        'canh_bao_han_muc_cong_no',
        'vat_db',
        'gia_truoc_thue_sau_thue',
        'Decimal_separator',
        'Thousands_separator',
        'PrintDirector_Name',
        'PrintChief_Accountant_Name',
        'PrintCreator_Name',
        'PrintDate_time',
        'lang_default',
        'canh_bao_trang_thai_chung_tu_sua',
        'canh_bao_trang_thai_chung_tu_xoa'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ngay_ks' => 'datetime',
        'ngay_dntc' => 'datetime',
        'Round' => 'integer',
        'Round_Nt' => 'integer',
        'Round_Gia' => 'integer',
        'Round_Gia_Nt' => 'integer',
        'Quantity_decimal' => 'integer',
        'Price_decimal' => 'integer',
        'FCPrice_decimal' => 'integer',
        'FCAmount_decimal' => 'integer',
        'Kieu_Trung_So_Ct' => 'integer',
        'view_giavon' => 'boolean',
        'ngay_bdsd' => 'datetime',
        'gia_tri_dieu_chinh_toi_da' => 'float',
        'gia_tri_dieu_chinh_tien_nt_toi_da' => 'float',
        'gia_tri_dieu_chinh_gia_toi_da' => 'float',
    ];
}
