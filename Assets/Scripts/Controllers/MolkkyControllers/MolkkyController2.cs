using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M2");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "M2") {
            m2();
        } else if (currentScene.getCode() == "M1") {
            SceneManager.LoadScene("Molkky_1");
        } else if (currentScene.getCode() == "B") {
            SceneManager.LoadScene("Bar");
        } else if (currentScene.getCode() == "S") {
            SceneManager.LoadScene("BBQ");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        }

    }

    void m2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1");

        } else if (Input.GetKeyDown(KeyCode.B)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");

        } else if (Input.GetKeyDown(KeyCode.S)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.D)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");

        } 
    }
}
