using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro{
public class ToyText : MonoBehaviour
{
    private GameObject toy;
    private TextMeshPro text;
    void Start() {
       text = GetComponent(typeof(TextMeshPro)) as TextMeshPro;
    }
   public void quitText(){
       text.SetText("Q", true);
   }
}
}