using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostStartController : MonoBehaviour {

    public Text textClignotant;
    public Image image;
    private int i = 0;

    // Use this for initialization
    void Start () {

        image.canvasRenderer.SetAlpha(0.0f);

        Debug.Log(image.canvasRenderer.GetAlpha());
        StartCoroutine(BlinkText());

    }
	
	// Update is called once per frame
	void Update () {

        if (this.i >= 4) {
            StopCoroutine(BlinkText());
            InvokeRepeating("FadeToBlack", 2f, 0.2f);

            if (image.canvasRenderer.GetAlpha() >= 1.0f) {
                SceneManager.LoadScene("PostStart2");
            }
        }
		
	}

    public IEnumerator BlinkText() {       

        while (this.i <= 4)
        {
            //set the Text's text to blank
            textClignotant.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            //display "?" for the next 0.5 seconds
            textClignotant.text = "?";
            yield return new WaitForSeconds(.5f);
            this.i++;
        }
    }

    void FadeToBlack()
    {

        Debug.Log(image.canvasRenderer.GetAlpha());

        image.canvasRenderer.SetAlpha(image.canvasRenderer.GetAlpha() + 0.0003f);

    }

}
