using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour {

    public string wasHit = "";
	// Use this for initialization
	void Start () {
       
	}

    // Update is called once per frame
    void Update()
    {
        float rayLength = 500f;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
            wasHit = hit.collider.name;
           
    }
}
