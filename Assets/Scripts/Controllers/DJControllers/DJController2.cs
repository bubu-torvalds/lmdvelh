﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DJController2 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "DJ2") {
            dj2();
        }  else if (currentScene.getCode() == "DJ2a") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_2a");
        } else if (currentScene.getCode() == "DJ2b") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_2b");
        } else if (currentScene.getCode() == "DJ2c") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_2c");
        } else if (currentScene.getCode() == "DJ2d") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_2d");
        }

    }

    void dj2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2c");
        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2d");
        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2a");
        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2b");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
