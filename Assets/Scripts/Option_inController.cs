using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Option_inController : MonoBehaviour
{
    public GameObject Option_button;
    public GameObject Option_in;
   
    //옵션을 켰을때 게임의 진행을 정지하도록
    public void Option_Tab()
    {
        Time.timeScale = 0;  //0이면 일시정지
        Option_button.SetActive(false);  //옵션버튼 사라짐
        Option_in.SetActive(true);  //옵션창 생성

    } 

    public void Go_to_title()
    {
        Time.timeScale = 1;
        Option_button.SetActive(true);
        RoundCount.Round = 1;
        ScoreCount.Score = 0;
        SceneManager.LoadScene(0);
        GameObject.Find("Mapnumber").GetComponent<SelectMap>().GametoStart();

    }

    public void Option_Close()
    {
        Time.timeScale = 1;
        Option_in.SetActive(false);
        Option_button.SetActive(true);
    }
}


