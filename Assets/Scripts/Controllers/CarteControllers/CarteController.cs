﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarteController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "CA");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "CA") {
            ca();
        } else if (currentScene.getCode() == "C") {
            audioSource.Play();
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "T") {
            audioSource.Play();
            SceneManager.LoadScene("Table");
        } else if (currentScene.getCode() == "J") {
            audioSource.Play();
            SceneManager.LoadScene("Jeux");
        } else if (currentScene.getCode() == "F") {
            audioSource.Play();
            SceneManager.LoadScene("Foret");
        } else if (currentScene.getCode() == "B") {
            audioSource.Play();
            SceneManager.LoadScene("Bar");
        } else if (currentScene.getCode() == "M") {
            audioSource.Play();
            SceneManager.LoadScene("Molkky");
        } else if (currentScene.getCode() == "S") {
            audioSource.Play();
            SceneManager.LoadScene("BBQ");
        } else if (currentScene.getCode() == "DJ") {
            audioSource.Play();
            SceneManager.LoadScene("DJ");
        }
    }

    void ca() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "T");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "J");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "F");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");

        } else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");

        } else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ");

        }
    }
}
