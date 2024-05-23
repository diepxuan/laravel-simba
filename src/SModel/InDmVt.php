<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-23 14:19:36
 */

namespace Diepxuan\Simba\SModel;

use Diepxuan\Models\Traits\HasCompositePrimaryKey;
use Illuminate\Database\Eloquent\Model;

class InDmVt extends SModel
{
    use HasCompositePrimaryKey;

    public const CREATED_AT = 'cDate';
    public const UPDATED_AT = 'lDate';

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
    protected $table = 'InDmVt';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = ['ma_cty', 'ma_vt'];

    /**
     * Get the attributes that should be cast.
     *
     * @return array<string, string>
     */
    protected function casts(): array
    {
        return [
            'ksd' => 'boolean',
        ];
    }
}
