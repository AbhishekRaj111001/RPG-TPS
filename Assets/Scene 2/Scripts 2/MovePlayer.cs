using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 6.0F;
    public float MaxSpeed = 10.0F;
    public float JumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 toRotate;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        CharacterController controller = GetComponent<CharacterController>();
        if(controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveDirection *= MaxSpeed;
            }
            if (Input.GetKey(KeyCode.Space))
                moveDirection.y = JumpSpeed;

        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotateSpeed*Time.deltaTime, 0);
        }if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotateSpeed*Time.deltaTime, 0);
        }
        //transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

    }
}
