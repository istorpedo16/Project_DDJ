using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCutter : MonoBehaviour
{
    public bool isInRange;
    void Update (){
       GameObject objectToDestroy = GameObject.FindGameObjectWithTag("LinkBall");

        if(isInRange){
            if(Input.GetKeyDown(KeyCode.C)){
                Destroy (objectToDestroy);
                
            }else if(Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene("Game");
            }
        }
   }

   private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Toy")){
            isInRange = true;
            
        }
    }

     private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Toy")){
            isInRange = false;
            
        }
    }
}
