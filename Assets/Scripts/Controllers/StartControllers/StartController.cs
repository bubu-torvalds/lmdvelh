using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        audioSource.Play();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "ST");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "ST") {
            st();
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } 
    }

    void st() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } 
    }
}
