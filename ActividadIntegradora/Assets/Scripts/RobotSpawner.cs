using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSpawner : MonoBehaviour
{
    public GameObject robot;
    public int rangeX, rangeZ;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(robot, new Vector3(rangeX,0.019f,rangeZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        Instantiate(robot, new Vector3(-rangeX,0.019f,rangeZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        Instantiate(robot, new Vector3(-rangeX,0.019f,-rangeZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        Instantiate(robot, new Vector3(rangeX,0.019f,-rangeZ), Quaternion.identity); // Orient object in +X, +Z, +Y
        Instantiate(robot, new Vector3(0,0.019f,0), Quaternion.identity); // Orient object in +X, +Z, +Y
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
