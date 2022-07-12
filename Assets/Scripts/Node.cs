using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color StartColor;
    public Color SelectColor;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();  //렌더러 컴포넌트 저장
        StartColor = rend.material.color;  //스타트컬러에 대입
    }

    private void OnMouseUp()  //마우스를 클릭한 후 뗐을때
    {
        rend.material.color = SelectColor;  //이건 내가 material을 만들고, mesh renderer의 element()에 넣어준것 불러옴
        cubemanager.instance.SelectNode = this.gameObject;  //큐브매니저 스크립트에서 가져다 쓴것.
    }
}
