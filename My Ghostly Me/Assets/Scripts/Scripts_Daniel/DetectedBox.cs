using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectedBox : MonoBehaviour
{
    public UnityEvent spawnYellowBox;
    public UnityEvent spawnPinkBox;
    public UnityEvent spawnBlueBox;

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("YellowBox")){
            Debug.Log("YellowBox!");
            Destroy(other.gameObject);  
            spawnYellowBox.Invoke();       
        }
        else if(other.gameObject.CompareTag("PinkBox")){
            Debug.Log("PinkBox!");
            Destroy(other.gameObject);  
            spawnPinkBox.Invoke();
        }
        else if(other.gameObject.CompareTag("BlueBox")){
            Debug.Log("BlueBox!");
            Destroy(other.gameObject);  
            spawnBlueBox.Invoke();
        }
        
    }
}
