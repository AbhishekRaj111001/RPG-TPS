using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Animator anim;
    bool isRunning = false;
    bool isWalking = false;
    bool isAttacking = false;
    bool isBack = false;
    bool isLeft = false;
    bool isRight = false;
    bool isJump = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isRunning = Input.GetKey(KeyCode.LeftShift);
        anim.SetBool("Run", isRunning);

        isWalking = Input.GetKey(KeyCode.W);
        anim.SetBool("Walk", isWalking);

        isAttacking = Input.GetKey(KeyCode.H);
        anim.SetBool("Attack", isAttacking);

        isBack = Input.GetKey(KeyCode.S);
        anim.SetBool("Back", isBack);

        isLeft = Input.GetKey(KeyCode.A);
        anim.SetBool("Left", isLeft);
        
        isRight = Input.GetKey(KeyCode.D);
        anim.SetBool("Right", isRight);

        isJump = Input.GetKey(KeyCode.Space);
        anim.SetBool("Jump", isJump);


        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            
            transform.position= transform.position + new Vector3(0, 0, 10f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W))
        {
            
            transform.position = transform.position + new Vector3(0, 0, 5f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S))
        {
            
            transform.position = transform.position + new Vector3(0, 0, -5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = transform.position + new Vector3(0, 0, -10f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            
            transform.position = transform.position + new Vector3(5f * Time.deltaTime,0, 0);
        }
        if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            
            transform.position = transform.position + new Vector3(10f * Time.deltaTime,0, 0);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-5f * Time.deltaTime,0, 0);
        }
        if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = transform.position + new Vector3(-10f * Time.deltaTime,0, 0);
        }
    }
}
