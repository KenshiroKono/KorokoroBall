using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float power = 10.0f;
    public Rigidbody rigidbody;

    void start() {
 //       Application.targetFrameRate =60;
    }
    void Update() {
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow)) {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
    }

}
