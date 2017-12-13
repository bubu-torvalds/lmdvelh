using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostStart2Controller : MonoBehaviour {

    public Text text;
    public Image image;

    // Use this for initialization
    void Start () {
        image.canvasRenderer.SetAlpha(1.0f);
        InvokeRepeating("FadeToText", 0f, 0.0001f);

    }
	
	// Update is called once per frame
	void Update () {

        if (image.canvasRenderer.GetAlpha() <= 0.4f) {

            CancelInvoke("FadeToText");
            InvokeRepeating("FadeToBlack", 0f, 0.001f);       

        }

        if (image.canvasRenderer.GetAlpha() > 1.0f)
        {
            SceneManager.LoadScene("Chalet");
        }

    }

    void FadeToText()
    {

        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() - 0.0003f);

    }

    void FadeToBlack()
    {
        Debug.Log(image.canvasRenderer.GetAlpha());
        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.0003f);

    }
}
