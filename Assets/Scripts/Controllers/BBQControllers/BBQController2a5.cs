﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController2a5 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a5");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S2a5") {
            s2a5();
        } else if (currentScene.getCode() == "S2a51") {
            audioSource.Play();
            SceneManager.LoadScene("BBQ_2a51");
        } 

    }

    void s2a5() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a51");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
