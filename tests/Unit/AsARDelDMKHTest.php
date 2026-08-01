<?php

declare(strict_types=1);

namespace Diepxuan\Simba\Tests\Unit;

use Diepxuan\Simba\StoredProcedures\AsARDelDMKH;
use PHPUnit\Framework\TestCase;

final class AsARDelDMKHTest extends TestCase
{
    /** @var array<string, mixed> param map from call() reflection */
    private static ?array $procParams = null;

    public static function setUpBeforeClass(): void
    {
        $ref = new \ReflectionMethod(AsARDelDMKH::class, 'call');
        $file = file_get_contents($ref->getFileName());
        $lines = explode("\n", $file);

        $inCall = false;
        $params = [];
        foreach ($lines as $line) {
            if (str_contains($line, "ProcedureCaller::call('asARDelDMKH'")) {
                $inCall = true;
                continue;
            }
            if ($inCall) {
                if (str_contains($line, '], $connection)')) {
                    break;
                }
                if (preg_match("/'(p\w+)'\s*=>\s*\\\$paramObj->(p\w+)\s*\?\?\s*(.+),/", $line, $m)) {
                    $params[$m[1]] = [
                        'key' => $m[1],
                        'default' => trim($m[2], " ,'"),
                    ];
                }
            }
        }
        self::$procParams = $params;
    }

    public function testCallHasTwoParameters(): void
    {
        self::assertCount(2, self::$procParams ?: []);
    }

    public function testCallHasKeyParameters(): void
    {
        $expected = ['pMa_cty', 'pMa_kh'];
        foreach ($expected as $key) {
            self::assertArrayHasKey($key, self::$procParams ?: [], "Missing param: {$key}");
        }
    }
}
