using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public bool IsOpen = false;

    private float Speed = 1f;
    private Vector3 SlideDirection = Vector3.back;
    private float SlideAmount = 1.9f;
    private Vector3 StartPosition;

    private Coroutine AnimationCoroutine;
    // Start is called before the first frame update
    private void Awake()
    {
        StartPosition = transform.position;
    }

    public void Open()
    {
        if (!IsOpen)
        {
            if(AnimationCoroutine != null){
                StopCoroutine(AnimationCoroutine);
            }
            AnimationCoroutine = StartCoroutine(SlideOpen());
        }
    }

    public IEnumerator SlideOpen()
    {
        Vector3 endPosition = StartPosition + SlideAmount * SlideDirection;
        Vector3 startPosition = transform.position;

        float time = 0;
        IsOpen = true;
        while(time < 1)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, time);
            yield return null;
            time += Time.deltaTime * Speed;
        }
        gameObject.SetActive(false);
    }
/* 
    private void Close()
    {
        Vector3 endPosition = StartPosition + SlideAmount * SlideDirection;
        Vector3 startPosition = transform.position;

        float time = 0;
        isOpen = true;
        while(time < 1)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, time);
            yield return null;
            time += time.deltaTime * Speed;
        }
    } */
}
