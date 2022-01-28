using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDetection : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D nearGhost) {
        if(nearGhost.gameObject.CompareTag("Toy") || nearGhost.gameObject.CompareTag("MapLimit")){
            //Debug.Log("A detetar as duas!!!!!");
            //Debug.Log("apanhaste me maroto! Vou ver se encontro o parent!");
            //Debug.Log("Aqui está o parent: " + this.gameObject.transform.parent.gameObject.ToString());
            //this.gameObject.transform.parent.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            this.gameObject.transform.parent.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            //considerGhostCollider = true;

        }
    }

     private void OnTriggerExit2D(Collider2D nearGhost) {
        if(nearGhost.gameObject.CompareTag("Toy") || nearGhost.gameObject.CompareTag("MapLimit")){
            //Debug.Log("1 : " + nearGhost.gameObject.ToString());
            //StartCoroutine(Refresh());
            this.gameObject.transform.parent.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            //Debug.Log("Aqui está o parent: " + nearGhost.transform.parent.gameObject.ToString());
            

        }
    }

    IEnumerator Refresh(){
        yield return new WaitForSeconds(0.5f);
        //Debug.Log("Hey magia!");
        this.gameObject.transform.parent.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
    }
}
