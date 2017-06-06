using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JeuxController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "J2");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "J2") {
            j2();
        } else if (currentScene.getCode() == "J1") {
            SceneManager.LoadScene("Jeux_1");        
        } else if (currentScene.getCode() == "J3") {
            SceneManager.LoadScene("Jeux_3");
        } else if (currentScene.getCode() == "BUS") {
            SceneManager.LoadScene("Bus");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "F") {
            SceneManager.LoadScene("Foret");
        }

    }

    void j2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "J1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "J3");
        } else if (Input.GetKeyDown(KeyCode.B)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "BUS");
        } else if (Input.GetKeyDown(KeyCode.T)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "T");
        } else if (Input.GetKeyDown(KeyCode.D)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.F)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "F");
        }
    }
}
