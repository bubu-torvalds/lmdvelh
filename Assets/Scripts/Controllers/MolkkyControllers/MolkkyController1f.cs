using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController1f : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M1f");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "M1f") {
            m1f();
        } else if (currentScene.getCode() == "M1g") {
            SceneManager.LoadScene("Molkky_1g");
        } else if (currentScene.getCode() == "M2") {
            SceneManager.LoadScene("Molkky_2");
        } else if (currentScene.getCode() == "B") {
            SceneManager.LoadScene("Bar");
        } else if (currentScene.getCode() == "S") {
            SceneManager.LoadScene("BBQ");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        }

    }

    void m1f() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1g");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");

        }
    }

}
