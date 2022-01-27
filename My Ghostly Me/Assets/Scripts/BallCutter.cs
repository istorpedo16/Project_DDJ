using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCutter : MonoBehaviour
{
   public void OnTriggerEnter2D (Collider2D collider){
       GameObject objectToDestroy = GameObject.FindGameObjectWithTag("LinkBall");

        if(collider.GetComponent<CharacterController2D>() != null){
            //if(Input.GetKeyDown(KeyCode.E)){
                Destroy (objectToDestroy);
                
            //}
        }
   }
}
