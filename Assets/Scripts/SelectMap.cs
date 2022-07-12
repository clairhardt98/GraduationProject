using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMap : MonoBehaviour
{
    public int MapNum;
    public GameObject MapNumObj;

    public void numload()
    {
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(MapNumObj);
    }

    // Map을 다시 선택할때, Mapnumber가 DontDestroyOnLoad에 적용되지 않도록....
    public void GametoStart()
    {

     if (SceneManager.GetActiveScene().name == "GameScene")
        {
            Destroy(MapNumObj);
        }
    }

    public void GameOvertoStart()
    {

        if (SceneManager.GetActiveScene().name == "GameOverScene")
        {
            Destroy(MapNumObj);
        }
    }

    public void GameCleartoStart()
    {

        if (SceneManager.GetActiveScene().name == "ResultScene")
        {
            Destroy(MapNumObj);
        }
    }
}
