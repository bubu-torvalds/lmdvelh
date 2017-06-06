using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DJController2a : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2a");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "DJ2a") {
            dj2a();
        } else if (currentScene.getCode() == "DJ2a1") {
            SceneManager.LoadScene("DJ_2a1");
        } 
    }

    void dj2a() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2a1");

        } 
    }
}
