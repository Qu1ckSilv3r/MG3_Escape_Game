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
    public AudioSource einleitung;
    public AudioSource radio;
    public AudioSource radioSchluss;
    public AudioSource wachen;
    public AudioSource wachenEndeAlarm;
    public AudioSource wachenEndeEntdeckung;
    public AudioSource wachenNurStimmen;

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
        alarmWrong.volume = volumeSlider.value - 0.5f;
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

    public void toggleEinleitung()
    {
        stopAll();
        einleitung.Play();
    }

    public void toggleRadio()
    {
        stopAll();
        radio.Play();
    }

    public void toggleRadioSchluss()
    {
        stopAll();
        radioSchluss.Play();
    }

    public void toggleWachen()
    {
        stopAll();
        wachen.Play();
    }
    public void toggleWachenEndeAlarm()
    {
        stopAll();
        wachenEndeAlarm.Play();
    }

    public void toggleWachenEndeEntdeckung()
    {
        stopAll();
        wachenEndeEntdeckung.Play();
    }
    
}
