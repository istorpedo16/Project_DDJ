using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToyKill : MonoBehaviour
{

    public UnityEvent changeToGhost;

    private bool happenedOnce =true;

    private void OnTriggerEnter2D(Collider2D other) {
        if(happenedOnce){
            if(other.gameObject.CompareTag("DangerousObject")){
            Debug.Log("OH SHIT!");
            changeToGhost.Invoke();
            happenedOnce=false;
        }
        }
    }

}
