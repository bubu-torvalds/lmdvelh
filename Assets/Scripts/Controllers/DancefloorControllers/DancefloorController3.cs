﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DancefloorController3 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "D3");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "D3") {
            d3();
        } else if (currentScene.getCode() == "D1") {
            audioSource.Play();
            SceneManager.LoadScene("Dancefloor_1");
        } else if (currentScene.getCode() == "D2") {
            audioSource.Play();
            SceneManager.LoadScene("Dancefloor_2");
        } else if (currentScene.getCode() == "D4") {
            audioSource.Play();
            SceneManager.LoadScene("Dancefloor_4");
        } else if (currentScene.getCode() == "DJ") {
            audioSource.Play();
            SceneManager.LoadScene("DJ");
        } else if (currentScene.getCode() == "CA") {
            audioSource.Play();
            SceneManager.LoadScene("Carte");
        }
    }

    void d3() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D1");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D4");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "CA");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
