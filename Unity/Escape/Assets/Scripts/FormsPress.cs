using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FormsPress : MonoBehaviour
{

    public bool pressed;
    private Material childMaterial;
    private FormsPassword passwordCheck;
   

    // Use this for initialization
    void Start () {
        childMaterial = transform.GetChild(0).GetComponent<MeshRenderer>().material;
        pressed = false;
        passwordCheck = GameObject.FindGameObjectWithTag("formsPassword").GetComponent<FormsPassword>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
                   if (Input.GetButtonUp("Interact") && !pressed) {
                        transform.localPosition = new Vector3(-0.68f, 0.17f, transform.localPosition.z);
                        childMaterial.color = Color.green;
                        pressed = true;
                        passwordCheck.fillKeyArray(gameObject);
                    }
        }
            

    }

    void FixedUpdate()
    {
        
    }

}
