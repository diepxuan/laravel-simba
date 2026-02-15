<?php

declare(strict_types=1);

/*
 * @copyright  © 2019 Dxvn, Inc.
 *
 * @author     Tran Ngoc Duc <ductn@diepxuan.com>
 * @author     Tran Ngoc Duc <caothu91@gmail.com>
 *
 * @lastupdate 2026-02-15 00:36:58
 */

namespace Diepxuan\Simba\StoredProcedures;

use Diepxuan\Simba\SModel\SModel;
use Illuminate\Support\Collection;

class AsUpdateReportChartResX
{
    /**
     * Call stored procedure asUpdateReportChartResX
     *
     * @param array $params Procedure parameters
     * @return Collection
     */
    public static function call(array $params): Collection
    {
        $connection = (new SModel())->getConnectionName();

        return ProcedureCaller::call('asUpdateReportChartResX', [
            'pMenuid' => $params['pMenuid'] ?? null,
            'pReport_code' => $params['pReport_code'] ?? null,
            'pMa_mau' => $params['pMa_mau'] ?? null,
            'pXValueMember' => $params['pXValueMember'] ?? null,
            'pYValueMembers' => $params['pYValueMembers'] ?? null,
            'pChartType' => $params['pChartType'] ?? null,
            'pArea3DEnabled' => $params['pArea3DEnabled'] ?? null,
            'pInclination' => $params['pInclination'] ?? null,
            'pPointDepth' => $params['pPointDepth'] ?? null,
            'pPointGapDepth' => $params['pPointGapDepth'] ?? null,
            'pLightStyle' => $params['pLightStyle'] ?? null,
            'pColor' => $params['pColor'] ?? null,
            'pNumber_Format' => $params['pNumber_Format'] ?? null,
            'pArea_BackColor' => $params['pArea_BackColor'] ?? null,
            'pArea_BackGradientStyle' => $params['pArea_BackGradientStyle'] ?? null,
            'pArea_BackHatchStyle' => $params['pArea_BackHatchStyle'] ?? null,
            'pSeries_BackGradientStyle' => $params['pSeries_BackGradientStyle'] ?? null,
            'pSeries_BackHatchStyle' => $params['pSeries_BackHatchStyle'] ?? null,
            'pSeries_ShadowColor' => $params['pSeries_ShadowColor'] ?? null,
            'pSeries_ShadowOffset' => $params['pSeries_ShadowOffset'] ?? null,
            'pSeries_Palette' => $params['pSeries_Palette'] ?? null,
            'pSeries_MarkerSize' => $params['pSeries_MarkerSize'] ?? null,
            'pWallWidth' => $params['pWallWidth'] ?? null,
            'pIsValueShownAsLabel' => $params['pIsValueShownAsLabel'] ?? null,
            'pDataFilter' => $params['pDataFilter'] ?? null
        ], $connection);
    }

    /**
     * Call stored procedure asUpdateReportChartResX with named parameters
     *
     * @param string $Menuid
     * @param string $Report_code
     * @param string $Ma_mau
     * @param string $XValueMember
     * @param string $YValueMembers
     * @param int $ChartType
     * @param bool $Area3DEnabled
     * @param int $Inclination
     * @param int $PointDepth
     * @param int $PointGapDepth
     * @param int $LightStyle
     * @param string $Color
     * @param string $Number_Format
     * @param string $Area_BackColor
     * @param int $Area_BackGradientStyle
     * @param int $Area_BackHatchStyle
     * @param int $Series_BackGradientStyle
     * @param int $Series_BackHatchStyle
     * @param string $Series_ShadowColor
     * @param int $Series_ShadowOffset
     * @param int $Series_Palette
     * @param int $Series_MarkerSize
     * @param int $WallWidth
     * @param bool $IsValueShownAsLabel
     * @param string $DataFilter
     * @return Collection
     */
    public static function callWithParams(string $Menuid = null, string $Report_code = null, string $Ma_mau = null, string $XValueMember = null, string $YValueMembers = null, int $ChartType = null, bool $Area3DEnabled = null, int $Inclination = null, int $PointDepth = null, int $PointGapDepth = null, int $LightStyle = null, string $Color = null, string $Number_Format = null, string $Area_BackColor = null, int $Area_BackGradientStyle = null, int $Area_BackHatchStyle = null, int $Series_BackGradientStyle = null, int $Series_BackHatchStyle = null, string $Series_ShadowColor = null, int $Series_ShadowOffset = null, int $Series_Palette = null, int $Series_MarkerSize = null, int $WallWidth = null, bool $IsValueShownAsLabel = null, string $DataFilter = null): Collection
    {
        $params = [
            'pMenuid' => $Menuid,
            'pReport_code' => $Report_code,
            'pMa_mau' => $Ma_mau,
            'pXValueMember' => $XValueMember,
            'pYValueMembers' => $YValueMembers,
            'pChartType' => $ChartType,
            'pArea3DEnabled' => $Area3DEnabled,
            'pInclination' => $Inclination,
            'pPointDepth' => $PointDepth,
            'pPointGapDepth' => $PointGapDepth,
            'pLightStyle' => $LightStyle,
            'pColor' => $Color,
            'pNumber_Format' => $Number_Format,
            'pArea_BackColor' => $Area_BackColor,
            'pArea_BackGradientStyle' => $Area_BackGradientStyle,
            'pArea_BackHatchStyle' => $Area_BackHatchStyle,
            'pSeries_BackGradientStyle' => $Series_BackGradientStyle,
            'pSeries_BackHatchStyle' => $Series_BackHatchStyle,
            'pSeries_ShadowColor' => $Series_ShadowColor,
            'pSeries_ShadowOffset' => $Series_ShadowOffset,
            'pSeries_Palette' => $Series_Palette,
            'pSeries_MarkerSize' => $Series_MarkerSize,
            'pWallWidth' => $WallWidth,
            'pIsValueShownAsLabel' => $IsValueShownAsLabel,
            'pDataFilter' => $DataFilter
        ];
        
        return self::call($params);
    }
}
