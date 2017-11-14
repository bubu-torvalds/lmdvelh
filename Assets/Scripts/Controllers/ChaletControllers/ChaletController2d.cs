﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2d : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2d" && currentScene.getSubCode() == "2d") {
            c2d();
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_2b");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_2c");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "C2d") {
            int rand = Randomizer.random(1, 6);
            SceneManager.LoadScene("Chalet_2d" + rand);
        }
        

    }

    void c2d() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2d") && (x.getSubCode() == "#1"));

        } else if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } 
    }
}
