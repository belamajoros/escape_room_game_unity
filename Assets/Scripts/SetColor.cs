using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public MeshRenderer renderer;

    [Range(0f, 4f)]
    public float red = 1;
    [Range(0f, 4f)]
    public float green = 1;
    [Range(0f, 4f)]
    public float blue = 1;
    // Start is called before the first frame update
    void Start()
    {
        //renderer.material.SetColor("_Color", new Color(red,green,blue));
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.SetColor("_Color", new Color(red,green,blue));
    }
}
