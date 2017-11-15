using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController1a0 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "C1a_0");

    }

    // Update is called once per frame
    void Update () {

        if (currentScene.getCode() == "C1a_0") {
            c1a_0();
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } 

    }

    void c1a_0() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
