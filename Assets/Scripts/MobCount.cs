using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MobCount : MonoBehaviour
{
    public static int MobCount_;
    public Text MobCount_txt = null;  //화면에 보여지는 것 초기화

    public static MobCount myinstance = null;  // 싱글톤 기법을 위해 하나의 객체를 유지

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
        if (MobCount_txt != null)
        {
            GameObject[] MobCount__ = GameObject.FindGameObjectsWithTag("Monster");
            // Score이름을 문자열로변환. 게임이 시작되면 Score부분의 뒷부분이 설정된 숫자로 추가됨
            MobCount_txt.text = MobCount_.ToString() + MobCount__.Length;

            // 이건 유저가 지정함. 생성된 Mob의 갯수넘어가면 게임오버 Scene으로 변경. 
            if(MobCount__.Length >= 10)
            {
             
                SceneManager.LoadScene(3);

                if(RoundCount.Round==1)
                {
                    RoundCount.Round = 1;
                    ScoreCount.Score -= (ScoreUp.scoreup * 10);
                }
                else
                {

                RoundCount.Round -= RoundUp.roundup;
                ScoreCount.Score -= (ScoreUp.scoreup*10);
                }
                
            }

        }
    }


}
