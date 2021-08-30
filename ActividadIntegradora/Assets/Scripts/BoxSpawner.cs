using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject prefabCube;
    public int quantity, rangeX, rangeZ;


    void Start()
    {
        for (int i = 0; i < quantity; i++) {
            float posX = Random.Range(-rangeX, rangeX);
            float posZ = Random.Range(-rangeZ, rangeZ);
            Instantiate(prefabCube, new Vector3(posX,0.113f,posZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
