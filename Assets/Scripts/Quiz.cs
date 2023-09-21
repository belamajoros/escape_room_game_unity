using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    //private int QuestionNum = 1;

    public GameObject door;

    // Update is called once per frame
    public void CheckTrue()
    {
        switch(door.name)
        {
            case "Door1":
                door.GetComponent<OpenDoor>().Open();
                break;
            case "Door2":
                break;
            case "Door3":
                break;
            case "Door4":
                door.GetComponent<OpenDoor>().Open();
                break;
            default:
                break;
        }
    }

    public void CheckFalse()
    {
        switch(door.name)
        {
            case "Door1":
                break;
            case "Door2":
                door.GetComponent<OpenDoor>().Open();
                break;
            case "Door3":
                door.GetComponent<OpenDoor>().Open();
                break;
            case "Door4":
                break;
            default:
                break;
        }
    }
}
