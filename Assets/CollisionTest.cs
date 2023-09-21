using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public bool collided = false;
    string[] colArray = { "Stairs", "Stairs2", "Cube", "Cube1", "Cube2" };

    void OnControllerColliderHit(ControllerColliderHit col)
    {
        if(col.gameObject.name == "Stairs")
        {
            Debug.Log("asd1");
            collided = true;
        } else {
            collided = false;
        }
    }

    public bool IsCollided()
    {
        return collided;
    }
}
