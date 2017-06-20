using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsbInsertClick : MonoBehaviour {
    public GameObject thisScreen;
    public GameObject thatScreen;
    public GameObject andThatScreen;
    public GameObject meldenButton;
    public GameObject makeInvisible1;
    public GameObject makeInvisible2;


    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {

        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (Input.GetButtonDown("Interact"))
            {
                makeInvisible1.SetActive(false);
                makeInvisible2.SetActive(false);
                andThatScreen.SetActive(false);
                thatScreen.SetActive(true);
                meldenButton.SetActive(true);
                thisScreen.SetActive(false);
            }
        }
    }
}
