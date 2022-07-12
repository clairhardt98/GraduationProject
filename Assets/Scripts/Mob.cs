using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mob : MonoBehaviour
{
    public GameObject DamageText;
    public GameObject TextPos;  //데미지 텍스트가 위치할 곳

    public float StartHealth;  //시작체력
    public float Health;  //현재체력
    public GameObject HpHealth;


    public void GetDamage(int damage)
    {
        GameObject dmgText = Instantiate(DamageText, TextPos.transform.position, Quaternion.identity);
        dmgText.GetComponent<Text>().text = damage.ToString();  //정수형 damage를 string형으로 캐스팅!
        Health -= damage;
        HpHealth.GetComponent<Image>().fillAmount = Health / StartHealth;
        Destroy(dmgText, 0.7f);

    }

    private void Update()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="splash")
        {
            Debug.Log("HIT!!!");
        }
    }

    void Start()
    {
        GameObject[] MobCount = GameObject.FindGameObjectsWithTag("Monster");
        Debug.Log("현재 생성된 Mob의 갯수 : " + MobCount.Length);
    }
    


}
