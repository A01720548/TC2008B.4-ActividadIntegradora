using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Collisions : MonoBehaviour
{

    public GameObject child1;
    public GameObject child2;

    private int count = 0;
    
    void Start() {
        child1 = this.gameObject.transform.GetChild(0).gameObject;
        child2 = this.gameObject.transform.GetChild(1).gameObject;
    }

    void OnTriggerEnter(Collider col) {
        if (col.tag == "Robot") {
            Jump();
        }

        if (col.tag == "Box") {
            Box(col);
        }
    }

    public void Jump() {
        Debug.Log("Jumped");

        gameObject.transform.Translate(0,.7f,0);

    }

    public void Box(Collider col) {
        Debug.Log("Box");
        col.gameObject.SetActive(false);
        if (count == 0) {
            child1.SetActive(true);
            count++;
        }
        if (count == 1) {
            child2.SetActive(true);
        }

    }
}
