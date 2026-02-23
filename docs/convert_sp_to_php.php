<?php
/**
 * Script chuyển đổi Stored Procedure SimbaSql sang PHP Class
 * 
 * Cấu trúc:
 * 1. Đọc file SQL stored procedure
 * 2. Parse parameters và logic
 * 3. Tạo PHP class tương ứng
 * 4. Generate method với PDO prepared statements
 */

class SimbaSqlToPhpConverter {
    
    /**
     * Parse stored procedure từ file SQL
     */
    public function parseStoredProcedure($sqlFile) {
        $content = file_get_contents($sqlFile);
        
        // Extract procedure name
        preg_match('/CREATE\s+PROCEDURE\s+\[dbo\]\.\[([^\]]+)\]/i', $content, $matches);
        $procedureName = $matches[1] ?? '';
        
        // Extract parameters
        preg_match('/AS\s+BEGIN(.*?)END/si', $content, $bodyMatch);
        $body = $bodyMatch[1] ?? $content;
        
        // Extract parameter section
        preg_match('/CREATE\s+PROCEDURE[^(]*\((.*?)\)\s+AS/si', $content, $paramMatch);
        $paramSection = $paramMatch[1] ?? '';
        
        $parameters = $this->parseParameters($paramSection);
        
        return [
            'name' => $procedureName,
            'parameters' => $parameters,
            'body' => $body,
            'original_sql' => $content
        ];
    }
    
    /**
     * Parse parameters từ SQL
     */
    private function parseParameters($paramSection) {
        $params = [];
        $lines = explode("\n", $paramSection);
        
        foreach ($lines as $line) {
            $line = trim($line);
            if (empty($line) || strpos($line, '--') === 0) {
                continue;
            }
            
            // Remove trailing comma
            $line = rtrim($line, ',');
            
            // Match parameter pattern: @pName type
            if (preg_match('/@(\w+)\s+(\w+)(?:\s*\([^)]+\))?/', $line, $matches)) {
                $params[] = [
                    'name' => $matches[1],
                    'type' => $matches[2],
                    'original' => $line
                ];
            }
        }
        
        return $params;
    }
    
    /**
     * Generate PHP class từ stored procedure
     */
    public function generatePhpClass($procedureInfo) {
        $className = $this->convertToClassName($procedureInfo['name']);
        $methodName = lcfirst($className);
        
        $params = $procedureInfo['parameters'];
        $paramDefinitions = [];
        $paramCalls = [];
        $pdoParams = [];
        
        foreach ($params as $param) {
            $phpParamName = lcfirst(str_replace('p', '', $param['name']));
            $paramDefinitions[] = '$' . $phpParamName;
            $paramCalls[] = ':' . $param['name'];
            $pdoParams[] = "        \$stmt->bindParam('{$param['name']}', \${$phpParamName}, PDO::PARAM_STR);";
        }
        
        $paramDefString = implode(', ', $paramDefinitions);
        $paramCallString = implode(', ', $paramCalls);
        $pdoParamsString = implode("\n", $pdoParams);
        
        $phpClass = <<<PHP
<?php
/**
 * Class {$className}
 * Generated from stored procedure: {$procedureInfo['name']}
 */
class {$className} {
    
    private \$pdo;
    
    public function __construct(PDO \$pdo) {
        \$this->pdo = \$pdo;
    }
    
    /**
     * Execute stored procedure: {$procedureInfo['name']}
     */
    public function execute({$paramDefString}) {
        \$sql = "EXEC {$procedureInfo['name']} {$paramCallString}";
        
        try {
            \$stmt = \$this->pdo->prepare(\$sql);
            
{$pdoParamsString}
            
            \$stmt->execute();
            
            // For SELECT procedures, fetch results
            if (stripos('{$procedureInfo['body']}', 'SELECT') !== false) {
                return \$stmt->fetchAll(PDO::FETCH_ASSOC);
            }
            
            // For INSERT/UPDATE/DELETE, return affected rows
            return \$stmt->rowCount();
            
        } catch (PDOException \$e) {
            throw new Exception("Failed to execute {$procedureInfo['name']}: " . \$e->getMessage());
        }
    }
    
    /**
     * Alternative method using direct call
     */
    public function {$methodName}({$paramDefString}) {
        return \$this->execute({$paramDefString});
    }
}

PHP;
        
        return $phpClass;
    }
    
    /**
     * Convert procedure name to class name
     */
    private function convertToClassName($procedureName) {
        // Remove 'as' prefix if present
        $name = preg_replace('/^as/', '', $procedureName);
        
        // Convert to CamelCase
        $name = preg_replace_callback('/[A-Z]/', function($matches) {
            return $matches[0];
        }, $name);
        
        return ucfirst($name);
    }
    
    /**
     * Generate repository class for multiple procedures
     */
    public function generateRepositoryClass($procedures) {
        $className = 'SimbaSqlRepository';
        
        $methods = [];
        foreach ($procedures as $proc) {
            $methodName = lcfirst($this->convertToClassName($proc['name']));
            $params = array_map(function($p) {
                return '$' . lcfirst(str_replace('p', '', $p['name']));
            }, $proc['parameters']);
            
            $paramString = implode(', ', $params);
            
            $methods[] = <<<PHP
    
    /**
     * Execute: {$proc['name']}
     */
    public function {$methodName}({$paramString}) {
        \$proc = new {$this->convertToClassName($proc['name'])}(\$this->pdo);
        return \$proc->execute({$paramString});
    }

PHP;
        }
        
        $methodsString = implode("\n", $methods);
        
        $repositoryClass = <<<PHP
<?php
/**
 * SimbaSql Repository
 * Centralized access to all stored procedures
 */
class {$className} {
    
    private \$pdo;
    
    public function __construct(PDO \$pdo) {
        \$this->pdo = \$pdo;
    }
    
{$methodsString}
}

PHP;
        
        return $repositoryClass;
    }
}

// Example usage
if (php_sapi_name() === 'cli' && isset(\$argv[1])) {
    \$converter = new SimbaSqlToPhpConverter();
    
    // Parse single procedure
    \$procInfo = \$converter->parseStoredProcedure(\$argv[1]);
    \$phpClass = \$converter->generatePhpClass(\$procInfo);
    
    echo \$phpClass;
    
    // Save to file
    \$className = \$converter->convertToClassName(\$procInfo['name']);
    file_put_contents(\$className . '.php', \$phpClass);
    
    echo "Generated: {\$className}.php\n";
}

// Batch conversion example
function batchConvert(\$directory) {
    \$converter = new SimbaSqlToPhpConverter();
    \$procedures = [];
    
    \$files = glob(\$directory . '/*.sql');
    foreach (\$files as \$file) {
        try {
            \$procInfo = \$converter->parseStoredProcedure(\$file);
            \$procedures[] = \$procInfo;
            
            // Generate individual class
            \$phpClass = \$converter->generatePhpClass(\$procInfo);
            \$className = \$converter->convertToClassName(\$procInfo['name']);
            file_put_contents(\$className . '.php', \$phpClass);
            
            echo "Generated: {\$className}.php\n";
        } catch (Exception \$e) {
            echo "Error processing {\$file}: " . \$e->getMessage() . "\n";
        }
    }
    
    // Generate repository
    if (!empty(\$procedures)) {
        \$repoClass = \$converter->generateRepositoryClass(\$procedures);
        file_put_contents('SimbaSqlRepository.php', \$repoClass);
        echo "Generated: SimbaSqlRepository.php\n";
    }
}

// Usage instructions
echo "\n\n=== USAGE ===\n";
echo "Single file: php convert_sp_to_php.php path/to/procedure.sql\n";
echo "Batch: batchConvert('path/to/procedures/directory');\n";

?>