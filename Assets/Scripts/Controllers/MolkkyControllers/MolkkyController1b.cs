using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController1b : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M1b");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "M1b") {
            m1b();
        } else if (currentScene.getCode() == "M1b0") {
            SceneManager.LoadScene("Molkky_1b0");
        } 

    }

    void m1b() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1b0");

        } 
    }

}
