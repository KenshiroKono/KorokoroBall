using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float power = 2.0f;
    public Rigidbody rigidbody;

    void start() {
        //       Application.targetFrameRate =60;
    }
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        //else {
        //    this.transform.Translate(0, 0, 0);
        //}

        if (Input.GetKey(KeyCode.RightArrow)) {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        //else {
        //    this.transform.Translate(0, 0, 0);
        //}
    }

}
