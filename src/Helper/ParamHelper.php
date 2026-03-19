<?php

namespace Diepxuan\Simba\Helper;

/**
 * ParamHelper - Helper class xử lý parameter không phân biệt hoa thường
 * 
 * Mục đích:
 * - Chuyển mảng thành object để truy cập qua $obj->key
 * - Truy cập key không phân biệt hoa thường (pMa_Cty = pma_cty = PMA_CTY)
 * - Giữ nguyên giá trị gốc của parameter
 * 
 * Cách dùng:
 *   $params = ['pMa_Cty' => 'ABC', 'SoCt' => '123'];
 *   $obj = ParamHelper::fromArray($params);
 *   echo $obj->pMa_Cty;  // ABC
 *   echo $obj->pma_cty;  // ABC (cùng giá trị)
 *   echo $obj->PMA_CTY;  // ABC (cùng giá trị)
 * 
 * @author Bột
 * @since 2026-03-19
 */
class ParamHelper
{
    /**
     * @var array Mảng data gốc
     */
    private array $data = [];

    /**
     * @var array Map key lowercase → key gốc (để tìm nhanh)
     */
    private array $keyMap = [];

    /**
     * Constructor
     * 
     * @param array $params Mảng parameter đầu vào
     */
    public function __construct(array $params)
    {
        $this->data = $params;
        
        // Build map: lowercase key → original key
        foreach ($params as $key => $value) {
            $lowerKey = strtolower($key);
            $this->keyMap[$lowerKey] = $key;
        }
    }

    /**
     * Factory method - tạo object từ mảng
     * 
     * @param array $params
     * @return ParamHelper
     */
    public static function fromArray(array $params): self
    {
        return new self($params);
    }

    /**
     * Magic method __get - truy cập property không phân biệt case
     * 
     * @param string $name Tên property cần lấy
     * @return mixed Giá trị của parameter, hoặc null nếu không tồn tại
     */
    public function __get(string $name)
    {
        $lowerName = strtolower($name);
        
        // Tìm key gốc trong map
        if (isset($this->keyMap[$lowerName])) {
            $originalKey = $this->keyMap[$lowerName];
            return $this->data[$originalKey];
        }

        // Không tìm thấy → trả null
        return null;
    }

    /**
     * Magic method __isset - kiểm tra property có tồn tại không
     * 
     * @param string $name
     * @return bool
     */
    public function __isset(string $name): bool
    {
        $lowerName = strtolower($name);
        return isset($this->keyMap[$lowerName]);
    }

    /**
     * Lấy tất cả keys (original case)
     * 
     * @return array
     */
    public function getKeys(): array
    {
        return array_keys($this->data);
    }

    /**
     * Lấy tất cả data dưới dạng mảng
     * 
     * @return array
     */
    public function toArray(): array
    {
        return $this->data;
    }

    /**
     * Lấy giá trị với key cụ thể (có thể chỉ định default)
     * 
     * @param string $key
     * @param mixed $default
     * @return mixed
     */
    public function get(string $key, mixed $default = null): mixed
    {
        $lowerKey = strtolower($key);
        
        if (isset($this->keyMap[$lowerKey])) {
            $originalKey = $this->keyMap[$lowerKey];
            return $this->data[$originalKey];
        }

        return $default;
    }
}
