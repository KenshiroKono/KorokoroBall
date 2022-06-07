using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccellXX : MonoBehaviour {
    public const float POWER = 25;
    public void OnTriggerStay(Collider other) {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null) {
            r.AddForce(new Vector3(-1, 0, 0) * POWER);
        }
    }
}