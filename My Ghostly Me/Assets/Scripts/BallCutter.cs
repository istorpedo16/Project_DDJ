using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCutter : MonoBehaviour
{
    public bool isInRange;

    void Update(){
        GameObject objectToDestroy = GameObject.FindGameObjectWithTag("LinkBall");

        if(isInRange){
            if(Input.GetKeyDown(KeyCode.C)){
                objectToDestroy.SetActive(false);
                //Destroy (objectToDestroy);
            }
        }

        

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Toy")){
            isInRange = true;
            /*Debug.Log("Ghost in range");
            textContent.SetText(interactKey.ToString(), true);
            textContent.enabled = true;*/
        }
    }

   private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Toy")){
            isInRange = false;
            //Debug.Log("Ghost is NOT range");
            //textContent.enabled = false;
        }
    }
}
