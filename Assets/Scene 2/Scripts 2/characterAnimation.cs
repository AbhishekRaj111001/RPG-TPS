using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnimation : MonoBehaviour
{
    // Animations condition variable
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
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            isRunning = Input.GetKey(KeyCode.LeftShift);
            anim.SetBool("Run", isRunning);
        }
        else
        {
            anim.SetBool("idle", true);
        }
        

        isWalking = Input.GetKey(KeyCode.W);
        anim.SetBool("Walk", isWalking);
        isWalking = Input.GetKey(KeyCode.UpArrow);
        anim.SetBool("Walk", isWalking);

        isAttacking = Input.GetMouseButton(0);
        anim.SetBool("Attack", isAttacking);

        isBack = Input.GetKey(KeyCode.S);
        anim.SetBool("Back", isBack);
        isBack = Input.GetKey(KeyCode.DownArrow);
        anim.SetBool("Back", isBack);

        isLeft = Input.GetKey(KeyCode.A);
        anim.SetBool("Left", isLeft);
        isLeft = Input.GetKey(KeyCode.LeftArrow);
        anim.SetBool("Left", isLeft);

        isRight = Input.GetKey(KeyCode.D);
        anim.SetBool("Right", isRight);
        isRight = Input.GetKey(KeyCode.RightArrow);
        anim.SetBool("Right", isRight);

        isJump = Input.GetKey(KeyCode.Space);
        anim.SetBool("Jump", isJump);

    }
}
