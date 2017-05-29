using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletSDBController : MonoBehaviour {

    public Wedding wedding;
    public List<Scene> scenes;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2c") {
            c2c();
        } else if (currentScene.getCode() == "C2c_0") {
            c2c_0();
        } else if (currentScene.getCode() == "C2c_1") {
            c2c_1();
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_chambre_mystere");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_chambre_mira");
        } else if (currentScene.getCode() == "C") { // ON retourne à l'entree
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2c() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c_0");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c_1");

        } 
    }

    void c2c_0() {
        desc.text = PrintText.printText(currentScene);

        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = Resources.Load("Music/bebePleure") as AudioClip;
        audioSource.loop = true;
        audioSource.volume = 0.2f;   
        audioSource.Play();
        

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }
    }

    void c2c_1() {
        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }
    }
}
