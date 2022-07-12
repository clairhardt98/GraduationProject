using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMStart : MonoBehaviour
{
    private AudioSource bgm;
    private GameObject[] music;

    private void Awake()
    {
        music =GameObject.FindGameObjectsWithTag("Bgm");
        //DontDestroyOnLoad(transform.gameObject);
        bgm = GetComponent<AudioSource>();
    }
    
    public void MusicStart()
    {
        if (bgm.isPlaying)
            return;
        bgm.Play();
    }

    public void MusicStop()
    {
        bgm.Stop();
    }



}
