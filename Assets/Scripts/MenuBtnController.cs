using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuBtnController : MonoBehaviour {
    public string next_scene; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    //on effect
    void OnMouseEnter() {

    }

    //off effect
    void OnMouseExit() {
        
    }

    //change scene
    void OnMouseDown() {
        Debug.Log("OnMouseDown");
        SceneManager.LoadScene(next_scene);
    }
}
