using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AlarmScript : MonoBehaviour {
    private AudioSource alarm;
    private AudioSource alarmOffice;
    private Material parentMaterial;
    private Canvas fail;
    private Canvas success;
    private MonoBehaviour mouseLock;
    private GuardsMovement guards;

    // Use this for initialization
    void Start () {
        alarm = GameObject.Find("AlarmSource").GetComponent<AudioSource>();
        alarmOffice = GameObject.Find("AlarmSourceOffice").GetComponent<AudioSource>();
        parentMaterial = transform.parent.GetComponent<MeshRenderer>().material;
        fail = GameObject.FindGameObjectWithTag("failed").GetComponent<Canvas>();
        success = GameObject.FindGameObjectWithTag("Finish").GetComponent<Canvas>();
        guards = GameObject.Find("sourceGroup").GetComponent<GuardsMovement>();
        Time.timeScale = 1;
        //mouseLock = GameObject.FindGameObjectWithTag("Player")<FirstPersonController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (Input.GetButtonUp("Interact"))
            {
                guards.setMove(false);
                if (gameObject.name == "alarm_office")
                {
                    fail.enabled = true;
                    alarmOffice.Play();
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    Time.timeScale = 0;
                }
                else
                {
                    alarm.Play();
                    parentMaterial.color = Color.red;
                    success.enabled = true;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    Time.timeScale = 0;
                }
            }
        }
    }
}
