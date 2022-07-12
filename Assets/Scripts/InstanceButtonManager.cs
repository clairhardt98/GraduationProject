using System.Collections;  //코루틴 사용을 위해
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanceButtonManager : MonoBehaviour
{

  // private Rigidbody Tower_Rigidbody;

    public GameObject Portal;
    public GameObject Golem;
    public GameObject Soldier;

    public GameObject InstanceButton;
    //public GameObject PortalButton;
    //public GameObject GolemButton;
    //public GameObject SoldierButton;

    //public Transform spawnPos;


    public void PortalInstance()
    {
        Portal.transform.position = InstanceButton.GetComponent<Transform>().position;
        Instantiate(Portal);
        InstanceButton.SetActive(false);
    }

    public void GolemInstance()
    {
        Golem.transform.position = InstanceButton.GetComponent<Transform>().position;
        Instantiate(Golem);
        InstanceButton.SetActive(false); 
    }
    public void SoldierInstance()
    {
        Soldier.transform.position = InstanceButton.GetComponent<Transform>().position;
        Instantiate(Soldier);
        InstanceButton.SetActive(false);
    }

    private void StartGame()
    {
        StartCoroutine("TimeCount");
    }



 

    
}
