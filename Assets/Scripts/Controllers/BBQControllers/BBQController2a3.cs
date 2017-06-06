using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController2a3 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a3");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S2a3") {
            s2a3();
        } else if (currentScene.getCode() == "S2a31") {
            SceneManager.LoadScene("BBQ_2a31");
        } 

    }

    void s2a3() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a31");
        }       
    }
}
