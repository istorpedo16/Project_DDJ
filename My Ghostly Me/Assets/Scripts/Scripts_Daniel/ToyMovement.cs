using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public Animator animator;

    public float runSpeed = 3f;
    bool jump = false;
    float moveX = 0f;

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(moveX));
        if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("IsJumping", true);
            jump = true;
        }
    }

    public void onLanding(){
        animator.SetBool("IsJumping", false);
    }
    //Move our Toy
    void FixedUpdate() {
        controller2D.Move(moveX * Time.fixedDeltaTime, false, jump);
        jump=false;
    }
}
