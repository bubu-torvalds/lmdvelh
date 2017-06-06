using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController2a41 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a41");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S2a41") {
            s2a41();
        } else if (currentScene.getCode() == "S2a1") {
            SceneManager.LoadScene("BBQ_2a1");
        } else if (currentScene.getCode() == "S2a2") {
            SceneManager.LoadScene("BBQ_2a2");
        } else if (currentScene.getCode() == "S2a3") {
            SceneManager.LoadScene("BBQ_2a3");
        } else if (currentScene.getCode() == "S2a5") {
            SceneManager.LoadScene("BBQ_2a5");
        } else if (currentScene.getCode() == "S1") {
            SceneManager.LoadScene("BBQ_1");
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "B") {
            SceneManager.LoadScene("Bar");
        }

    }

    void s2a41() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a2");
        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a3");
        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a5");
        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S1");
        } else if (Input.GetKeyDown(KeyCode.M)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");
        } else if (Input.GetKeyDown(KeyCode.B)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");
        }
    }
}
