using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ToggleHandler : MonoBehaviour {

    public Sprite on;
    public Sprite off;
    private SpriteRenderer toggle;
    private bool toggled = false;

	// Use this for initialization
	void Start () {
        toggle = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void switchSprite()
    {
        Debug.Log("clicked");
        toggle.sprite = toggled ? off : on;
        toggled = !toggled;
    }
}
