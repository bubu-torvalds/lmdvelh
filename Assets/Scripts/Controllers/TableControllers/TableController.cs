using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TableController : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start() {

        wedding = LoadXml.LoadXmlFile();
 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "T");

    }

    // Update is called once per frame
    void Update() {

        if (currentScene.getCode() == "T") {
            t();
        } else if (currentScene.getCode() == "T1") {
            SceneManager.LoadScene("Table_1");
        } else if (currentScene.getCode() == "T2") {
            SceneManager.LoadScene("Table_2");
        } else if (currentScene.getCode() == "J") {
            SceneManager.LoadScene("Jeux");
        } else if (currentScene.getCode() == "D") {
            SceneManager.LoadScene("Dancefloor");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        } else if (currentScene.getCode() == "BUS") {
            SceneManager.LoadScene("Bus");
        }

    }

    void t() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "T1");
        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "T2");
        } else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "J");
        } else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "D");
        } else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");
        } else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
            currentScene = wedding.getScenes().Find(x => x.getCode() == "BUS");
        }
    }
    
}
