using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameMnager : MonoBehaviour {


    public GameObject clearText;
    public GameObject nextButton;
    public GameObject door;
    public AudioSource audioSource;
    private int coinCount;
    public Text textCompment;

    private void Start() {
        Screen.SetResolution(1920,1080,false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }
    public void SceneReset() {
        string activSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activSceneName);
    }
    public void ChangeScene(string nextScene) {
        SceneManager.LoadScene(nextScene);
    }
    public void playSound() {
        audioSource.Play();
    }

    public void openDoor() {
        Destroy(door);
    }

    public void countChek() {
        if (coinCount == 5) {
            openDoor();
            //clearText.SetActive(true);
            //nextButton.SetActive(true);
        }
    }
    public void addCoinCount (){
        playSound();
        coinCount+=1;
        Debug.Log("CoinCount"+coinCount);
        countChek();
        textCompment.text = "CoinCount" + coinCount;

    }
}
