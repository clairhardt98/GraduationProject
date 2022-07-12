using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select_mesh_image : MonoBehaviour
{
    GameObject LoadMapNum;
    int Mapnum;
    public GameObject mesh1;
    public GameObject mesh2;
    public GameObject mesh3;
    public GameObject mesh4;
    public GameObject LFSpace1;
    public GameObject LFSpace2;
    public GameObject LFSpace3;
    public GameObject LFSpace4;

    // Start is called before the first frame update
    void Start()
    {
        LoadMapNum = GameObject.Find("Mapnumber");
        Mapnum = LoadMapNum.GetComponent<SelectMap>().MapNum;
      
    }

    void Update()
    {
        if (Mapnum == 1)
        {
            mesh1.SetActive(true);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            LFSpace1.SetActive(true);
            LFSpace2.SetActive(false);
            LFSpace3.SetActive(false);
            LFSpace4.SetActive(false);
        }

        if (Mapnum == 2)
        {
            mesh1.SetActive(false);
            mesh2.SetActive(true);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            LFSpace1.SetActive(false);
            LFSpace2.SetActive(true);
            LFSpace3.SetActive(false);
            LFSpace4.SetActive(false);
        }

        if (Mapnum == 3)
        {
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(true);
            mesh4.SetActive(false);
            LFSpace1.SetActive(false);
            LFSpace2.SetActive(false);
            LFSpace3.SetActive(true);
            LFSpace4.SetActive(false);
        }

        if (Mapnum == 4)
        {
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(true);
            LFSpace1.SetActive(false);
            LFSpace2.SetActive(false);
            LFSpace3.SetActive(false);
            LFSpace4.SetActive(true);
        }
    }

    
}
