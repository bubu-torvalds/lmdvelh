﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController1a : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "N1a");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "N1a") {
            n1a();
        } else if (currentScene.getCode() == "N1b") {
            SceneManager.LoadScene("Nous_1b");
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky_0");
        } 

    }

    void n1a() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N1b");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");

        } 
    }
}