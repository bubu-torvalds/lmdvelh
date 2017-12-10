using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour {

    public Image image;

	// Use this for initialization
	void Start () {

        image.CrossFadeAlpha(0f, 2f, true);

    }
	
	// Update is called once per frame
	void Update () {
        

    }
}
