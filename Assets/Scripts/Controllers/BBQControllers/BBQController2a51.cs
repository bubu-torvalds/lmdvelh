using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController2a51 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a51");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S2a51") {
            s2a51();
        } else if (currentScene.getCode() == "S2a1") {
            SceneManager.LoadScene("BBQ_2a1");
        } else if (currentScene.getCode() == "S2a2") {
            SceneManager.LoadScene("BBQ_2a1");
        } else if (currentScene.getCode() == "S2a3") {
            SceneManager.LoadScene("BBQ_2a3");
        } else if (currentScene.getCode() == "S2a4") {
            SceneManager.LoadScene("BBQ_2a4");
        } else if (currentScene.getCode() == "S1") {
            SceneManager.LoadScene("BBQ_1");
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "B") {
            SceneManager.LoadScene("Bar");
        }

    }

    void s2a51() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a2");
        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a3");
        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a4");
        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S1");
        } else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");
        } else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");
        } else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
