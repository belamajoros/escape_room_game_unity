using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{

    private void Awake()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
    // Start is called before the first frame update
    public void Appear()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }

    public void Disappear()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
