using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController1a : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M1a");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "M1a") {
            m1a();
        } else if (currentScene.getCode() == "M1a0") {
            SceneManager.LoadScene("Molkky_1a0");
        } 

    }

    void m1a() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M1a0");

        }

    }

}
