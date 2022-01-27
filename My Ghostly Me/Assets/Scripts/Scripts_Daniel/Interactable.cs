using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro{
public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent changeToToy;
    //public UnityEvent changeToGhost;
    private TextMeshPro textContent;

    //private bool isToy = false;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject textObject = this.transform.parent.Find("Text").gameObject;
        textContent = textObject.GetComponent(typeof(TextMeshPro)) as TextMeshPro;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange){

            if(Input.GetKeyDown(interactKey)){
                changeToToy.Invoke();
                textContent.enabled = false;
                //isToy=true;
            }
            

        }
       /* if(isToy){
            if(Input.GetKeyDown(KeyCode.Q)){
                changeToGhost.Invoke();
                textContent.SetText("", true);
                isToy = false;
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            isInRange = true;
            Debug.Log("Ghost in range");
            textContent.SetText(interactKey.ToString(), true);
            textContent.enabled = true;
        }
    }

     private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            isInRange = false;
            Debug.Log("Ghost is NOT range");
            textContent.enabled = false;
        }
    }

}
}