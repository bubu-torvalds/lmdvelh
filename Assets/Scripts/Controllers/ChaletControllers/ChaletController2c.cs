using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ChaletController2c : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2c") {
            c2c();
        } else if (currentScene.getCode() == "C2c_0") {
            SceneManager.LoadScene("Chalet_2c0");
        } else if (currentScene.getCode() == "C2c_1") {
            SceneManager.LoadScene("Chalet_2c1");
        } 

    }

    void c2c() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c_0");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c_1");

        } 
    }

}
