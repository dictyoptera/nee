using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_switch : MonoBehaviour
{
    public GameObject upper;
    public GameObject lower;
    
    public void OnTriggerEnter(Collider other)
    {
        upper.SetActive(false);
        lower.SetActive(true);
        Debug.Log("An object entered.");
    }
}
