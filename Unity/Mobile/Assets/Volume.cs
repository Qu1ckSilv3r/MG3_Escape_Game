using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Volume : MonoBehaviour {
    public Slider volumeSlider;

    public AudioSource footsteps;
    public AudioSource voices;
    public AudioSource keys;
    public AudioSource alarmRight;
    public AudioSource alarmWrong;

    private AudioHandler script;

    // Use this for initialization
    void Start () {
        script = GameObject.Find("Sources").GetComponent<AudioHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        footsteps.volume = volumeSlider.value;
        voices.volume = volumeSlider.value;
        keys.volume = volumeSlider.value;
        alarmRight.volume = volumeSlider.value;
        alarmWrong.volume = volumeSlider.value;
    }

    public void stopAll()
    {
        script.setMove(false);
        alarmRight.Stop();
        alarmWrong.Stop();
}

    public void toggleAlarmRight()
    {
        stopAll();
        alarmRight.Play();
        
    }

    public void toggleAlarmWrong()
    {
        stopAll();
        alarmWrong.Play();
        
    }

    public void toggleFootsteps()
    {
        voices.PlayDelayed(30);
        footsteps.PlayDelayed(2);
        script.setMove(true);
    }
}
