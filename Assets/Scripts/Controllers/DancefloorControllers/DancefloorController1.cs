using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DancefloorController1 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "D1");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "D1") {
            d1();
        } else if (currentScene.getCode() == "D1a") {
            SceneManager.LoadScene("Dancefloor_1a");
        } else if (currentScene.getCode() == "D2") {
            SceneManager.LoadScene("Dancefloor_2");
        } else if (currentScene.getCode() == "D3") {
            SceneManager.LoadScene("Dancefloor_3");
        } else if (currentScene.getCode() == "D4") {
            SceneManager.LoadScene("Dancefloor_4");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "T") {
            SceneManager.LoadScene("Table");
        } else if (currentScene.getCode() == "J") {
            SceneManager.LoadScene("Jeux");
        } else if (currentScene.getCode() == "F") {
            SceneManager.LoadScene("Foret");
        } else if (currentScene.getCode() == "B") {
            SceneManager.LoadScene("Bar");
        } else if (currentScene.getCode() == "M") {
            SceneManager.LoadScene("Molkky");
        } else if (currentScene.getCode() == "S") {
            SceneManager.LoadScene("BBQ");
        } else if (currentScene.getCode() == "DJ") {
            SceneManager.LoadScene("DJ");
        }
    }

    void d1() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D1a");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D2");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D3");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "D4");

        } else if (Input.GetKeyDown(KeyCode.C)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        } else if (Input.GetKeyDown(KeyCode.T)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "T");

        } else if (Input.GetKeyDown(KeyCode.J)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "J");

        } else if (Input.GetKeyDown(KeyCode.F)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "F");

        } else if (Input.GetKeyDown(KeyCode.B)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "B");

        } else if (Input.GetKeyDown(KeyCode.M)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "M");

        } else if (Input.GetKeyDown(KeyCode.S)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "S");

        } else if (Input.GetKeyDown(KeyCode.D)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "DJ");

        }
    }
}
