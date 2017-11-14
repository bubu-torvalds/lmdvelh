using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController2c : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        audioSource.Play();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "N2c");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "N2c") {
            n2c();
        } else if (currentScene.getCode() == "N2a") {
            SceneManager.LoadScene("Nous_2a");
        } else if (currentScene.getCode() == "N2b") {
            SceneManager.LoadScene("Nous_2b");
        } else if (currentScene.getCode() == "N2d") {
            SceneManager.LoadScene("Nous_2d");
        }

    }

    void n2c() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2d");

        }
    }
}
