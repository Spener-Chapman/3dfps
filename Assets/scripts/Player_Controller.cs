using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class Player_Controller : MonoBehaviour
{
    public float gravity = 10.0f;
    public float movement = 6.0f;
    public float runMovement = 9.0f;
    public float jumpSpeed = 7.0f;
    public Camera playerCamera;
    public float lookSpeed = 2.0f;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    public bool canMove = true;

    public float lookXLimit = 90.0f;

    int maxHealth = 100;
    int currentHealth;

    



    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        //running

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runMovement : movement) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runMovement : movement) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);


        // jump

        if (Input.GetKey(KeyCode.Space) && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        //gravity

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // moveing controller

        characterController.Move(moveDirection * Time.deltaTime);

        //player and camera rotate

        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }
   
}