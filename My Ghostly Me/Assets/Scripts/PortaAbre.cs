using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAbre : MonoBehaviour
{
    public Collider2D pAzul;
    public Collider2D pAmarelo;
    public Collider2D pRosa;

    public Collider2D boxAzul;
    public Collider2D boxAmarela;
    public Collider2D boxRosa;

    public Animator door; //substituir pela porta

    public bool isInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pAzul.IsTouching(boxAzul) && pAmarelo.IsTouching(boxAmarela) && pRosa.IsTouching(boxRosa)){
            if(Input.GetKeyDown(KeyCode.E)){
               door.enabled = true;
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
