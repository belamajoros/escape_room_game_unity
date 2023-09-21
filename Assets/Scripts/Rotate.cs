using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(1,50)]
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime * speed, 0);
    }
}
