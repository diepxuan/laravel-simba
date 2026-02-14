<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysVoucherInfoModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysVoucherInfo';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'voucher_code';

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
        'voucher_code',
        'ph_table_name',
        'ct_table_name',
        'cp_table_name',
        'menuid',
        'ph_extra_edit_cotrol_list',
        'search_class_name',
        'view_class_name',
        'print_class_name',
        'ma_nt_default',
        'ph_carry_field_list',
        'ct_carry_field_list',
        'ph_print_field_list',
        'row_per_page',
        'number_of_copy',
        'has_cp',
        'has_tain',
        'has_taout',
        'copy_enabled',
        'copy_vaora',
        'nxt',
        'description',
        'par0',
        'par1',
        'par2',
        'par3',
        'par4',
        'par5',
        'par6',
        'par7',
        'par8',
        'par9'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'row_per_page' => 'integer',
        'number_of_copy' => 'integer',
        'has_cp' => 'boolean',
        'has_tain' => 'boolean',
        'has_taout' => 'boolean',
        'copy_enabled' => 'boolean',
        'copy_vaora' => 'boolean',
    ];
}
