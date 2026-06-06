<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-06-05 20:58:00
 */

namespace Diepxuan\Simba\Models;

use Diepxuan\Simba\SModel\SModel;

/**
 * Model SiDmCt - Khai báo màn hình nhập chứng từ.
 *
 * Source: simba-docs/tables/SiDmCt.md.
 */
class SiDmCt extends SModel
{
    public $incrementing  = false;
    public $timestamps    = false;
    protected $table      = 'SiDmCt';
    protected $primaryKey = 'ma_ct';
    protected $keyType    = 'string';

    protected $fillable = [
        'ma_cty',
        'ma_ct',
        'phan_he',
        'ma_ct_me',
        'ten_ct',
        'tk_no',
        'tk_co',
        'ma_nt',
        'so_lien',
        'stt_nkc',
        'stt_ntxt',
        'ct_dc',
        'loc_nsd',
        'vv',
        'spct',
        'phi',
        'bp',
        'lo',
        'sp_post',
        'sp_process',
        'ph',
        'ct',
        'sd',
        'nxt',
        'menuid',
        'vn_prefix',
        'vn_postfix',
        'vn_sequence',
        'vn_pattern',
        'vn_width',
        'PhFieldlist2IN',
        'CtFieldlist2IN',
        'kieu_trung_so_ct',
        'VoucherGetWhenOpenForm',
    ];

    protected $casts = [
        'so_lien'         => 'integer',
        'stt_nkc'         => 'integer',
        'stt_ntxt'        => 'integer',
        'ct_dc'           => 'boolean',
        'loc_nsd'         => 'boolean',
        'vv'              => 'boolean',
        'spct'            => 'boolean',
        'phi'             => 'boolean',
        'bp'              => 'boolean',
        'lo'              => 'boolean',
        'sd'              => 'boolean',
        'vn_sequence'            => 'integer',
        'vn_width'               => 'integer',
        'kieu_trung_so_ct'       => 'integer',
        'VoucherGetWhenOpenForm' => 'boolean',
    ];

    /**
     * Scope: find voucher metadata by company and voucher code.
     *
     * @param mixed $query
     */
    public function scopeVoucher($query, string $maCt, string $maCty = SModel::CTY)
    {
        return $query->where('ma_cty', $maCty)->where('ma_ct', $maCt);
    }

    /**
     * Scope: find voucher metadata by Simba menuid.
     *
     * @param mixed $query
     */
    public function scopeMenuId($query, string $menuId)
    {
        return $query->where('menuid', $menuId);
    }

    /**
     * @return list<string>
     */
    public function headerFieldsForInventory(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->PhFieldlist2IN))));
    }

    /**
     * @return list<string>
     */
    public function detailFieldsForInventory(): array
    {
        return array_values(array_filter(array_map('trim', explode(',', (string) $this->CtFieldlist2IN))));
    }
}
