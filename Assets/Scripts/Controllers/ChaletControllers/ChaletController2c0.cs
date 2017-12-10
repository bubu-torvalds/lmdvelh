using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2c0 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    public GameObject map;
    private Scene currentScene;
    public AudioSource audioSource;
    public AudioSource audioSourceClic;

    // Use this for initialization
    void Start () {

        map.SetActive(false);

        wedding = LoadXml.LoadXmlFile();

        audioSource.Play();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c_0");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2c_0") {
            c2c0();
        } else if (currentScene.getCode() == "C2b") {
            audioSourceClic.Play();
            SceneManager.LoadScene("Chalet_2b");
        } else if (currentScene.getCode() == "C2d") {
            audioSourceClic.Play();
            SceneManager.LoadScene("Chalet_2d");
        } else if (currentScene.getCode() == "C") {
            audioSourceClic.Play();
            SceneManager.LoadScene("Chalet");
        }

    }

    void c2c0() {
        desc.text = PrintText.printText(currentScene);      

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.C)) {
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            map.SetActive(false);
        }
    }
}
