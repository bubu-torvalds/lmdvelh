using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MolkkyController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "M");
    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "M") {                    
            m();
        } else if (currentScene.getCode() == "M0") {            
            SceneManager.LoadScene("Molkky_0");
        } 

    }

    void m() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M0");

        }
    }
}
