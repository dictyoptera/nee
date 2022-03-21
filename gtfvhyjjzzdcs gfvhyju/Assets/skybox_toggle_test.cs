using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox_toggle_test : MonoBehaviour
{
    public GameObject skybox1;
    public GameObject skybox2;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            skybox1.SetActive(false);
            skybox2.SetActive(true);
        }
        else
        {
            skybox1.SetActive(true);
            skybox2.SetActive(false);
        }


    }
}
