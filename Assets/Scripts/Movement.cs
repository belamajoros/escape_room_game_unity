using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    PlayerControls controls;
    CharacterController characterController;
    public GameObject avatar;
    public Transform cameraTransform;

    public float moveSpeed = 2f;
    public float rotationSpeed = 2f;

    private Vector3 moveDirection = Vector3.zero;

    private void Awake()
    {
        characterController = avatar.GetComponent<CharacterController>();
        controls = new PlayerControls();
        controls.Enable();
    }

    // Update is called once per frame
    private void Update()
    {
        desktopMove();
    }

    private void desktopMove()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
        moveDirection = cameraTransform.TransformDirection(moveDirection);
        moveDirection.y = 0;

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
