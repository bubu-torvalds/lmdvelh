using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ForetController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "F1");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "F1") {
            f1();
        } else if (currentScene.getCode() == "F2") {
            SceneManager.LoadScene("Foret_2");
        } else if (currentScene.getCode() == "F3") {
            SceneManager.LoadScene("Foret_3");
        } else if (currentScene.getCode() == "B") {
            SceneManager.LoadScene("Bar");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "J") {
            SceneManager.LoadScene("Jeux");
        }

    }

    void f1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "F2");
        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "F3");
        } else if (Input.GetKeyDown(KeyCode.B)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");
        } else if (Input.GetKeyDown(KeyCode.D)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.J)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "J");
        }
    }
}
