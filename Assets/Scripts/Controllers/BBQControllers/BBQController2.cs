﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BBQController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "S2");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "S2") {
            s2();
        } else if (currentScene.getCode() == "S2a") {
            audioSource.Play();
            SceneManager.LoadScene("BBQ_2a");
        } else if (currentScene.getCode() == "S1") {
            audioSource.Play();
            SceneManager.LoadScene("BBQ_1");
        } else if (currentScene.getCode() == "M") {
            audioSource.Play();
            SceneManager.LoadScene("Molkky");
        } else if (currentScene.getCode() == "C") {
            audioSource.Play();
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "B") {
            audioSource.Play();
            SceneManager.LoadScene("Bar");
        }

    }

    void s2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S2a");
        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "S1");
        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");
        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");
        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
