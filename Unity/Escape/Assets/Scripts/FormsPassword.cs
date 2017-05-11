using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormsPassword : MonoBehaviour {

    public GameObject[] password = new GameObject[4];

    private GameObject[] keys = new GameObject[4];
    private int index = 0;
    private FormsResetButton script;
    private Canvas finish;
    private SpriteRenderer lockscreenRenderer;
    private GameObject lockscreen;
    public Sprite defaultLockscreen;
    public Sprite wrongPassword;
    
    void Start () {
        script = GameObject.FindGameObjectWithTag("resetButton").GetComponent<FormsResetButton>();
        finish = GameObject.FindGameObjectWithTag("Finish").GetComponent<Canvas>();
        lockscreen = GameObject.Find("lockscreen");
        lockscreenRenderer = lockscreen.GetComponent<SpriteRenderer>();
    }
	
	void Update () {
		
	}

    public void fillKeyArray(GameObject obj)
    {
        if (index == 0) {
            lockscreenRenderer.sprite = defaultLockscreen;
        }
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
                script.resetAll();
                lockscreenRenderer.sprite = wrongPassword;
                return;
            }
            else if(i == password.Length - 1)
            {
                index = 0;
                lockscreen.SetActive(false);
            }
                
        }
    }

    public void resetArray()
    {
            index = 0;
            keys = new GameObject[4];
            lockscreenRenderer.sprite = defaultLockscreen;
    }
}
