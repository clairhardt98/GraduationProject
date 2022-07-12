using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void ToGoRestart()
    {
        RoundCount.Round = 1;
        ScoreCount.Score = 0;
        SceneManager.LoadScene(0);
        GameObject.Find("Mapnumber").GetComponent<SelectMap>().GameOvertoStart();
    }

    
    public void Quit_game()
    {
        Application.Quit();
    }
    
    
}
