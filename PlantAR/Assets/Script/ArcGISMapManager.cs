using Esri.ArcGISMapsSDK.Components;
using Esri.ArcGISMapsSDK.Samples.Components;
using Esri.ArcGISMapsSDK.Utils.GeoCoord;
using Esri.GameEngine.Extent;
using Esri.GameEngine.Geometry;
using Esri.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]

public class ArcGISMapManager : MonoBehaviour
{
    public string APIKey = "AAPK2c7295a4d9274068a567a434ccfab6e1KrZjYxFaSehyWpTBTYMRgopMHUQRceetF0i_pRkWpqWo_jF8Aw4HjjgIudgZ3pX2";

    //ArcMap
    private ArcGISMapComponent arcGISMapComponent;
    public ArcGISPoint geographicCoordinates = new ArcGISPoint(-74.054921, 40.691242, 3000, ArcGISSpatialReference.WGS84());
    public Esri.GameEngine.Map.ArcGISMapType mapType = Esri.GameEngine.Map.ArcGISMapType.Local;

    private void Start()
    {
        CreateArcGISMapComponent();
    }


    //check if the object have ArcMap component 
    private void CreateArcGISMapComponent()
    {
        arcGISMapComponent = FindObjectOfType<ArcGISMapComponent>();

        if (!arcGISMapComponent)
        {
            var arcGISMapGameObject = new GameObject("ArcGISMap");
            arcGISMapComponent = arcGISMapGameObject.AddComponent<ArcGISMapComponent>();
        }

        //Set map origin pos
        arcGISMapComponent.OriginPosition = geographicCoordinates;
        //Set map type: local / global
        arcGISMapComponent.MapType = mapType;

        //Once the map type change, also change the setting of Basic map
        arcGISMapComponent.MapTypeChanged += new ArcGISMapComponent.MapTypeChangedEventHandler(CreateBasicArcGISMap);
    }

    public void CreateBasicArcGISMap()
    {
        var arcGISMap = new Esri.GameEngine.Map.ArcGISMap(arcGISMapComponent.MapType);

        //Set base map, could set base map Style 
        arcGISMap.Basemap = new Esri.GameEngine.Map.ArcGISBasemap(Esri.GameEngine.Map.ArcGISBasemapStyle.ArcGISImagery, APIKey);
        //Set the elevation
        arcGISMap.Elevation = new Esri.GameEngine.Map.ArcGISMapElevation(new Esri.GameEngine.Elevation.ArcGISImageElevationSource("https://elevation3d.arcgis.com/arcgis/rest/services/WorldElevation3D/Terrain3D/ImageServer", "Elevation", ""));
    }




}
