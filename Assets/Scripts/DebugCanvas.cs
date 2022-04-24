using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCanvas : MonoBehaviour
{

    public GameObject devTools; 
   void Update() {
       if (Input.GetKey(KeyCode.Alpha7)) {
           devTools.SetActive(true);
       }
   }
}
