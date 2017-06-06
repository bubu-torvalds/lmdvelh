﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "N1");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "N1") {
            n1();
        } else if (currentScene.getCode() == "N1a") {
            SceneManager.LoadScene("Nous_1a");
        } 

    }

    void n1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N1a");

        } 
    }
}