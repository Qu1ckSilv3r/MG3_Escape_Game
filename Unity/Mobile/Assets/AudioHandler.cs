using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioHandler : MonoBehaviour {
    private float endPoint = 0;
    private float speed = 0.003f;
    public bool move;
    public AudioSource voices;
    public AudioSource steps;
    public AudioSource doorUnlock;
    private int delay = 60;
    private int timePassed = 0;

    // Use this for initialization
    void Start()
    {
        move = false;
        timePassed = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setMove(bool moving)
    {
        move = moving;
        if (!moving)
        {
            voices.Stop();
            steps.Stop();
        }
    }

    void FixedUpdate()
    {
        if (timePassed >= delay)
        {
            if (move)
            {
               
                if (transform.localPosition.x < endPoint)
            {
                transform.localPosition = new Vector3(transform.localPosition.x + speed, 0, 0);
            }
            else
            {
                    move = false;
                voices.Stop();
                steps.Stop();
                doorUnlock.Pause();
                doorUnlock.Play();
                if (!doorUnlock.isPlaying)
                {
                    Time.timeScale = 0;
                }

            }
            }
            
        }
        else
        {
            timePassed++;
        }

    }
}
