using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2a3 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;


    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#3"));

    }

    // Update is called once per frame
    void Update() {

        print(currentScene.getCode());

        if (currentScene.getCode() == "C2a" && currentScene.getSubCode() == "#3") {
            c2aa3();
        } else if (currentScene.getCode() == "C2a") {
            SceneManager.LoadScene("Chalet_2a4");
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_2b");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_2c");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_2d");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2aa3() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#4"));

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }

    }
}
