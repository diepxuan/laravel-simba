<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2024-05-20 16:05:52
 */

namespace Diepxuan\Simba\Models;

use Carbon\Carbon;
use Diepxuan\Simba\SModel\SiSetup;
use Diepxuan\Simba\SModel\SysCompany;
use Illuminate\Database\Eloquent\Casts\Attribute;
use Illuminate\Database\Eloquent\Relations\HasOne;

class System extends SysCompany
{
    public function siSetup(): HasOne
    {
        return $this->hasOne(SiSetup::class, 'ma_cty', 'ma_cty');
    }

    protected function khoaSo(): Attribute
    {
        return Attribute::make(
            get: fn (mixed $value, array $attributes) => Carbon::parse($this->siSetup->ngay_ks)->format('Y-m-d'),
            set: function (mixed $value): void {
                $this->siSetup->ngay_ks = Carbon::createFromFormat('Y-m-d', $value)->toDateTimeString();
                $this->push();
                $this->refresh();
            },
        );
    }
}
