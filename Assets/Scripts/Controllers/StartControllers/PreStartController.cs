using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PreStartController : MonoBehaviour {

    public Image image;

	// Use this for initialization
	void Start () {

        image.canvasRenderer.SetAlpha(1.0f);
        InvokeRepeating("FadeToText", 0f, 0.0001f);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (image.canvasRenderer.GetAlpha() <= 0.0f)
        {

            CancelInvoke("FadeToText");

            InvokeRepeating("FadeToBlack", 2f, 0.1f);

            Debug.Log(image.canvasRenderer.GetAlpha());
        }

        if (image.canvasRenderer.GetAlpha() > 1.0f)
        {
            SceneManager.LoadScene("Start");
        }

    }

    void FadeToText()
    {

        Debug.Log("fadetotext");
        Debug.Log(image.canvasRenderer.GetAlpha());

        // La ligne suivante est SALE mais CrossFadeAlpha ne fonctionne pas pour d'obscure raison dans ce sens donc dirty code is dirty.
        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() - 0.003f);

    }

    void FadeToBlack() {
        Debug.Log(image.canvasRenderer.GetAlpha());

        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.0009f);
    }
}
