﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletHistoireController4 : MonoBehaviour {

    public Wedding wedding;
    public List<Scene> scenes;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2d") && (x.getSubCode() == "#4"));

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "C2d" && currentScene.getSubCode() == "#4") {
            c2dd4();
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_chambre_mystere");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_sdb");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }
		
	}

    void c2dd4() {
        //desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }
    }
}
