using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JeuxController3 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "J3");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "J3") {
            j3();
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky");        
        } 

    }

    void j3() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");
        } 
    }
}
