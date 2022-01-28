using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour
{
    public Transform spawnLocationYellowBox;
    public GameObject yellowBox;
    private GameObject yellowBoxGenerated;

    public Transform spawnLocationRoseBox;
    public GameObject roseBox;
    private GameObject roseBoxGenerated;

    public Transform spawnLocationBlueBox;
    public GameObject blueBox;
    private GameObject blueBoxGenerated;
    // Start is called before the first frame update
    public void YellowBoxAppearance(){
        yellowBoxGenerated = Instantiate(yellowBox, spawnLocationYellowBox.position, Quaternion.identity);

    }
    public void RoseBoxAppearance(){
        roseBoxGenerated = Instantiate(roseBox, spawnLocationRoseBox.position, Quaternion.identity);

    }
    public void BlueBoxAppearance(){
        blueBoxGenerated = Instantiate(blueBox, spawnLocationBlueBox.position, Quaternion.identity);
    }

    public GameObject GetYellowBoxSpawnedIdentity(){
        return yellowBoxGenerated;
    }
    public GameObject GetRoseBoxSpawnedIdentity(){
        return roseBoxGenerated;
    }
    public GameObject GetBlueBoxSpawnedIdentity(){
        return blueBoxGenerated;
    }
}