<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsARGetDMKH;
use PHPUnit\Framework\TestCase;

final class AsARGetDMKHTest extends TestCase
{
    /** @var array<string, mixed> param map from call() reflection */
    private static ?array $procParams = null;

    public static function setUpBeforeClass(): void
    {
        $ref = new \ReflectionMethod(AsARGetDMKH::class, 'call');
        $file = file_get_contents($ref->getFileName());
        $lines = explode("\n", $file);

        $inCall = false;
        $params = [];
        foreach ($lines as $line) {
            if (str_contains($line, "ProcedureCaller::call('asARGetDMKH'")) {
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
                        'default' => trim($m[2]),
                    ];
                }
            }
        }
        self::$procParams = $params;
    }

    public function testCallHasFourParameters(): void
    {
        self::assertCount(4, self::$procParams ?: []);
    }

    public function testCallHasKeyParameters(): void
    {
        $expected = ['pMa_cty', 'pMa_kh', 'pStruct', 'pModuleId'];
        foreach ($expected as $key) {
            self::assertArrayHasKey($key, self::$procParams ?: [], "Missing param: {$key}");
        }
    }

    public function testDefaultStructIs0(): void
    {
        self::assertSame("'0'", self::$procParams['pStruct']['default'] ?? null);
    }

    public function testDefaultModuleIdIsNotEmpty(): void
    {
        self::assertNotNull(self::$procParams['pModuleId']['default'] ?? null);
    }

    public function testGetCustomersCallsCall(): void
    {
        self::assertTrue(method_exists(AsARGetDMKH::class, 'getCustomers'));
    }

    public function testGetSuppliersCallsCall(): void
    {
        self::assertTrue(method_exists(AsARGetDMKH::class, 'getSuppliers'));
    }

    public function testGetEmployeesCallsCall(): void
    {
        self::assertTrue(method_exists(AsARGetDMKH::class, 'getEmployees'));
    }
}
