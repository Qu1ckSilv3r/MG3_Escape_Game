using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaData : MonoBehaviour {
    public bool bananaActivated = false;
    public bool dataCollected = false;
    public GameObject usbInsertScreen;
    public GameObject usbStick;
    public GameObject thisBanana;
    private AudioSource alarm;
    private AudioSource alarmOffice;

    // Use this for initialization
    void Start () {
        usbInsertScreen = GameObject.Find("Skaliert_Monitor").transform.Find("usbinsert").gameObject;
        usbStick = GameObject.Find("Obstschale").transform.Find("usbstick").gameObject;
        alarm = GameObject.Find("AlarmSource").GetComponent<AudioSource>();
        alarmOffice = GameObject.Find("AlarmSourceOffice").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (bananaActivated)
        {

            if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
            {
                if (Input.GetButtonDown("Interact"))
                {
                    alarmOffice.Stop();
                    alarm.Stop();
                    Debug.Log("Data collected, game won...well, not yet!");
                    dataCollected = true;
                    usbInsertScreen.SetActive(true);
                    usbStick.SetActive(true);
                    thisBanana.SetActive(false);


                    // transform.localPosition = new Vector3(transform.localPosition.x, 0.8f, transform.localPosition.z);
                }
            }
        }
    }
}
