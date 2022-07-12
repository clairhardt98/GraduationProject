using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    public Image reticle;
    float timeElapsed;
    public GameObject InstanceButton;
    public Transform home;
    

    bool buttonActive;
    // Start is called before the first frame update
    void Start()
    {
        buttonActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        Raycasting();
    }
    void Raycasting()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward * 1000);
        if (Input.touchCount == 1 || Input.GetKey(KeyCode.Space))  
        {
            Physics.Raycast(transform.position, forward, out hit);
            Debug.DrawRay(transform.position, forward, Color.blue);
           
          
            timeElapsed = Time.deltaTime + timeElapsed;
            reticle.fillAmount = timeElapsed;
            if (timeElapsed >= 1)
            {
                timeElapsed = 0;
                if (!buttonActive)
                {
                    InstanceButton.transform.position = new Vector3(hit.point.x, hit.point.y+1f, hit.point.z+1f);
                    InstanceButton.transform.LookAt(home);
                    InstanceButton.transform.Rotate(0, 180, 0);
                    InstanceButton.SetActive(true);
                    buttonActive = true;
                }
                else
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    buttonActive = false;
                }

            }
        }
        else
        {
            timeElapsed = timeElapsed - Time.deltaTime;
            reticle.fillAmount = timeElapsed;
            if (timeElapsed <= 0) timeElapsed = 0;
        }
    }
}
