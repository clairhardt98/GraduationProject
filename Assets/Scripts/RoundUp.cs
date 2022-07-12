using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundUp : MonoBehaviour
{
    public static int roundup = 1;  // 라운드가 하나 올라갈때 추가하는 값

    // 이 스크립트가 인스턴스화가 된 오브젝트가 파괴되었을때 호출
    //즉, Monobehaviour를 상속받는 오브젝트가 사라질때 호출
    void OnDestroy()
    {
        //ScoreCount.cs에서의 Score가 100이 넘어간다면
        if (ScoreCount.Score == 100)
        {
            //RoundCount.cs의 Round값에 roundup값을 누적저장
            RoundCount.Round += roundup;
        }
        else if (ScoreCount.Score == 200)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 300)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 400)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 500)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 600)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 700)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 800)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 900)
        {
            RoundCount.Round += roundup;
        }

        else if (ScoreCount.Score == 1000)
        {
            RoundCount.Round += roundup;
        }

    }
}
