<?php
/**
 * Ví dụ chuyển đổi stored procedure asGetRight sang PHP
 */

// Stored procedure gốc (asGetRight.sql):
/*
CREATE PROCEDURE [dbo].[asGetRight]
	@pUserName NVARCHAR(20) = '',
	@pMenuID NVARCHAR(8) = '',
	@pRet INT OUTPUT
AS
	SELECT UserName,
	       SUM(ViewRight) AS ViewRight,
	       SUM(InsertRight) AS InsertRight,
	       SUM(UpdateRight) AS UpdateRight,
	       SUM(DeleteRight) AS DeleteRight,
	       SUM(limitedprint) AS Limitedprint
	FROM   (
	           SELECT UserName,
	                  CONVERT(INT, ViewRight) AS ViewRight,
	                  CONVERT(INT, InsertRight) AS InsertRight,
	                  CONVERT(INT, UpdateRight) AS UpdateRight,
	                  CONVERT(INT, DeleteRight) AS DeleteRight,
	                  CONVERT(INT, limitedprint) AS Limitedprint
	           FROM   sysUserRight
	           WHERE  UserName = @pUserName
	                  AND MenuId = @pMenuID
	           UNION ALL
	           SELECT @pUserName AS UserName,
	                  CONVERT(INT, ViewRight) AS ViewRight,
	                  CONVERT(INT, InsertRight) AS InsertRight,
	                  CONVERT(INT, UpdateRight) AS UpdateRight,
	                  CONVERT(INT, DeleteRight) AS DeleteRight,
	                  CONVERT(INT, limitedprint) AS Limitedprint
	           FROM   sysGroupRight
	           WHERE  GroupName IN (SELECT GroupName
	                                FROM   dbo.sysUserGroup
	                                WHERE  UserName = @pUserName)
	                  AND MenuId = @pMenuID
	       ) t
	WHERE  UserName = @pUserName
	GROUP BY
	       UserName
	
	-- catch error 
	SET @pRet = @@error
*/

// PHP Class tương ứng
class GetRight {
    
    private $pdo;
    
    public function __construct(PDO $pdo) {
        $this->pdo = $pdo;
    }
    
    /**
     * Execute stored procedure: asGetRight
     * 
     * @param string $userName Tên người dùng
     * @param string $menuID Mã menu
     * @return array Kết quả quyền
     */
    public function execute($userName = '', $menuID = '') {
        $sql = "EXEC dbo.asGetRight @pUserName = :userName, @pMenuID = :menuID, @pRet = :ret OUTPUT";
        
        try {
            $stmt = $this->pdo->prepare($sql);
            
            // Bind parameters
            $stmt->bindParam(':userName', $userName, PDO::PARAM_STR);
            $stmt->bindParam(':menuID', $menuID, PDO::PARAM_STR);
            
            // Output parameter
            $ret = 0;
            $stmt->bindParam(':ret', $ret, PDO::PARAM_INT | PDO::PARAM_INPUT_OUTPUT, 4);
            
            $stmt->execute();
            
            // Fetch results
            $result = $stmt->fetchAll(PDO::FETCH_ASSOC);
            
            return [
                'data' => $result,
                'return_code' => $ret
            ];
            
        } catch (PDOException $e) {
            throw new Exception("Failed to execute asGetRight: " . $e->getMessage());
        }
    }
    
    /**
     * Alternative implementation using pure PHP (không gọi stored procedure)
     * Useful for testing or when stored procedure is not available
     */
    public function getRightsPhpVersion($userName = '', $menuID = '') {
        $sql = "
            SELECT UserName,
                   SUM(ViewRight) AS ViewRight,
                   SUM(InsertRight) AS InsertRight,
                   SUM(UpdateRight) AS UpdateRight,
                   SUM(DeleteRight) AS DeleteRight,
                   SUM(limitedprint) AS Limitedprint
            FROM   (
                       SELECT UserName,
                              CONVERT(INT, ViewRight) AS ViewRight,
                              CONVERT(INT, InsertRight) AS InsertRight,
                              CONVERT(INT, UpdateRight) AS UpdateRight,
                              CONVERT(INT, DeleteRight) AS DeleteRight,
                              CONVERT(INT, limitedprint) AS Limitedprint
                       FROM   sysUserRight
                       WHERE  UserName = :userName
                              AND MenuId = :menuID
                       UNION ALL
                       SELECT :userName AS UserName,
                              CONVERT(INT, ViewRight) AS ViewRight,
                              CONVERT(INT, InsertRight) AS InsertRight,
                              CONVERT(INT, UpdateRight) AS UpdateRight,
                              CONVERT(INT, DeleteRight) AS DeleteRight,
                              CONVERT(INT, limitedprint) AS Limitedprint
                       FROM   sysGroupRight
                       WHERE  GroupName IN (SELECT GroupName
                                            FROM   dbo.sysUserGroup
                                            WHERE  UserName = :userName2)
                              AND MenuId = :menuID2
                   ) t
            WHERE  UserName = :userName3
            GROUP BY UserName
        ";
        
        try {
            $stmt = $this->pdo->prepare($sql);
            
            // Bind parameters (note: PDO doesn't allow reuse of named parameters)
            $stmt->bindValue(':userName', $userName, PDO::PARAM_STR);
            $stmt->bindValue(':menuID', $menuID, PDO::PARAM_STR);
            $stmt->bindValue(':userName2', $userName, PDO::PARAM_STR);
            $stmt->bindValue(':menuID2', $menuID, PDO::PARAM_STR);
            $stmt->bindValue(':userName3', $userName, PDO::PARAM_STR);
            
            $stmt->execute();
            
            return $stmt->fetchAll(PDO::FETCH_ASSOC);
            
        } catch (PDOException $e) {
            throw new Exception("Failed to get user rights: " . $e->getMessage());
        }
    }
}

// Ví dụ sử dụng
class ExampleUsage {
    
    public static function main() {
        // Kết nối database
        $dsn = "sqlsrv:Server=localhost;Database=SimbaERP";
        $username = "sa";
        $password = "password";
        
        try {
            $pdo = new PDO($dsn, $username, $password);
            $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            
            // Sử dụng stored procedure
            $getRight = new GetRight($pdo);
            $result = $getRight->execute('admin', 'MN001');
            
            echo "User Rights (via stored procedure):\n";
            print_r($result);
            
            // Sử dụng PHP version
            $result2 = $getRight->getRightsPhpVersion('admin', 'MN001');
            
            echo "\nUser Rights (PHP version):\n";
            print_r($result2);
            
        } catch (PDOException $e) {
            echo "Connection failed: " . $e->getMessage();
        }
    }
}

// Service class cho module hệ thống
class SystemService {
    
    private $pdo;
    private $getRight;
    
    public function __construct(PDO $pdo) {
        $this->pdo = $pdo;
        $this->getRight = new GetRight($pdo);
    }
    
    /**
     * Kiểm tra quyền truy cập
     */
    public function checkAccess($userName, $menuID, $requiredRight = 'ViewRight') {
        $rights = $this->getRight->execute($userName, $menuID);
        
        if (empty($rights['data'])) {
            return false;
        }
        
        $userRights = $rights['data'][0];
        
        // Kiểm tra quyền cụ thể
        switch ($requiredRight) {
            case 'ViewRight':
                return $userRights['ViewRight'] > 0;
            case 'InsertRight':
                return $userRights['InsertRight'] > 0;
            case 'UpdateRight':
                return $userRights['UpdateRight'] > 0;
            case 'DeleteRight':
                return $userRights['DeleteRight'] > 0;
            case 'Limitedprint':
                return $userRights['Limitedprint'] > 0;
            default:
                return false;
        }
    }
    
    /**
     * Lấy tất cả quyền của user
     */
    public function getAllUserRights($userName) {
        // Giả sử có stored procedure asGetAllUserRights
        $sql = "EXEC dbo.asGetAllUserRights @pUserName = :userName";
        
        $stmt = $this->pdo->prepare($sql);
        $stmt->bindParam(':userName', $userName, PDO::PARAM_STR);
        $stmt->execute();
        
        return $stmt->fetchAll(PDO::FETCH_ASSOC);
    }
}

// Factory pattern để tạo các service
class SimbaServiceFactory {
    
    private static $instances = [];
    private $pdo;
    
    public function __construct(PDO $pdo) {
        $this->pdo = $pdo;
    }
    
    public function getSystemService() {
        if (!isset(self::$instances['system'])) {
            self::$instances['system'] = new SystemService($this->pdo);
        }
        return self::$instances['system'];
    }
    
    public function getAccountingService() {
        if (!isset(self::$instances['accounting'])) {
            // Tương tự cho các service khác
            self::$instances['accounting'] = new AccountingService($this->pdo);
        }
        return self::$instances['accounting'];
    }
}

// Example: AccountingService cho module kế toán
class AccountingService {
    
    private $pdo;
    
    public function __construct(PDO $pdo) {
        $this->pdo = $pdo;
    }
    
    /**
     * Lấy số dư tài khoản (tương tự stored procedure liên quan)
     */
    public function getAccountBalance($companyCode, $accountCode, $date) {
        // Sử dụng function afDuCuoiTk
        $sql = "
            SELECT * FROM dbo.afDuCuoiTk(:companyCode, :accountCode, :date, '')
        ";
        
        $stmt = $this->pdo->prepare($sql);
        $stmt->bindParam(':companyCode', $companyCode, PDO::PARAM_STR);
        $stmt->bindParam(':accountCode', $accountCode, PDO::PARAM_STR);
        $stmt->bindParam(':date', $date, PDO::PARAM_STR);
        $stmt->execute();
        
        return $stmt->fetchAll(PDO::FETCH_ASSOC);
    }
}

// Chạy ví dụ
if (php_sapi_name() === 'cli' && isset($argv[0]) && basename($argv[0]) === 'example_conversion.php') {
    ExampleUsage::main();
}

?>