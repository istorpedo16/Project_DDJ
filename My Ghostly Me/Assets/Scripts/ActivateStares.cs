using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStares : MonoBehaviour
{
    public GameObject escadaria;

    public Collider2D ball;
    public Collider2D cesto;


    void Update(){
        if(cesto.IsTouching(ball)){
            escadaria.SetActive(true);
        }
    }

}
