﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController2d : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        audioSource.Play();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "N2d");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "N2d") {
            n2d();
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky_0");
        } 

    }

    void n2d() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");

        } 
    }
}
