using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NousController2b : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;
    public AudioSource audioSourceClic;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        audioSource.Play();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "N2b");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "N2b") {
            n2b();
        } else if (currentScene.getCode() == "N2a") {
            audioSourceClic.Play();
            SceneManager.LoadScene("Nous_2a");
        } else if (currentScene.getCode() == "N2c") {
            audioSourceClic.Play();
            SceneManager.LoadScene("Nous_2c");
        } else if (currentScene.getCode() == "N2d") {
            audioSourceClic.Play();
            SceneManager.LoadScene("Nous_2d");
        }

    }

    void n2b() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "N2d");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
