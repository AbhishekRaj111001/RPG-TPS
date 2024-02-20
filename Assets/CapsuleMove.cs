using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMove : MonoBehaviour
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
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Vertical"),0, 0 );
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
        
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
    }
}
