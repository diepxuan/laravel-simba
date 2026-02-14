<?php

namespace Diepxuan\Simba\Traits;

use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Config;

/**
 * Trait HasSimbaConnection
 * 
 * Overwrites legacy connection handling with modern Laravel practices.
 * Provides enhanced Simba database connection management.
 * 
 * @package Diepxuan\Simba\Traits
 */
trait HasSimbaConnection
{
    /**
     * Get the Simba database connection name.
     * Overwrites legacy connection name resolution.
     *
     * @return string
     */
    public function getSimbaConnectionName(): string
    {
        return Config::get('database.simba_connection', 'simba');
    }

    /**
     * Set the Simba database connection.
     * Overwrites legacy connection setting.
     *
     * @param  string  $connection
     * @return $this
     */
    public function setSimbaConnection(string $connection)
    {
        $this->connection = $connection;
        return $this;
    }

    /**
     * Get the Simba database connection instance.
     * Overwrites legacy connection instance retrieval.
     *
     * @return \Illuminate\Database\Connection
     */
    public function getSimbaConnection()
    {
        return DB::connection($this->getConnectionName());
    }

    /**
     * Check if Simba connection is available.
     * Overwrites legacy connection checking.
     *
     * @return bool
     */
    public function isSimbaConnectionAvailable(): bool
    {
        try {
            $this->getSimbaConnection()->getPdo();
            return true;
        } catch (\Exception $e) {
            return false;
        }
    }

    /**
     * Execute a stored procedure on Simba database.
     * Overwrites legacy stored procedure execution.
     *
     * @param  string  $procedure
     * @param  array  $parameters
     * @return mixed
     */
    public function executeSimbaStoredProcedure(string $procedure, array $parameters = [])
    {
        $connection = $this->getSimbaConnection();
        
        // Build parameter placeholders
        $placeholders = implode(', ', array_fill(0, count($parameters), '?'));
        
        // Execute stored procedure
        $result = $connection->select(
            "EXEC {$procedure} {$placeholders}",
            $parameters
        );
        
        return $result;
    }

    /**
     * Begin a transaction on Simba database.
     * Overwrites legacy transaction handling.
     *
     * @return void
     */
    public function beginSimbaTransaction()
    {
        $this->getSimbaConnection()->beginTransaction();
    }

    /**
     * Commit a transaction on Simba database.
     * Overwrites legacy transaction handling.
     *
     * @return void
     */
    public function commitSimbaTransaction()
    {
        $this->getSimbaConnection()->commit();
    }

    /**
     * Rollback a transaction on Simba database.
     * Overwrites legacy transaction handling.
     *
     * @return void
     */
    public function rollbackSimbaTransaction()
    {
        $this->getSimbaConnection()->rollBack();
    }

    /**
     * Execute a callback within a Simba transaction.
     * Overwrites legacy transaction handling.
     *
     * @param  callable  $callback
     * @return mixed
     */
    public function transaction(callable $callback)
    {
        return $this->getSimbaConnection()->transaction($callback);
    }

    /**
     * Get Simba database configuration.
     * Overwrites legacy configuration retrieval.
     *
     * @return array
     */
    public function getSimbaConfig(): array
    {
        return Config::get("database.connections.{$this->getConnectionName()}", []);
    }

    /**
     * Check if using SQL Server (Simba's database).
     * Overwrites legacy database type checking.
     *
     * @return bool
     */
    public function isSqlServer(): bool
    {
        $config = $this->getSimbaConfig();
        return ($config['driver'] ?? '') === 'sqlsrv';
    }

    /**
     * Get Simba database version.
     * Overwrites legacy version checking.
     *
     * @return string|null
     */
    public function getSimbaVersion(): ?string
    {
        try {
            $result = $this->getSimbaConnection()->selectOne('SELECT @@VERSION as version');
            return $result->version ?? null;
        } catch (\Exception $e) {
            return null;
        }
    }

    /**
     * Ping Simba database connection.
     * Overwrites legacy connection pinging.
     *
     * @return bool
     */
    public function pingSimbaConnection(): bool
    {
        try {
            $this->getSimbaConnection()->getPdo();
            return true;
        } catch (\Exception $e) {
            return false;
        }
    }

    /**
     * Reconnect to Simba database if disconnected.
     * Overwrites legacy reconnection logic.
     *
     * @return bool
     */
    public function reconnectSimbaIfNeeded(): bool
    {
        if (!$this->pingSimbaConnection()) {
            $this->getSimbaConnection()->reconnect();
            return $this->pingSimbaConnection();
        }
        
        return true;
    }
}