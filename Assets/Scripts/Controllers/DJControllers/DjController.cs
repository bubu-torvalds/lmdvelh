using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DjController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "DJ") {
            dj();
        } else if (currentScene.getCode() == "DJ1") {
            SceneManager.LoadScene("DJ_1");
        } else if (currentScene.getCode() == "DJ2") {
            SceneManager.LoadScene("DJ_2");
        } else if (currentScene.getCode() == "DJ3") {
            SceneManager.LoadScene("DJ_3");
        } else if (currentScene.getCode() == "DJ4") {
            SceneManager.LoadScene("DJ_4");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        }

    }

    void dj() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2");
        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ3");
        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ4");
        } else if (Input.GetKeyDown(KeyCode.D)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        }
    }
}
