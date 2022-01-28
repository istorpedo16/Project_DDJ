using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCaixas : MonoBehaviour
{
    public GameObject plantaforma;
    public bool isInRange;

    public GameObject nextPlat;
    public GameObject wall1;
    public GameObject wall2;

    // Update is called once per frame
    void Update()
    {
        if(isInRange){

            if(Input.GetKeyDown(KeyCode.E)){
                
                plantaforma.SetActive(false);
                
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
