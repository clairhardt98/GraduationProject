using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Mob;
    public Transform SpawnPos;


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2 || Input.GetKeyDown(KeyCode.P))
        {
            spawn();
        }
    }
    void spawn()
    {
        Instantiate(Mob, SpawnPos.transform.position, SpawnPos.transform.rotation);
    }
}
