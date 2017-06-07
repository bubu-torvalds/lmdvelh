﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DancefloorController1a : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "D1a");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "D1a") {
            d1a();
        } else if (currentScene.getCode() == "D2") {
            SceneManager.LoadScene("Dancefloor_2");
        } else if (currentScene.getCode() == "D3") {
            SceneManager.LoadScene("Dancefloor_3");
        } else if (currentScene.getCode() == "D4") {
            SceneManager.LoadScene("Dancefloor_4");
        } else if (currentScene.getCode() == "CA") {
            SceneManager.LoadScene("Carte");
        }
    }

    void d1a() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D2");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D3");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D4");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "CA");

        } 
    }
}
