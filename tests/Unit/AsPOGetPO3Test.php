<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsPOGetPO3;
use PHPUnit\Framework\TestCase;

final class AsPOGetPO3Test extends TestCase
{
    /** @var array<string, mixed> param map tu ReflectionMethod */
    private static ?array $procParams = null;

    public static function setUpBeforeClass(): void
    {
        // Dung reflection de doc cau truc parameter mapping tu call()
        $ref = new \ReflectionMethod(AsPOGetPO3::class, 'call');
        $file = file_get_contents($ref->getFileName());
        $lines = explode("\n", $file);

        $inCall = false;
        $params = [];
        foreach ($lines as $line) {
            if (str_contains($line, "ProcedureCaller::call('asPOGetPO3'")) {
                $inCall = true;
                continue;
            }
            if ($inCall) {
                if (str_contains($line, '], $connection)')) {
                    break;
                }
                // Lay cac param: 'pMa_cty' => $paramObj->pMa_cty ?? SModel::CTY,
                if (preg_match("/=>\s*\\\$paramObj->(p\w+)\s*\?\?\s*(.+),/", $line, $m)) {
                    $params[$m[1]] = [
                        'key' => $m[1],
                        'default' => trim($m[2], ' ,'),
                    ];
                }
            }
        }
        self::$procParams = $params;
    }

    public function testCallUsesTwoParameters(): void
    {
        self::assertCount(2, self::$procParams ?: []);
    }

    public function testCallHasPmaCtyParamWithDefault(): void
    {
        self::assertArrayHasKey('pMa_cty', self::$procParams ?: []);
        if (isset(self::$procParams['pMa_cty'])) {
            self::assertStringContainsString('SModel::CTY', self::$procParams['pMa_cty']['default']);
        }
    }

    public function testCallHasPsttRecParam(): void
    {
        self::assertArrayHasKey('pStt_rec', self::$procParams ?: []);
    }

    public function testCallWithParamsExists(): void
    {
        self::assertTrue(method_exists(AsPOGetPO3::class, 'callWithParams'));
    }

    public function testCallReturnsCollectionWhenDbAvailable(): void
    {
        if (!self::hasSimbaDb()) {
            $this->markTestSkipped('Requires Simba DB connection.');
        }

        $result = AsPOGetPO3::call([]);
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
