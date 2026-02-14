<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysReportResxModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysReportResx';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'menuid';

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
        'menuid',
        'ma_mau',
        'language',
        'ten_mau',
        'title',
        'mau_so_qd15',
        'mau_so_qd48',
        'formated_col_list',
        'ct_formated_col_list',
        'formated_col_list_nt',
        'ct_formated_col_list_nt',
        'auto_format',
        'hide_col_list',
        'hide_col_list_nt',
        'description',
        'export2excel_col_list'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
    ];

}
