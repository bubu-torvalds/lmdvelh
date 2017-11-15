using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController2d : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        audioSource.Play();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "N2d");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "N2d") {
            n2d();
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky");
        } 

    }

    void n2d() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
