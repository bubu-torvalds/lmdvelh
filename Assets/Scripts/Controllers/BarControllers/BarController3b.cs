﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarController3b : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "B3b");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "B3b") {
            b3b();
        } else if (currentScene.getCode() == "B3c") {
            audioSource.Play();
            SceneManager.LoadScene("Bar_3c");
        } else if (currentScene.getCode() == "B3c") {
            audioSource.Play();
            SceneManager.LoadScene("Bar_3c");
        } else if (currentScene.getCode() == "B3c") {
            audioSource.Play();
            SceneManager.LoadScene("Bar_3c");
        } else if (currentScene.getCode() == "B3c") {
            audioSource.Play();
            SceneManager.LoadScene("Bar_3c");
        } 
    }

    void b3b() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B3c");
        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B3c");
        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B3c");
        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B3c");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
