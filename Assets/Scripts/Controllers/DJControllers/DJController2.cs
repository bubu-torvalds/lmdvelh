using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DJController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "DJ2") {
            dj2();
        }  else if (currentScene.getCode() == "DJ2a") {
            SceneManager.LoadScene("DJ_2a");
        } else if (currentScene.getCode() == "DJ2b") {
            SceneManager.LoadScene("DJ_2b");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        }

    }

    void dj2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2a");
        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2b");
        }
    }
}
