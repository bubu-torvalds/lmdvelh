using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

    public GameObject map;

	// Use this for initialization
	void Start () {

        map.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.C)) {
            Debug.Log("OUCOU");
            map.SetActive(true);
        } else if (Input.GetKeyUp(KeyCode.C)) {
            Debug.Log("Bye");
            map.SetActive(false);
        }
         
    }
}
