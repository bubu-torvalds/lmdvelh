﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2a6 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;


    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
 
        currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#6"));

    }

    // Update is called once per frame
    void Update() {

        print(currentScene.getCode());

        if (currentScene.getCode() == "C2a" && currentScene.getSubCode() == "#6") {
            c2aa6();
        } else if (currentScene.getCode() == "C2a") {
            SceneManager.LoadScene("Chalet_2a2");
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_2b");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_2c");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_2d");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2aa6() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#2"));

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }

    }
}