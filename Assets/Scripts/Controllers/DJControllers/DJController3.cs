using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DJController3 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ3");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "DJ3") {
            dj3();
        } else if (currentScene.getCode() == "DJ1") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_1");
        } else if (currentScene.getCode() == "DJ2") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_2");
        } else if (currentScene.getCode() == "DJ4") {
            audioSource.Play();
            SceneManager.LoadScene("DJ_4");
        } else if (currentScene.getCode() == "D") {
            audioSource.Play();
            SceneManager.LoadScene("Dancefloor");
        }

    }

    void dj3() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ2");
        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ4");
        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
