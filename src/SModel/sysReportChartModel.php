<?php

namespace Diepxuan\Simba\SModel;

use Illuminate\Database\Eloquent\Model;
use Diepxuan\Simba\SModel\SModel;

class sysReportChartModel extends SModel
{
    /**
     * The table associated with the model.
     *
     * @var string
     */
    protected $table = 'sysReportChart';

    /**
     * The primary key for the model.
     *
     * @var string
     */
    protected $primaryKey = 'menuid';

    /**
     * Indicates if the model should be timestamped.
     *
     * @var bool
     */
    public $timestamps = false;

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
        'menuid',
        'report_code',
        'ma_mau',
        'XValueMember',
        'YValueMembers',
        'ChartType',
        'Area3DEnabled',
        'Inclination',
        'PointDepth',
        'PointGapDepth',
        'LightStyle',
        'Color',
        'Number_Format',
        'Area_BackColor',
        'Area_BackGradientStyle',
        'Area_BackHatchStyle',
        'Series_BackGradientStyle',
        'Series_BackHatchStyle',
        'Series_ShadowColor',
        'Series_ShadowOffset',
        'Series_Palette',
        'Series_MarkerSize',
        'WallWidth',
        'IsValueShownAsLabel',
        'DataFilter'
    ];

    /**
     * The attributes that should be cast.
     *
     * @var array
     */
    protected $casts = [
        'ChartType' => 'integer',
        'Area3DEnabled' => 'boolean',
        'Inclination' => 'integer',
        'PointDepth' => 'integer',
        'PointGapDepth' => 'integer',
        'LightStyle' => 'integer',
        'Area_BackGradientStyle' => 'integer',
        'Area_BackHatchStyle' => 'integer',
        'Series_BackGradientStyle' => 'integer',
        'Series_BackHatchStyle' => 'integer',
        'Series_ShadowOffset' => 'integer',
        'Series_Palette' => 'integer',
        'Series_MarkerSize' => 'integer',
        'WallWidth' => 'integer',
        'IsValueShownAsLabel' => 'boolean',
    ];
}
