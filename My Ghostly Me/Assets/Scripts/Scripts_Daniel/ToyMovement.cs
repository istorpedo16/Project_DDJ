using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToyMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public Animator animator;

    public float runSpeed = 3f;
    bool jump = false;
    float moveX = 0f;

    private Vector3 respawnPoint;

    void Start()
    {
        
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject objectToDestroy = GameObject.FindGameObjectWithTag("LinkBall");
        moveX = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(moveX));
        if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("IsJumping", true);
            jump = true;
        }

        if(Input.GetKeyDown(KeyCode.R)){
        
                SceneManager.LoadScene("Game");
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
