using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MobBehaviour : MonoBehaviour
{
    /*
    public GameObject ITRCamera;
    Vector3 worldRot_depth;

    void Start()
    {
        //transform.Translate(Vector3.forward * 0.1f);
        worldRot_depth = ITRCamera.transform.forward;
        GetComponent<Rigidbody>().velocity = worldRot_depth * 20;

    }
    */

    
    public Vector3 home = new Vector3(0f, 0.1f, 0f);
    // Update is called once per frame
    void Update()
    {

        if(Time.timeScale != 0)
        {
           if(RoundCount.Round == 1)
            {
                transform.Translate(Vector3.forward * 0.01f);
                transform.LookAt(home);
            } 
           else if(RoundCount.Round == 2)
            {
                transform.Translate(Vector3.forward * 0.03f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 3)
            {
                transform.Translate(Vector3.forward * 0.05f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 4)
            {
                transform.Translate(Vector3.forward * 0.07f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 5)
            {
                transform.Translate(Vector3.forward * 0.09f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 6)
            {
                transform.Translate(Vector3.forward * 0.15f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 7)
            {
                transform.Translate(Vector3.forward * 0.2f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 8)
            {
                transform.Translate(Vector3.forward * 0.4f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 9)
            {
                transform.Translate(Vector3.forward * 0.6f);
                transform.LookAt(home);
            }

            else if (RoundCount.Round == 10)
            {
                transform.Translate(Vector3.forward * 0.8f);
                transform.LookAt(home);
            }

            else
            {
                //10라운드가 넘어가면 Result SCene으로 전환
                SceneManager.LoadScene(4);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}


