<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-10 21:04:41
 */

namespace Diepxuan\Simba\Models;

use Illuminate\Database\Eloquent\Model;

abstract class AbstractModel extends Model
{
    /**
     * The connection name for the model.
     *
     * @var string
     */
    protected $connection;

    /**
     * Create a new Eloquent model instance.
     */
    public function __construct(array $attributes = [])
    {
        parent::__construct($attributes);
        $this->connection = config('simba.connection');
    }

    /**
     * The scope check this model is enable.
     *
     * @param mixed $query
     *
     * @return mixed
     */
    public function scopeIsEnable($query)
    {
        return $query;

        return $query->where('ksd', 0);
    }
}
