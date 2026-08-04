<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsARUpdDMKH;
use PHPUnit\Framework\TestCase;

final class AsARUpdDMKHTest extends TestCase
{
    /** @var array<string, array{key: string, default: string}> */
    private static ?array $procParams = null;

    public static function setUpBeforeClass(): void
    {
        $ref = new \ReflectionMethod(AsARUpdDMKH::class, 'call');
        $file = file_get_contents($ref->getFileName());
        $lines = explode("\n", $file);

        $inCall = false;
        $params = [];
        foreach ($lines as $line) {
            if (str_contains($line, "ProcedureCaller::call('asARUpdDMKH'")) {
                $inCall = true;
                continue;
            }
            if ($inCall) {
                if (str_contains($line, '], $connection)')) {
                    break;
                }
                if (preg_match("/'(p\w+)'\s*=>\s*\\\$paramObj->p\w+\s*\?\?\s*(.+),/", $line, $m)) {
                    $params[$m[1]] = [
                        'key' => $m[1],
                        'default' => trim($m[2], " ,'"),
                    ];
                }
            }
        }
        self::$procParams = $params;
    }

    public function testCallHas36InputParameters(): void
    {
        $count = count(self::$procParams ?: []);
        $this->assertGreaterThanOrEqual(36, $count,
            'Should have at least 36 input params; got ' . $count
        );
    }

    public function testCallHasAllKeyParameters(): void
    {
        $expected = [
            'pMa_cty', 'pMa_kh', 'pLoai',
            'pTen_kh', 'pMa_so_thue', 'pDia_chi', 'pTel', 'pFax', 'pEmail',
            'pHome_page', 'pNguoi_gd', 'pMa_ngh', 'pTen_nh', 'pCn_nh',
            'pSo_tk_nh', 'pTinh_tp_nh', 'pTk',
            'pMa_plkh1', 'pMa_plkh2', 'pMa_plkh3', 'pMa_nhkh', 'pMa_tt',
            'pMa_httt', 'pMa_httt_po',
            'pGh_no', 'pHan_ck', 'pTl_ck', 'pHan_tt', 'pLs_qh',
            'pGhi_chu', 'pTinh_dt_nb',
            'pIskh', 'pIsncc', 'pIsnv', 'pKsd',
            'pLUser',
        ];
        $actualKeys = array_keys(self::$procParams ?? []);
        foreach ($expected as $key) {
            self::assertArrayHasKey($key, self::$procParams ?: [], "Missing param: {$key}");
        }
    }

    public function testCallDeclaresOutputPRet(): void
    {
        $file = file_get_contents((new \ReflectionMethod(\Diepxuan\Simba\StoredProcedures\AsARUpdDMKH::class, 'call'))->getFileName());

        self::assertStringContainsString("'pRet'", $file);
        self::assertStringContainsString("'output' => true", $file);
    }
}
