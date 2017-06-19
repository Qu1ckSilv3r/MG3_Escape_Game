using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {

        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (Input.GetButtonDown("Interact"))
            {
                Debug.Log("Data collected, game won.");
               // transform.localPosition = new Vector3(transform.localPosition.x, 0.8f, transform.localPosition.z);
            }
        }
    }
}
