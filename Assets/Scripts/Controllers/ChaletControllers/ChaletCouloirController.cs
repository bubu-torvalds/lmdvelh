using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletCouloirController : MonoBehaviour {

    public Wedding wedding;
    public List<Scene> scenes;
    public Text desc;
    private Scene currentScene;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        //TODO put default scene in a tag of the xml schema. default scene is C at the moment. 
        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2") {
            c2();
        } else if (currentScene.getCode() == "C2a") {
            int rand = Randomizer.random(1, 6);
            print(rand);
            print("Chalet_canevas_" + rand);
            SceneManager.LoadScene("Chalet_canevas_" + rand);
        } else if (currentScene.getCode() == "C2b") {               // On change de scene et on va vers la porte du fond (chambre mysterieuse)
            SceneManager.LoadScene("Chalet_chambre_mystere");
        } else if (currentScene.getCode() == "C2c") {
            SceneManager.LoadScene("Chalet_sdb");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_chambre_mira");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }

    }

    // On change de scene et on va dans le couloir
    void c2() {

        desc.text = PrintText.printText(currentScene);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            print(currentScene.getCode());

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2a");

            print(currentScene.getCode());

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c");

        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }
    }


}
