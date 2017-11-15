using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController1a : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S1a");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S1a") {
            s1a();
        } else if (currentScene.getCode() == "S1b") {
            SceneManager.LoadScene("BBQ_1b");
        }

    }

    void s1a() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S1b");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
