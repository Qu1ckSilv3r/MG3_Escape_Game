using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormsPassword : MonoBehaviour {

    public GameObject[] password = new GameObject[4];

    private GameObject[] keys = new GameObject[4];
    private int index = 0;
    private FormsPress script;
    private Canvas finish;
    // Use this for initialization
    void Start () {
        script = GameObject.FindGameObjectWithTag("resetButton").GetComponent<FormsPress>();
        finish = GameObject.FindGameObjectWithTag("Finish").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void fillKeyArray(GameObject obj)
    {
        keys[index] = obj;
        index++;
        if(index == password.Length)
            checkPassword();
    }

    void checkPassword()
    {
        for(int i = 0; i < password.Length; i++)
        {
            if (password[i].name != keys[i].name)
            {
                Debug.Log("false pass");
                script.resetAll();
                index = 0;
            }
            else if(i == password.Length - 1)
            {
                Debug.Log("CONGRATZ");
                index = 0;
                finish.enabled = true;
            }
                
        }
    }
}
