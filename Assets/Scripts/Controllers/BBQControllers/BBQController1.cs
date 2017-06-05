using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S1");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S1") {
            s1();
        } else if (currentScene.getCode() == "S1a") {
            SceneManager.LoadScene("BBQ_1a");
        } else if (currentScene.getCode() == "S2") {
            SceneManager.LoadScene("BBQ_2");
        }

    }

    void s1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S1a");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2");
        }
    }
}
