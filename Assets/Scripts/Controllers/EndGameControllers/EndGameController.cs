using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour {

    public Wedding wedding;
    public Image image;
    public Sprite imageFin;
    public Sprite texteFin;

    private Scene currentScene;

    // Use this for initialization
    void Start() {

        GetComponent<Image>().sprite = imageFin;

        image.canvasRenderer.SetAlpha(0.0f);

        Debug.Log(image.canvasRenderer.GetAlpha());

        InvokeRepeating("FadeToImage", 2f, 0.001f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (image.canvasRenderer.GetAlpha() >= 1.0f) {

            Debug.Log("image.canvasRenderer.GetAlpha() >= 1f");

            CancelInvoke("FadeToImage");

            InvokeRepeating("FadeToBlack", 0f, 0.001f);

            Debug.Log(image.canvasRenderer.GetAlpha());
        }

        if (image.canvasRenderer.GetAlpha() < 0f) {

            CancelInvoke("FadeToBlack");

            GetComponent<Image>().sprite = texteFin;

            InvokeRepeating("FadeToText", 0f, 0.001f);
        }



        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("EcranTitre");

        } else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Score");
        }

    }

    void FadeToImage() {

        Debug.Log(image.canvasRenderer.GetAlpha());

        // La ligne suivante est SALE mais CrossFadeAlpha ne fonctionne pas pour d'obscure raison dans ce sens donc dirty code is dirty.
        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.0003f);

    }

    void FadeToBlack() {

        Debug.Log(image.canvasRenderer.GetAlpha());

        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() - 0.0003f);

    }

    void FadeToText() {

        Debug.Log("fadetotext");

        // La ligne suivante est SALE mais CrossFadeAlpha ne fonctionne pas pour d'obscure raison dans ce sens donc dirty code is dirty.
        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.0003f);

    }
}
