using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject box;
    public GameObject robot;
    public int quantityBoxes, quantityRobots, rangeX, rangeZ;


    void Start()
    {
        for (int i = 0; i < quantityBoxes; i++) {
            float posX = Random.Range(-rangeX, rangeX);
            float posZ = Random.Range(-rangeZ, rangeZ);
            Instantiate(box, new Vector3(posX,0.113f,posZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        }

        for (int i = 0; i < quantityRobots; i++) {
            float posX = Random.Range(-rangeX, rangeX);
            float posZ = Random.Range(-rangeZ, rangeZ);
            Instantiate(robot, new Vector3(posX,0f,posZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
