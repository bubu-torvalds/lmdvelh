using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour {

    public Image image;

    // Use this for initialization
    void Start () {
        image.canvasRenderer.SetAlpha(0.0f);

    }
	
	// Update is called once per frame
	void Update () {

        // La ligne suivante est SALE mais CrossFadeAlpha ne fonctionne pas pour d'obscure raison dans ce sens donc dirty code is dirty.
        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.0003f);

    }
}
