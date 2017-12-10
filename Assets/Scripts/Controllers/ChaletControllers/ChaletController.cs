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
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();
        
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

    }
        
    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "C") {                    // On affiche les textes de l'entrée du chalet
            c();
        } else if (currentScene.getCode() == "C1") {
            audioSource.Play();         // On change de scene et on va à la porte des WC 
            SceneManager.LoadScene("Chalet_1");
        } else if (currentScene.getCode() == "C2") {
            audioSource.Play();           // On change de scene et on va dans le couloir
            SceneManager.LoadScene("Chalet_2");
        } else if (currentScene.getCode() == "D") {
            audioSource.Play();
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "T") {
            audioSource.Play();
            SceneManager.LoadScene("Table");
        } else if (currentScene.getCode() == "S") {
            audioSource.Play();
            SceneManager.LoadScene("BBQ");
        }

    }

    // On affiche les textes de l'entrée du chalet
    void c() {

        desc.text = PrintText.printText(currentScene);       

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C1");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");

        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "T");

        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }

}
