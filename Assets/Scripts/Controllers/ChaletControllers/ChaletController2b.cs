using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2b : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2b") {
            c2b();
        } else if (currentScene.getCode() == "C2b_0") {
            SceneManager.LoadScene("Chalet_2b0");
        } else if (currentScene.getCode() == "C2b_1") {
            SceneManager.LoadScene("Chalet_2b1");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_2c");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_2d");
        } else if (currentScene.getCode() == "C") { // ON retourne à l'entree
            SceneManager.LoadScene("Chalet");
        }

    }

    // On va vers la porte du fond (chambre mysterieuse)
    void c2b() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b_0");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b_1");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }

}
