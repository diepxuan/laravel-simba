<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsPODeletePO3;
use PHPUnit\Framework\TestCase;

final class AsPODeletePO3Test extends TestCase
{
    /** @var array<string, mixed> */
    private static ?array $procParams = null;

    public static function setUpBeforeClass(): void
    {
        $ref = new \ReflectionMethod(AsPODeletePO3::class, 'call');
        $file = file_get_contents($ref->getFileName());
        $lines = explode("\n", $file);

        $inCall = false;
        $params = [];
        foreach ($lines as $line) {
            if (str_contains($line, "ProcedureCaller::call('asPODeletePO3'")) {
                $inCall = true;
                continue;
            }
            if ($inCall) {
                if (str_contains($line, '], $connection)')) {
                    break;
                }
                // Pattern 1: param tu $paramObj
                if (preg_match("/=>\s*\\\$paramObj->(p\w+)\s*\?\?\s*(.+),/", $line, $m)) {
                    $params[$m[1]] = [
                        'key' => $m[1],
                        'default' => trim($m[2], ' ,'),
                    ];
                    continue;
                }
                // Pattern 2: output param (pRet)
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

    public function testCallHasThreeParameters(): void
    {
        self::assertCount(3, self::$procParams ?? []);
    }

    public function testCallHasPmaCtyParam(): void
    {
        self::assertArrayHasKey('pMa_cty', self::$procParams ?? []);
    }

    public function testCallHasPsttRecParam(): void
    {
        self::assertArrayHasKey('pStt_rec', self::$procParams ?? []);
    }

    public function testCallHasPRetOutputParam(): void
    {
        self::assertArrayHasKey('pRet', self::$procParams ?? []);
        self::assertSame('array', self::$procParams['pRet']['default'] ?? null);
    }

    public function testCallWithParamsExists(): void
    {
        self::assertTrue(method_exists(AsPODeletePO3::class, 'callWithParams'));
    }

    public function testCallReturnsCollectionWhenDbAvailable(): void
    {
        if (!self::hasSimbaDb()) {
            $this->markTestSkipped('Requires Simba DB connection.');
        }

        $result = AsPODeletePO3::call([]);
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
