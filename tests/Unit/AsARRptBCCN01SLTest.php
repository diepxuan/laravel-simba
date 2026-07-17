<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsARRptBCCN01SL;
use PHPUnit\Framework\TestCase;

final class AsARRptBCCN01SLTest extends TestCase
{
    public function testProcedureParamsNormalizesAllSixKeysFromMainAlias(): void
    {
        $params = AsARRptBCCN01SL::procedureParams([
            'ma_cty' => '001',
            'Ngay1'  => '2026-01-01',
            'Ngay2'  => '2026-01-31',
            'Tk'     => '331',
            'ma_kh'  => 'NCC01',
            'ma_nt'  => '',
        ]);

        self::assertSame([
            'ma_cty' => '001',
            'Ngay1'  => '2026-01-01',
            'Ngay2'  => '2026-01-31',
            'Tk'     => '331',
            'ma_kh'  => 'NCC01',
            'ma_nt'  => '',
        ], $params);
    }

    public function testProcedureParamsAcceptsLegacyPNamespaceAlias(): void
    {
        $params = AsARRptBCCN01SL::procedureParams([
            'pMa_cty' => '001',
            'pNgay1'  => '2026-01-01',
            'pNgay2'  => '2026-01-31',
            'pTk'     => '331',
            'pMa_kh'  => 'NCC01',
            'pMa_nt'  => 'VND',
        ]);

        self::assertSame('001', $params['ma_cty']);
        self::assertSame('2026-01-01', $params['Ngay1']);
        self::assertSame('2026-01-31', $params['Ngay2']);
        self::assertSame('331', $params['Tk']);
        self::assertSame('NCC01', $params['ma_kh']);
        self::assertSame('VND', $params['ma_nt']);
    }

    public function testProcedureParamsAcceptsCompanyIdAliasForMaCty(): void
    {
        $params = AsARRptBCCN01SL::procedureParams([
            'pCompanyID' => '007',
            'pNgay1'     => '2026-02-01',
            'pNgay2'     => '2026-02-28',
            'pTk'        => '331',
            'pMa_kh'     => 'NCC02',
        ]);

        self::assertSame('007', $params['ma_cty']);
        self::assertNull($params['ma_nt']);
    }

    public function testProcedureParamsReturnsNullsForMissingKeys(): void
    {
        self::assertSame([
            'ma_cty' => null,
            'Ngay1'  => null,
            'Ngay2'  => null,
            'Tk'     => null,
            'ma_kh'  => null,
            'ma_nt'  => null,
        ], AsARRptBCCN01SL::procedureParams([]));
    }
}
