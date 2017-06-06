using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletCanevasController5 : MonoBehaviour {

    public Wedding wedding;
    public List<Scene> scenes;
    public Text desc;
    private Scene currentScene;


    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#5"));

    }

    // Update is called once per frame
    void Update() {

        print(currentScene.getCode());

        if (currentScene.getCode() == "C2a" && currentScene.getSubCode() == "#5") {
            c2aa5();
        } else if (currentScene.getCode() == "C2a") {
            SceneManager.LoadScene("Chalet_canevas_6");
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_chambre_mystere");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_sdb");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_chambre_mira");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2aa5() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => (x.getCode() == "C2a") && (x.getSubCode() == "#6"));

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }

    }
}
