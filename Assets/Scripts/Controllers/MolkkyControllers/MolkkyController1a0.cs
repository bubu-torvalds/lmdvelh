using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController1a0 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M1a0");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "M1a0") {
            m1a0();
        } else if (currentScene.getCode() == "M1b") {
            SceneManager.LoadScene("Molkky_1b");
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

    void m1a0() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1b");

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
