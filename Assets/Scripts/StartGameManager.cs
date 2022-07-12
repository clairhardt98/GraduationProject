using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGameManager : MonoBehaviour
{

    //대기시간 설정
    public int waittime;

    public GameObject Start_Menu;
    public GameObject Title_Menu;
    public GameObject ChooseMap_Menu;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayTime(waittime));
    }

    IEnumerator DelayTime(float time)
    {

        //3초 뒤에 실행
        yield return new WaitForSeconds(time);

        Start_Menu.SetActive(false);
        Title_Menu.SetActive(true);
        ChooseMap_Menu.SetActive(true);

    }

    public void ToGoGame()
    {
        //game이 실행되는 Scene으로 전환
        SceneManager.LoadScene(1);
    }

    public void ToGoChooseMap()
    {
      
        SceneManager.LoadScene(2);
    }


}
