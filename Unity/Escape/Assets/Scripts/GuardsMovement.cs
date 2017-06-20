using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardsMovement : MonoBehaviour {
    private float endPoint = 0.5f;
    private float speed = 0.0003f;
    private Canvas timesUp;
    public bool move;
    public AudioSource voices;
    public AudioSource steps;
    public AudioSource doorUnlock;
    private int delay = 350;
    private int voiceDelay = 350;
    private int timePassed = 0;

	// Use this for initialization
	void Start () {
        move = true;
        timesUp = GameObject.FindGameObjectWithTag("timesUp").GetComponent<Canvas>();
        voices.PlayDelayed(voiceDelay);
        //steps.PlayDelayed(2);
        timePassed = 0;
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setMove(bool moving)
    {
        move = moving;
        if (!moving)
        {
            voices.Stop();
           // steps.Stop();
        }
    }

    void FixedUpdate()
    {
        if(timePassed >= delay)
        {
            if(transform.localPosition.x < endPoint && move)
             {
              transform.localPosition = new Vector3(transform.localPosition.x + speed, 0, 0);
            }
            else{
                voices.Stop();
               // steps.Stop();
                doorUnlock.Pause();
                doorUnlock.Play();
                if (!doorUnlock.isPlaying)
                {
                timesUp.enabled = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                }
                
            }
        }
        else
            {
             timePassed++;
            }
        
    }
}
