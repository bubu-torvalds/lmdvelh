using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1f;
    private float startTime;
    private float journeyLength;
    public float fracJourney;
    public float distCovered;

    // Use this for initialization
    void Start () {

        startTime = Time.time;
        print(startTime);
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        print(journeyLength);
    }   

    // Update is called once per frame
    void Update () {

        distCovered = (Time.time - startTime) * speed;
        print(distCovered);
        fracJourney = distCovered / journeyLength;
        print(fracJourney);

        print(Camera.main.transform.position);
        Camera.main.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);        
	}
}
