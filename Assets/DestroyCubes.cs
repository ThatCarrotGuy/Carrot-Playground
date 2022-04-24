using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    void Update() {
        if (Input.GetKey(KeyCode.R)) {
            Destroy(gameObject);
        }
    }
}
