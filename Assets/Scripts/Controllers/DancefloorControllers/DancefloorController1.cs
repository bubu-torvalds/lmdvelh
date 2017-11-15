using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DancefloorController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "D1");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "D1") {
            d1();
        } else if (currentScene.getCode() == "D1a") {
            SceneManager.LoadScene("Dancefloor_1a");
        } else if (currentScene.getCode() == "D2") {
            SceneManager.LoadScene("Dancefloor_2");
        } else if (currentScene.getCode() == "D3") {
            SceneManager.LoadScene("Dancefloor_3");
        } else if (currentScene.getCode() == "D4") {
            SceneManager.LoadScene("Dancefloor_4");
        } else if (currentScene.getCode() == "DJ") {
            SceneManager.LoadScene("DJ");
        } else if (currentScene.getCode() == "CA") {
            SceneManager.LoadScene("Carte");
        }
    }

    void d1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D1a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D3");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D4");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ");

        } else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "CA");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
