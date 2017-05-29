﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletWcPorteController : MonoBehaviour {

    public Wedding wedding;
    public List<Scene> scenes;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "C1");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "C1") {
            c1();
        } else if (currentScene.getCode() == "C1a") {
            SceneManager.LoadScene("Chalet_wc");
        } 

    }

    // On change de scene et on va à la porte des WC 
    void c1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C1a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }

    }

}
