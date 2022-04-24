using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevButtons : MonoBehaviour
{
    public GameObject cube;
    public Transform spawnPoint;
    public void AddLife() {
        Debug.Log("Not added yet.");
    }

    public void CubeSpawn() {
        Instantiate(cube, spawnPoint.position, Quaternion.identity);
    }
}
