using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
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

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
