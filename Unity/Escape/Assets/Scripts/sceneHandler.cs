using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame()
    {
        Debug.Log("start");
        SceneManager.LoadScene("scene", LoadSceneMode.Single);
    }

    public void exitGame()
    {
        Debug.Log("End");
        Application.Quit();
    }
}
