using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAbre : MonoBehaviour
{
    public Collider2D pAzul;
    public Collider2D pAmarelo;
    public Collider2D pRosa;

    Collider2D boxAzul;
    Collider2D boxAmarela;
    Collider2D boxRosa;
    public bool isInRange;
    public Animator door; //substituir pela porta

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
                //Debug.Log("Estas na area");
            if(Input.GetKeyDown(KeyCode.O)){
                //Debug.Log("Carregaste no Z...vou procurar pelas caixas");
                foundBoxesToEvaluate();
                if(pAzul.IsTouching(boxAzul) && pAmarelo.IsTouching(boxAmarela) && pRosa.IsTouching(boxRosa)){
                    //Debug.Log("Sim, tens as caixas todas;");
                    door.enabled = true;
                }
            }
        }
    }

    private void foundBoxesToEvaluate(){
        GameObject amarela = GameObject.FindGameObjectsWithTag("YellowBox")[0];
        GameObject rosa = GameObject.FindGameObjectsWithTag("PinkBox")[0];
        GameObject azul = GameObject.FindGameObjectsWithTag("BlueBox")[0];
        //Debug.Log("Encontrei estas caixas: Amarela: " + amarela.name + " Rosa: " + rosa.name + " Azul: " + azul.name);
        boxAmarela = amarela.GetComponent<BoxCollider2D>();
        boxRosa = rosa.GetComponent<BoxCollider2D>();
        boxAzul = azul.GetComponent<BoxCollider2D>();
        //Debug.Log("Com os colliders: Amarela: " + boxAmarela.ToString() + " Rosa: " + boxRosa.ToString() + " Azul: " + boxAzul.ToString());

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
