using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float power = 8.0f;
    public Rigidbody rigidbody;

    void start() {
         
    }
    void Update() {
        if (Input.GetKey(KeyCode.W)) {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        else if (Input.GetKey(KeyCode.S)) {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        //else {
        //    this.transform.Translate(0, 0, 0);
        //}

        if (Input.GetKey(KeyCode.D)) {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }
        else if (Input.GetKey(KeyCode.A)) {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        //else {
        //    this.transform.Translate(0, 0, 0);
        //}
    }

}
