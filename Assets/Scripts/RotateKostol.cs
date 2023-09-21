using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateKostol : MonoBehaviour
{
    [Range(1,50)]
    public float speed = 1;

    public GameObject targetCube;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(targetCube.transform.position, Vector3.up, 50 * Time.deltaTime * speed);
    }
}
