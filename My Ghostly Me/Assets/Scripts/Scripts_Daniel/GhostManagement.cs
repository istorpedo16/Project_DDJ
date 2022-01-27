using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostManagement : MonoBehaviour
{

    public Animator anim;
    GameObject ghost;

    Animator getAnimation;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Possess(){
        ghost = GameObject.FindGameObjectsWithTag("Player")[0];
        UnityEngine.Animator getAnimation = ghost.GetComponent(typeof(Animator)) as UnityEngine.Animator;
        getAnimation.Play("ghostPossess");
        Destroy(ghost.gameObject, 0.5f);
        
    }


    public Animator getGhostAnimator(){
        return getAnimation;
    }

}
