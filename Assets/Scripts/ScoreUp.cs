using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    public static int scoreup = 10;  //적을 처치할 때마다 얻는 점수


    // 이 스크립트가 인스턴스화가 된 오브젝트가 파괴되었을때 호출
    //즉, Monobehaviour를 상속받는 오브젝트가 사라질때 호출
    void OnDestroy()
    {
        //ScoreCount.cs 스크립트에서 가져옴
        ScoreCount.Score += scoreup;
    }
}
