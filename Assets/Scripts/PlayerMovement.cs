using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 6.0F;
    private float xspd = 0.0F;
    private float yspd = 0.0F;

    //public float jumpSpeed = 8.0F;
    // public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        OVRInput.Update(); // Call before checking the input

        moveDirection = new Vector3(0, 0, 0);

        if (OVRInput.Get(OVRInput.Button.DpadLeft)){
            moveDirection += new Vector3(-speed, 0, 0);
        }
        if(OVRInput.Get(OVRInput.Button.DpadRight))
        {
            moveDirection += new Vector3(speed, 0, 0);
        }

        if (OVRInput.Get(OVRInput.Button.DpadUp))
        {
            moveDirection += new Vector3(0, 0, speed);
        }
        if (OVRInput.Get(OVRInput.Button.DpadDown))
        {
            moveDirection += new Vector3(0, 0, -speed);
        }


        if (Input.GetAxis("Horizontal")<0)
        {
            moveDirection += new Vector3(-speed, 0, 0);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            moveDirection += new Vector3(speed, 0, 0);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            moveDirection += new Vector3(0, 0, speed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            moveDirection += new Vector3(0, 0, -speed);
        }

        moveDirection = transform.TransformDirection(moveDirection);


            //if (Input.GetButton("Jump")) //uncomment if you want to jump
               // moveDirection.y = jumpSpeed;


        controller.Move(moveDirection * Time.deltaTime);

        //Rotate Player
        //transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

    }
}