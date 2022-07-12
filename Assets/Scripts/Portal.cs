using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform target;
   

    // Update is called once per frame
    void Start()
    {
        transform.LookAt(target);
    }
}
