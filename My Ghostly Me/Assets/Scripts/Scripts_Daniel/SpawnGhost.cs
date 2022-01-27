using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject ghostToSpawn;

    private GameObject ghostSpawned;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GhostAppearance(){
        ghostSpawned = (GameObject) Instantiate(ghostToSpawn, spawnLocation.position, Quaternion.identity);
        UnityEngine.Animator getAnimation = ghostSpawned.GetComponent(typeof(Animator)) as UnityEngine.Animator;
        getAnimation.Play("ghostAppear");
        ghostSpawned.name = "Ghost";
        //Debug.Log("Aquiiiiiiiii " + this.gameObject.ToString());
        //Debug.Log("Aquiiiiiiiii " + ghostSpawned.ToString());
       
    }

    public Transform GetGhostSpawnedPosition(){
        return ghostSpawned.transform;
    }

    public GameObject GetGhostSpawndIdentity(){
        return ghostSpawned;
    }
}
