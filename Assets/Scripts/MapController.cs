using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour
{
   
    public void ToGoGameStage1()
    {
        //game이 실행되는 Scene으로 전환
        SceneManager.LoadScene(1);

    }


    public void ToGoStartScene()
    {
        SceneManager.LoadScene(0);
    }
}
