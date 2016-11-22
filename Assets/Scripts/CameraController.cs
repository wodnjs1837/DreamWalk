using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float moving_delay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    IEnumerator MovingCamera (Vector3 destination) {
        float startTime = Time.time;
        while (Time.time < startTime + moving_delay) {
            transform.position = Vector3.Lerp(transform.position, destination, (Time.time - startTime) / moving_delay);
            yield return null;
        }
        transform.position = destination;
    }
}
