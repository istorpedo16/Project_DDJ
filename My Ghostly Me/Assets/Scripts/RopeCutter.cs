using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCutter : MonoBehaviour
{
    public Collider2D butao2;
    public Collider2D caixa;

    //public GameObject escadariateste;
    
    private void OnTriggerEnter2D (Collider2D collider){
        GameObject objectToDestroy = GameObject.FindGameObjectWithTag("Link");

        if(collider.GetComponent<CharacterController2D>() != null){
            if(butao2.IsTouching(caixa)){
                Destroy (objectToDestroy);
                //escadariateste.SetActive(true);
            }
        }
    }

}
