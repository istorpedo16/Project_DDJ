using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine{
public class CameraController : MonoBehaviour
{

    //public CinemachineBrain brain;
    public CinemachineVirtualCamera camera;
    
    //SpawnGhost sg;
    GameObject toyBeingControlled;

    // Update is called once per frame
    void Start(){
        
    }

    void Update()
    {
       /* if(Input.GetKey(KeyCode.Q)){
            camera.m_Follow = initialGhostPosition;
        }*/
        
    }

    public void ControlToy(Transform toyAround){
        toyBeingControlled = toyAround.gameObject;
        ToyMovement toyMovementStatus = toyBeingControlled.GetComponent(typeof(ToyMovement)) as ToyMovement;
        camera.m_Follow = toyAround;
        toyMovementStatus.enabled = true;

    }

    public void ControlGhost(SpawnGhost sg){
        //sg = this.transform.parent.FindChild("SpawnGhostLocation").GetComponent(typeof(SpawnGhost)) as SpawnGhost;
        ToyMovement toyMovementStatus = toyBeingControlled.GetComponent(typeof(ToyMovement)) as ToyMovement;
        camera.m_Follow = sg.GetGhostSpawnedPosition();
        toyMovementStatus.enabled = false;

    }
    
}
}