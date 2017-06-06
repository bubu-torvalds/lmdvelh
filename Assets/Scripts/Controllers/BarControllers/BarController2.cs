using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "B2");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "B2") {
            b2();
        } else if (currentScene.getCode() == "B1") {
            SceneManager.LoadScene("Bar_1");
        }  else if (currentScene.getCode() == "B3") {
            SceneManager.LoadScene("Bar_3");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky");
        } else if (currentScene.getCode() == "F") {
            SceneManager.LoadScene("Foret");
        }

    }

    void b2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B3");
        } else if (Input.GetKeyDown(KeyCode.D)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.M)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");
        } else if (Input.GetKeyDown(KeyCode.F)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "F");
        } 
    }
}
