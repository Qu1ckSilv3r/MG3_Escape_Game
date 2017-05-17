using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeHandler : MonoBehaviour {

    public AudioSource testAudio;
    public Slider volumeSlider;

	// Use this for initialization
	void Start () {
        volumeSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        //volumeSlider.value = testAudio.volume;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("value - " + volumeSlider.value);
    }

    public void ValueChangeCheck()
    {
        testAudio.volume = volumeSlider.value;
        Debug.Log("value - " + volumeSlider.value);
    }
}
