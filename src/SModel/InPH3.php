<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-23 17:44:23
 */

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;

class InPH3 extends SModel
{
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
    protected $table = 'InPH3';

    /**
     * The primary key associated with the table.
     *
     * @var string
     */
    protected $primaryKey = 'stt_rec';
}
