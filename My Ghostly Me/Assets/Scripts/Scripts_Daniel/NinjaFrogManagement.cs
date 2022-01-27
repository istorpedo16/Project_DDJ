using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaFrogManagement : MonoBehaviour
{

    public Animator anim;
    GameObject ninjafrog;

    Animator getAnimation;
    
    public void activeAnimationToy(){
        anim.enabled =true;
    }

    public void Hurt(){
        //ninjafrog = GameObject.FindGameObjectsWithTag("Player")[0];
        //UnityEngine.Animator getAnimation = ninjafrog.GetComponent(typeof(Animator)) as UnityEngine.Animator;
        anim.Play("NinjaFrog_Hurt");
        //gameObject.GetComponent<ToyMovement>().enabled=false;
        gameObject.transform.Find("InteractableObject").gameObject.SetActive(false);
        //Destroy(ninjafrog.gameObject, 0.5f);
        
    }


    public Animator getGhostAnimator(){
        return getAnimation;
    }

}
