﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController1b : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S1b");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S1b") {
            s1b();
        } else if (currentScene.getCode() == "S1c") {
            SceneManager.LoadScene("BBQ_1c");
        }

    }

    void s1b() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S1c");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
