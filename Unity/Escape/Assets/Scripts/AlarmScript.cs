using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmScript : MonoBehaviour {
    private AudioSource alarm;
    private AudioSource alarmOffice;
    private Material parentMaterial;
    private Canvas fail;

    // Use this for initialization
    void Start () {
        alarm = GameObject.Find("AlarmSource").GetComponent<AudioSource>();
        alarmOffice = GameObject.Find("AlarmSourceOffice").GetComponent<AudioSource>();
        parentMaterial = transform.parent.GetComponent<MeshRenderer>().material;
        fail = GameObject.FindGameObjectWithTag("failed").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (Input.GetButtonUp("Interact"))
            {
                if(gameObject.name == "alarm_office")
                {
                    fail.enabled = true;
                    alarmOffice.Play();
                }
                else
                {
                    alarm.Play();
                    parentMaterial.color = Color.red;
                }
            }
        }
    }
}
