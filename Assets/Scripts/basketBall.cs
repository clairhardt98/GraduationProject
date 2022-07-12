using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketBall : MonoBehaviour
{
    public GameObject ITRCamera;
    Vector3 worldRot_depth;

    void Start()
    {
        //transform.Translate(Vector3.forward * 0.1f);
        worldRot_depth = ITRCamera.transform.forward;
        GetComponent<Rigidbody>().velocity = worldRot_depth * 20;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
