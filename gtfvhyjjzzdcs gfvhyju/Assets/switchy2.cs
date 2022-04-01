using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchy2 : MonoBehaviour
{
    public GameObject upper;
    public GameObject lower;
    public GameObject skybox1;
    public GameObject skybox2;
    public GameObject PlayerLamp;
    public GameObject Player;
    public float presense;
    public GameObject figure;
    public fadeeeee hissie;
   


    public void OnTriggerEnter(Collider other)
    {
        upper.SetActive(true);
        lower.SetActive(false);
        skybox1.SetActive(true);
        skybox2.SetActive(false);
        PlayerLamp.SetActive(false);
        Player.transform.position = new Vector3(-1, 97, 111);
        Debug.Log("An object entered.");
        presense = presense + .2f;
        hissie.setAlpha(presense);
        hissie.rend.enabled = true;
       
    }
}
