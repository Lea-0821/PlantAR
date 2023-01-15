using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapModeManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject tree;
    [SerializeField] private GameObject bottle;

    private void OnEnable()
    {
        WatchInterface.NormalEvent += NormalMap;
        WatchInterface.LeftEvent += LeftMap;
        WatchInterface.RightEvent += RightMap;
    }

    private void OnDisable()
    {
        WatchInterface.NormalEvent -= NormalMap;
        WatchInterface.LeftEvent -= LeftMap;
        WatchInterface.RightEvent -= RightMap;
    }

    void NormalMap()
    {
        tree.SetActive(false);
        bottle.SetActive(false);
    }

    void LeftMap()
    {
        tree.SetActive(false);
        bottle.SetActive(true);
    }
    void RightMap()
    {
        tree.SetActive(true);
        bottle.SetActive(false);
    }

}
