using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkie_sounds : MonoBehaviour
{
    public GameObject WalkieDirt;
    public GameObject WalkieWater;
    public bool InDaWater = false;


    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && !InDaWater)
        {
            WalkieDirt.SetActive(true);
            WalkieWater.SetActive(false);
            Debug.Log("walkiedirt");
        }
        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && InDaWater)
        {
            WalkieDirt.SetActive(false);
            WalkieWater.SetActive(true);
            Debug.Log("walkiewater");
        }
        else
        {
            WalkieDirt.SetActive(false);
            WalkieWater.SetActive(false);
            // Debug.Log("walkieno");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        InDaWater = true;
        Debug.Log("in da water");
    }

    //public void OnTriggerStay(Collider other)
    //{
    //    InDaWater = true;
    //    Debug.Log("in da water");
    //}

    public void OnTriggerExit(Collider other)
    {
        InDaWater = false;
        Debug.Log("out da water");
    }
}