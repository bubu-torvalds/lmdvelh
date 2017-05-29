﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChaletCanevasController1 : MonoBehaviour {

    public Wedding wedding;
    public List<Scene> scenes;
    public Text desc;
    private Scene currentScene;


    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#1"));

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "C2a" && currentScene.getSubCode() == "#1") {
            c2aa1();
        } else if (currentScene.getCode() == "C2a") {
            SceneManager.LoadScene("Chalet_canevas_3");
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_chambre_mystere");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_sdb");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_chambre_mira");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2aa1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#3"));

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

