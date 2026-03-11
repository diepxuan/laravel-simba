<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-03-11 16:10:00
 */

namespace Diepxuan\Simba\SModel;

use Diepxuan\Simba\SModel\SModel;

/**
 * Model ArDmKh - Danh mục khách hàng.
 *
 * Gộp từ ArDmKh.php và ArDmKhModel.php
 */
class ArDmKhModel extends SModel
{
    /**
     * Indicates if the IDs are auto-incrementing.
     *
     * @var bool
     */
    public $incrementing = false;

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'ArDmKh';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = 'ma_kh';

    /**
     * The "type" of the primary key ID.
     *
     * @var string
     */
    protected $keyType = 'string';

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public const CREATED_AT = 'cdate';
    public const UPDATED_AT = 'ldate';

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
        'ma_cty',
        'ma_kh',
        'loai',
        'ten_kh',
        'ma_so_thue',
        'dia_chi',
        'tel',
        'fax',
        'email',
        'home_page',
        'nguoi_gd',
        'ma_ngh',
        'ten_nh',
        'cn_nh',
        'so_tk_nh',
        'tinh_tp_nh',
        'tk',
        'ma_plkh1',
        'ma_plkh2',
        'ma_plkh3',
        'ma_nhkh',
        'ma_tt',
        'ma_httt',
        'ma_httt_po',
        'gh_no',
        'han_ck',
        'tl_ck',
        'han_tt',
        'ls_qh',
        'ghi_chu',
        'tinh_dt_nb',
        'isKh',
        'isNcc',
        'isNv',
        'ksd',
        'cdate',
        'cuser',
        'ldate',
        'luser',
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'gh_no'      => 'float',
        'han_ck'     => 'float',
        'tl_ck'      => 'float',
        'han_tt'     => 'float',
        'ls_qh'      => 'float',
        'tinh_dt_nb' => 'boolean',
        'isKh'       => 'boolean',
        'isNcc'      => 'boolean',
        'isNv'       => 'boolean',
        'ksd'        => 'boolean',
        'cdate'      => 'datetime',
        'ldate'      => 'datetime',
    ];
}
