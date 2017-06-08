using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

    }
        
    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "C") {                    // On affiche les textes de l'entrée du chalet
            c();
        } else if (currentScene.getCode() == "C1") {            // On change de scene et on va à la porte des WC 
            SceneManager.LoadScene("Chalet_1");
        } else if (currentScene.getCode() == "C2") {            // On change de scene et on va dans le couloir
            SceneManager.LoadScene("Chalet_2");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "T") {
            SceneManager.LoadScene("Table");
        } else if (currentScene.getCode() == "S") {
            SceneManager.LoadScene("BBQ");
        }

    }

    // On affiche les textes de l'entrée du chalet
    void c() {

        desc.text = PrintText.printText(currentScene);       

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C1");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "T");

        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        }
    }

}
