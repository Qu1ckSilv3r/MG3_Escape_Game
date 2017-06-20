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
    private GameObject obstLed;
    private GameObject banana;
    private GameObject guardsObject;

    // Use this for initialization
    void Start () {
        alarm = GameObject.Find("AlarmSource").GetComponent<AudioSource>();
        alarmOffice = GameObject.Find("AlarmSourceOffice").GetComponent<AudioSource>();
        parentMaterial = transform.parent.GetComponent<MeshRenderer>().material;
        fail = GameObject.FindGameObjectWithTag("failed").GetComponent<Canvas>();
        success = GameObject.FindGameObjectWithTag("Finish").GetComponent<Canvas>();
        guards = GameObject.Find("sourceGroup").GetComponent<GuardsMovement>();
        guardsObject = GameObject.Find("Guards");
        // ist anfangs inaktiv, daher die umstaendliche suche
        obstLed =  GameObject.Find("Box_mit_Einlegeboden").transform.Find("LED").gameObject;
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
                    obstLed.SetActive(true);
                    // Um die Wachen braucht man sich nun nicht mehr sorgen!
                    guardsObject.SetActive(false);
                    // Funktion aktivieren, dass man in der Banane Daten finden kann (lol)
                    GameObject.Find("banane (2)").GetComponent<BananaData>().bananaActivated = true;
                    /*
                    success.enabled = true;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    Time.timeScale = 0;
                    */
                }
            }
        }
    }
}
