using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "N");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "N") {
            n();
        } else if (currentScene.getCode() == "N1") {
            SceneManager.LoadScene("Nous_1");
        } else if (currentScene.getCode() == "N2") {
            SceneManager.LoadScene("Nous_2");
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky_0");
        }

    }

    void n() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N1");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");

        }
    }
}
