using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2b1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b_1");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "C2b_1") {
            c2b_1();
        } else if (currentScene.getCode() == "C2b_0") {
            audioSource.Play();
            SceneManager.LoadScene("Chalet_2b0");
        } else if (currentScene.getCode() == "C2c") {
            audioSource.Play();
            SceneManager.LoadScene("Chalet_2c");
        } else if (currentScene.getCode() == "C2d") {
            audioSource.Play();
            SceneManager.LoadScene("Chalet_2d");
        } else if (currentScene.getCode() == "C") {
            audioSource.Play();// ON retourne à l'entree
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2b_1() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b_0");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
