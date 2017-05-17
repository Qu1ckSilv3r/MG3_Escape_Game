using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("HELLO");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void quitApp()
    {
        Application.Quit();
    }
}
