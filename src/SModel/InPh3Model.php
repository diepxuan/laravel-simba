<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-21 16:36:30
 */

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;

class InPh3Model extends SModel
{
    public const PRIMARY_KEY_COLUMNS = [
        'ma_cty',
        'stt_rec',
    ];

    public const CREATED_AT = 'cdate';
    public const UPDATED_AT = 'ldate';

    /**
     * Indicates if the IDs are auto-incrementing.
     *
     * @var bool
     */
    public $incrementing = false;

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = false;

    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'InPH3';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = 'stt_rec';

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
        'ma_cty',
        'stt_rec',
        'ma_ct',
        'ma_gd',
        'ngay_ct',
        'ngay_lct',
        'so_ct',
        'so_pn',
        'ma_kh',
        'ten_kh',
        'dia_chi',
        'nguoi_gd',
        'dien_giai',
        'ma_nx',
        'ma_nt',
        'ty_gia',
        't_tien_nt',
        't_tien',
        't_so_luong',
        'px_gdd',
        'trang_thai',
        'post2gl',
        'post2in',
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
        'ngay_ct'    => 'datetime',
        'ngay_lct'   => 'datetime',
        'ty_gia'     => 'float',
        't_tien_nt'  => 'float',
        't_tien'     => 'float',
        't_so_luong' => 'float',
        'px_gdd'     => 'boolean',
        'post2gl'    => 'boolean',
        'post2in'    => 'boolean',
        'cdate'      => 'datetime',
        'ldate'      => 'datetime',
    ];
}
