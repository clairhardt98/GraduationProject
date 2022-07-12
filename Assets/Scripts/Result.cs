using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    public void ToGoRestart()
    {
        //game이 실행되는 Scene으로 전환
        RoundCount.Round = 1;
        ScoreCount.Score = 0;
        SceneManager.LoadScene(0);
        GameObject.Find("Mapnumber").GetComponent<SelectMap>().GameCleartoStart();
    }

    
    public void Quit_game()
    {
        Application.Quit();
    }
    
}
