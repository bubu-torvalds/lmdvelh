﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {

        map.SetActive(false);

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
            audioSource.Play();
            SceneManager.LoadScene("Chalet_1a");
        } 

    }

    // On change de scene et on va à la porte des WC 
    void c1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C1a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }

    }

}
