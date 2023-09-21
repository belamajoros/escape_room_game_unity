using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{

    public Material customMaterial;
    public Material originalMaterial;
    // Start is called before the first frame update
    public void setCustomTexture()
    {
        GetComponent<MeshRenderer>().material = customMaterial;
    }

    public void resetTexture(){
        GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
