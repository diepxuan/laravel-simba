<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsPOSavePO3;
use PHPUnit\Framework\TestCase;

final class AsPOSavePO3Test extends TestCase
{
    /** @var array<string, array{key: string, default: string}> */
    private static ?array $procParams = null;

    public static function setUpBeforeClass(): void
    {
        $ref = new \ReflectionMethod(AsPOSavePO3::class, 'call');
        $file = file_get_contents($ref->getFileName());
        $lines = explode("\n", $file);

        $inCall = false;
        $params = [];
        foreach ($lines as $line) {
            if (str_contains($line, "ProcedureCaller::call('asPOSavePO3'")) {
                $inCall = true;
                continue;
            }
            if ($inCall) {
                if (str_contains($line, '], $connection)')) {
                    break;
                }
                // Pattern 1: param tu $paramObj (co ?? default)
                if (preg_match("/=>\s*\\\$paramObj->(p\w+)\s*\?\?\s*(.+),/", $line, $m)) {
                    $params[$m[1]] = [
                        'key' => $m[1],
                        'default' => trim($m[2], ' ,'),
                    ];
                    continue;
                }
                // Pattern 2: output param (pRet) co array value
                if (preg_match("/'(p\w+)'\s*=>\s*\[/", $line, $m)) {
                    $params[$m[1]] = [
                        'key' => $m[1],
                        'default' => 'array',
                    ];
                }
            }
        }
        self::$procParams = $params;
    }

    public function testCallHasKeyStructuralParameters(): void
    {
        $expectedKeys = [
            'pMa_cty', 'pStt_rec', 'pMa_ct', 'pMa_kh',
            'pMa_httt', 'pTk_pt', 'pDien_giai', 'pSo_hd',
            'pNgay_hd', 'pNgay_ct', 'pNgay_lct', 'pMa_nt',
            'pTy_gia',
            'pT_tien_nt0', 'pT_tien0', 'pT_cp_nt', 'pT_cp',
            'pT_thue_nt', 'pT_thue', 'pT_ck', 'pT_ck_nt',
            'pT_tt', 'pT_tt_nt', 'pT_so_luong',
            'pChiTiet', 'pChiPhi', 'pRet',
        ];
        $actualKeys = array_keys(self::$procParams ?? []);

        foreach ($expectedKeys as $key) {
            self::assertArrayHasKey($key, self::$procParams ?: [], "Missing param: {$key}");
        }
    }

    public function testCallHasAtLeast50Parameters(): void
    {
        self::assertGreaterThanOrEqual(50, count(self::$procParams ?? []),
            'AsPOSavePO3 should have 50+ parameters in call()');
    }

    public function testDefaultMaCtIsPO3(): void
    {
        self::assertSame("'PO3'", self::$procParams['pMa_ct']['default'] ?? null);
    }

    public function testDefaultMaNtIsVND(): void
    {
        self::assertSame("'VND'", self::$procParams['pMa_nt']['default'] ?? null);
    }

    public function testDefaultTyGiaIs1(): void
    {
        self::assertSame('1', self::$procParams['pTy_gia']['default'] ?? null);
    }

    public function testDefaultKhtTainIs0(): void
    {
        self::assertSame('0', self::$procParams['pKht_tain']['default'] ?? null);
    }

    public function testDefaultPost2glIs0(): void
    {
        self::assertSame('0', self::$procParams['pPost2gl']['default'] ?? null);
    }

    public function testDefaultPost2inIs0(): void
    {
        self::assertSame('0', self::$procParams['pPost2in']['default'] ?? null);
    }

    public function testChiTietDefaultsToEmptyArray(): void
    {
        self::assertSame('[]', self::$procParams['pChiTiet']['default'] ?? null);
    }

    public function testChiPhiDefaultsToEmptyArray(): void
    {
        self::assertSame('[]', self::$procParams['pChiPhi']['default'] ?? null);
    }

    public function testHasPRetOutputParam(): void
    {
        self::assertArrayHasKey('pRet', self::$procParams ?: []);
        self::assertSame('array', self::$procParams['pRet']['default'] ?? null);
    }

    public function testCallReturnsCollectionWhenDbAvailable(): void
    {
        if (!self::hasSimbaDb()) {
            $this->markTestSkipped('Requires Simba DB connection.');
        }

        $result = AsPOSavePO3::call([]);
        self::assertInstanceOf(\Illuminate\Support\Collection::class, $result);
    }

    private static function hasSimbaDb(): bool
    {
        try {
            return \DB::connection('sqlsrv')->getPdo() !== null;
        } catch (\Throwable) {
            return false;
        }
    }
}
