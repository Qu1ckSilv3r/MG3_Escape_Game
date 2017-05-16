using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormsResetButton : MonoBehaviour {
    private GameObject[] gameObjectsToReset;
    private FormsPassword passwordScript;
    private Color defaultColor;

    void Start () {
        defaultColor = new Color(0.23f, 0.34f, 0.4f);
        gameObjectsToReset = GameObject.FindGameObjectsWithTag("formButton");
        passwordScript = GameObject.FindGameObjectWithTag("formsPassword").GetComponent<FormsPassword>();
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastScript>().wasHit == gameObject.name)
        {

            if (Input.GetButtonDown("Interact"))
            {
                transform.localPosition = new Vector3(transform.localPosition.x, 1, transform.localPosition.z);
            }
            if (Input.GetButtonUp("Interact"))
            {
                transform.localPosition = new Vector3(transform.localPosition.x, 1.01f, transform.localPosition.z);
                resetAll();
            }
        }
    }

    public void resetAll()
    {
        foreach (GameObject obj in gameObjectsToReset)
        {
            obj.transform.localPosition = new Vector3(-0.9f, 0.3f, obj.transform.localPosition.z);
            obj.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = defaultColor;
            obj.GetComponent<FormsPress>().pressed = false;
            passwordScript.resetArray();
        }
    }
}
