using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usbstick : MonoBehaviour {
    public Transform target;
    public GameObject usbStick;
    public float speed;

    // Use this for initialization
    void Start () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        StartCoroutine(Waiting());
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSecondsRealtime(3);
        usbStick.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        

    }
}
