﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "N2");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "N2") {
            n2();
        } else if (currentScene.getCode() == "N2a") {
            SceneManager.LoadScene("Nous_2a");
        } else if (currentScene.getCode() == "N2b") {
            SceneManager.LoadScene("Nous_2b");
        } else if (currentScene.getCode() == "N2c") {
            SceneManager.LoadScene("Nous_2c");
        }

    }

    void n2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2c");

        }
    }
}