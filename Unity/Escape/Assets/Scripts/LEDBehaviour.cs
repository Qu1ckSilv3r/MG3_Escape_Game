using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDBehaviour : MonoBehaviour {

    private bool flashing = false;
    private Light ledLight;
    private Material ledColor;
    private int timeElapsed = 0;
    public int flashingInterval;
	// Use this for initialization
	void Start () {
        ledLight = gameObject.GetComponent<Light>();
        ledColor = GetComponent<MeshRenderer>().material;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        timeElapsed++;
        if(timeElapsed == flashingInterval)
        {
            toggleFlashing();
            timeElapsed = 0;
        }
       
    }

    public void toggleFlashing() {
        flashing = !flashing;
        ledLight.color = flashing ? Color.red : Color.black;
        ledColor.color = flashing ? Color.red : new Color(1f, 0.6f, 0.6f);
    }
}
