using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemanager : MonoBehaviour
{
    public GameObject SelectNode;
    public GameObject Tower;
    public static cubemanager instance;  //일종의 프렌드처리

    void Start()
    {
        instance = this;  //instance변수에 빌드매니저를 저장(나 자신 저장)
    }

    public void BuildToTower()  //타워 만드는 함수
    {
        Instantiate(Tower, SelectNode.transform.position, Quaternion.identity);  //생성함수
    }
    
}
