using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fadeeeee : MonoBehaviour
{

    public MeshRenderer rend;
    private Material mat;
    private float a = 1;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    public void setAlpha(float alpha)
    {
        foreach (Material m in rend.materials)
        {
            m.color = new Color(m.color.r, m.color.g, m.color.b, alpha);
        }
    }
}
