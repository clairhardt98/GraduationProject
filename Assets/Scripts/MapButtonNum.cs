using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MapButtonNum : MonoBehaviour
{
    public SelectMap mapnums;

    public void OnClickButtonNum()
    {
        string MapButtonNum = EventSystem.current.currentSelectedGameObject.name;

        if (MapButtonNum == "Default")
            mapnums.MapNum = 1;

        else if (MapButtonNum == "501")
            mapnums.MapNum = 2;

        else if (MapButtonNum == "601")
            mapnums.MapNum = 3;

        else if (MapButtonNum == "man")
            mapnums.MapNum = 4;
        
        
        if (mapnums.MapNum != 0)
            mapnums.numload();
            
    }
}
