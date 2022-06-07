using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
   
    public GameMnager gameManager;

    private void Start() {
        GameObject managerObject = GameObject.Find("GameMnager");
        gameManager= managerObject.GetComponent<GameMnager>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
           
            gameManager.addCoinCount();
            Destroy(gameObject);
        }
    }

}
