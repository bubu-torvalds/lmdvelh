using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstPageController : MonoBehaviour {

    public Image image;

    // Use this for initialization
    void Start () {

        image.canvasRenderer.SetAlpha(0.0f);

    }

    void Update() {

        Debug.Log(image.canvasRenderer.GetAlpha());

        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.003f);

        if (image.canvasRenderer.GetAlpha() >= 1.0f) {
            SceneManager.LoadScene("EcranTitre");
        }
    }

}
