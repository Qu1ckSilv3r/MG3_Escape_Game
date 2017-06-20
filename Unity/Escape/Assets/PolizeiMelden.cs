using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolizeiMelden : MonoBehaviour {
    private AudioSource abspann;

    // Use this for initialization
    void Start () {
        abspann = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (Input.GetButtonDown("Interact"))
            {
                abspann.Play();
            }
        }
    }
}

