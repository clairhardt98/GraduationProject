using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionenter : MonoBehaviour
{

    public GameObject Golem;
    public GameObject Soldier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnCollisionEnter(Collision collision)
{
    if(collision.transform.tag == "Tower")
    {
        Golem.GetComponent<Rigidbody>().useGravity = false;
        Soldier.GetComponent<Rigidbody>().useGravity = false;
    }
}

}