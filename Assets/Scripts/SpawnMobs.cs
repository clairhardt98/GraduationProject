using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMobs : MonoBehaviour
{
    public GameObject Mob;
    public Transform SpawnPos;
    float timer;
    public int waitingTime;

    bool SpawnOn = false;
    // Update is called once per frame
    private void Start()
    {
        timer = 0;
        waitingTime = 2;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.touchCount == 2)
        {

            if (SpawnOn)
            {
                SpawnOn = false;
            }


            else
            {
                SpawnOn = true;
            }
        }


        if (SpawnOn)
        {
            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                Spawn();
                timer = 0;
            }

        }
    }
    void Spawn()
    {
        Instantiate(Mob, SpawnPos.transform.position, SpawnPos.transform.rotation);
    }
}