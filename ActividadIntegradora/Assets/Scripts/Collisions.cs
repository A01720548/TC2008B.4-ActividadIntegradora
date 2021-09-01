using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    void OnTriggerEnter(Collider col) {
        if (col.tag == "Robot") {
            Jump();
        }
    }

    public void Jump() {
        Debug.Log("Jumped");
        gameObject.transform.Translate(0,.3f,0);
    }
}
