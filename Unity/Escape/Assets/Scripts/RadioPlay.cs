using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPlay : MonoBehaviour {
    private AudioSource audioSource;
    public GameObject radioLed;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (Input.GetButtonDown("Interact"))
            {
                transform.localPosition = new Vector3(transform.localPosition.x, 0.8f, transform.localPosition.z);
                audioSource.Play();
                radioLed.SetActive(false);
            }
            if (Input.GetButtonUp("Interact"))
            {
                transform.localPosition = new Vector3(transform.localPosition.x, 0.81f, transform.localPosition.z);                
            }
        }
    }
    }

