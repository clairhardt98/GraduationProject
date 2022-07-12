using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoundCount : MonoBehaviour
{
    public static int Round=1;  //라운드
    //public string suffixRound = null; //라운드의 뒷숫자 추가
    public Text Round_txt = null;  //화면에 점수 보여주는것 초기화

    public static RoundCount myinstance = null;  // 싱글톤 기법을 위해 하나의 객체를 유지

    //start()보다 먼저 호출되며, 모든 변수를 초기화하기 위해 사용
    void Awake()
    {
        if (myinstance == null)  //시스템안에서 내가 존재하지 않을 경우
        {
            myinstance = this;  //나를 myinstance에 저장
            DontDestroyOnLoad(gameObject);  //Scene이 바뀌어도 gameObject 데이터 유지
        }
    }

    void Update()
    {
        if (Round_txt != null)
        {
            // Round이름을 문자열로변환. 게임이 시작되면 Round부분의 뒷부분이 설정된 숫자로 추가됨
            //Round_txt.text = Round.ToString() + suffixRound;
            Round_txt.text = Round.ToString();
        }


    }


}
