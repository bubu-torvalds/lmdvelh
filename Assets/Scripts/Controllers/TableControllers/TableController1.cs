﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TableController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "T1");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "T1") {
            t1();
        } else if (currentScene.getCode() == "J") {
            SceneManager.LoadScene("Jeux");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }
    }

    void t1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.J)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "J");
        } else if (Input.GetKeyDown(KeyCode.D)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");
        }
    }
}
