using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EcranTitreController : MonoBehaviour {

    public Text textClignotant;
    public AudioSource audioSource;

    // Use this for initialization
    void Start () {

        StartCoroutine(BlinkText());

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) {

            audioSource.Play();

            SceneManager.LoadScene("PreStart");

        }

    }

    public IEnumerator BlinkText() {

        while (true) {
            //set the Text's text to blank
            textClignotant.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            //display “I AM FLASHING TEXT” for the next 0.5 seconds
            textClignotant.text = "Appuyez sur Entrée pour jouer";
            yield return new WaitForSeconds(.5f);
        }
    }


}
