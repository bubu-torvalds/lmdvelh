using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChaletController2c0 : MonoBehaviour {

    public Wedding wedding;
    public Text desc;
    private Scene currentScene;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {

        wedding = LoadXml.LoadXmlFile();

        currentScene = wedding.getScenes().Find(x => x.getCode() == "C2c_0");

    }
	
	// Update is called once per frame
	void Update () {

        if (currentScene.getCode() == "C2c_0") {
            c2c0();
        } else if (currentScene.getCode() == "C2b") {
            SceneManager.LoadScene("Chalet_2b");
        } else if (currentScene.getCode() == "C2d") {
            SceneManager.LoadScene("Chalet_2d");
        } else if (currentScene.getCode() == "C") {
            SceneManager.LoadScene("Chalet");
        }

    }


    void c2c0() {
        desc.text = PrintText.printText(currentScene);

        /*AudioMixer mixer = Resources.Load("Music/AudioMixer") as AudioMixer;
        string outputMixer = "Master";

        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.outputAudioMixerGroup = mixer.FindMatchingGroups(outputMixer)[0];
        audioSource.priority = 128;
        audioSource.pitch = 0.9f;
        audioSource.loop = false;
        audioSource.volume = 0.1f;
        audioSource.rolloffMode = AudioRolloffMode.Logarithmic;
        audioSource.minDistance = 1;
        audioSource.maxDistance = 500;
        audioSource.bypassEffects = true;
        audioSource.bypassReverbZones = true;
        audioSource.bypassListenerEffects = true;
        audioSource.dopplerLevel = 1;
        audioSource.spatialBlend = 0f;
        audioSource.reverbZoneMix = 1;
        audioSource.panStereo = 0;
        audioSource.spread = 0;
        audioSource.spatialize = false;*/


        audioSource.Play();

        Debug.Log(audioSource.isPlaying);

        if (Input.GetKeyDown(KeyCode.Keypad1)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2b");

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C2d");

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            currentScene = wedding.getScenes().Find(x => x.getCode() == "C");

        }
    }
}
