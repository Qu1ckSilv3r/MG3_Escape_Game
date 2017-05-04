using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FormsPress : MonoBehaviour
{

    private string wasHit;
    private GameObject[] gameObjectsToReset;
    private FormsPassword passwordCheck;
   

    // Use this for initialization
    void Start () {
        //wasHit = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit;
        if(gameObject.name == "reset")
        gameObjectsToReset = GameObject.FindGameObjectsWithTag("formButton");

        passwordCheck = GameObject.FindGameObjectWithTag("formsPassword").GetComponent<FormsPassword>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {
            if (gameObject.name == "reset") {
                if (Input.GetButtonDown("Interact"))
                {
                    transform.localPosition = new Vector3(transform.localPosition.x, 1, transform.localPosition.z);
                }
                if (Input.GetButtonUp("Interact")){
                    transform.localPosition = new Vector3(transform.localPosition.x, 1.01f, transform.localPosition.z);
                    resetAll();
                }
                }
            else{
                   if (Input.GetButtonUp("Interact")) {
                        transform.localPosition = new Vector3(-0.68f, 0.17f, transform.localPosition.z);
                        passwordCheck.fillKeyArray(gameObject);
                    }
            }
           
        }
            

    }
     
    public void resetAll()
    {
        foreach (GameObject obj in gameObjectsToReset){
                obj.transform.localPosition = new Vector3(-0.9f, 0.3f, obj.transform.localPosition.z);
        }
    }
  

    void FixedUpdate()
    {
        
    }

}
