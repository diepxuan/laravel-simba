<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Str;
use Diepxuan\Simba\Traits\HasSimbaConnection;

/**
 * Class SModel
 * 
 * Base SModel class for all Simba database models with enhanced features.
 * This class overwrites legacy code with modern Laravel practices.
 * 
 * @package Diepxuan\Simba\SModel
 */
class SModel extends Model
{
    use HasSimbaConnection;

    /**
     * The connection name for the model.
     * Overwrites legacy connection handling.
     *
     * @var string
     */
    protected $connection = 'simba';

    /**
     * Indicates if the model should be timestamped.
     * Overwrites legacy timestamp behavior.
     *
     * @var bool
     */
    public $timestamps = false;

    /**
     * The primary key for the model.
     * Overwrites legacy primary key handling.
     *
     * @var string
     */
    protected $primaryKey = 'id';

    /**
     * The "type" of the primary key ID.
     * Overwrites legacy ID type handling.
     *
     * @var string
     */
    protected $keyType = 'int';

    /**
     * Indicates if the IDs are auto-incrementing.
     * Overwrites legacy auto-increment handling.
     *
     * @var bool
     */
    public $incrementing = true;

    /**
     * The attributes that are mass assignable.
     * Overwrites legacy mass assignment handling.
     *
     * @var array
     */
    protected $fillable = [];

    /**
     * The attributes that should be hidden for arrays.
     * Overwrites legacy hidden attributes handling.
     *
     * @var array
     */
    protected $hidden = [];

    /**
     * The attributes that should be cast.
     * Overwrites legacy casting handling.
     *
     * @var array
     */
    protected $casts = [];

    /**
     * Get the table name.
     * Overwrites legacy table name handling.
     *
     * @return string
     */
    public function getTable()
    {
        if (isset($this->table)) {
            return $this->table;
        }

        return $this->table = str_replace('\\', '', Str::snake(Str::plural(class_basename($this))));
    }

    /**
     * Create a new instance of the model with legacy compatibility.
     * Overwrites legacy instantiation.
     *
     * @param  array  $attributes
     * @return static
     */
    public function newInstance($attributes = [], $exists = false)
    {
        $model = parent::newInstance($attributes, $exists);
        
        // Apply legacy compatibility settings
        $model->setConnection($this->connection);
        
        return $model;
    }

    /**
     * Begin querying the model with legacy table prefix.
     * Overwrites legacy query building.
     *
     * @return \Illuminate\Database\Eloquent\Builder
     */
    public static function query()
    {
        return (new static)->newQuery();
    }

    /**
     * Get all models with legacy data handling.
     * Overwrites legacy data retrieval.
     *
     * @param  array|string  $columns
     * @return \Illuminate\Database\Eloquent\Collection|static[]
     */
    public static function all($columns = ['*'])
    {
        $instance = new static;
        
        // Apply legacy filters if any
        if (method_exists($instance, 'applyLegacyFilters')) {
            $instance->applyLegacyFilters();
        }
        
        return $instance->newQuery()->get(
            is_array($columns) ? $columns : func_get_args()
        );
    }

    /**
     * Save the model to the database with legacy compatibility.
     * Overwrites legacy save behavior.
     *
     * @param  array  $options
     * @return bool
     */
    public function save(array $options = [])
    {
        // Apply legacy validation if exists
        if (method_exists($this, 'validateLegacyRules')) {
            $this->validateLegacyRules();
        }
        
        return parent::save($options);
    }

    /**
     * Delete the model from the database with legacy compatibility.
     * Overwrites legacy delete behavior.
     *
     * @return bool|null
     */
    public function delete()
    {
        // Apply legacy deletion rules if exists
        if (method_exists($this, 'beforeLegacyDelete')) {
            $this->beforeLegacyDelete();
        }
        
        $result = parent::delete();
        
        if (method_exists($this, 'afterLegacyDelete')) {
            $this->afterLegacyDelete();
        }
        
        return $result;
    }

    /**
     * Convert the model instance to an array with legacy compatibility.
     * Overwrites legacy array conversion.
     *
     * @return array
     */
    public function toArray()
    {
        $array = parent::toArray();
        
        // Add legacy fields if needed
        if (method_exists($this, 'addLegacyFieldsToArray')) {
            $array = $this->addLegacyFieldsToArray($array);
        }
        
        return $array;
    }
}