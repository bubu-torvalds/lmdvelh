using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController1e : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M1e");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "M1e") {
            m1e();
        } else if (currentScene.getCode() == "M1f") {
            SceneManager.LoadScene("Molkky_1f");
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

    void m1e() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1f");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }

}
