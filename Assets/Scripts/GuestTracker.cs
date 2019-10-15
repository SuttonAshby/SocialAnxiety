using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestTracker : MonoBehaviour
{
    public bool watch = false;
    public bool isBlue = false;
    private GameObject eyes;
    // Start is called before the first frame update
    void Start()
    {
        eyes = transform.Find("high-polyMesh").gameObject;
    }

    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
            watch = true;
        }
    }

    void OnTriggerExit(Collider collider){
        if(collider.gameObject.tag == "Player"){
            watch = false;
        }
    }

    public void blueEyes(){
        if(isBlue){
            eyes.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            eyes.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.blue * GameManager.Instance.eyeIntensity);
        } else {
            eyes.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
       
    }


    // Update is called once per frame
    void Update()
    {
        // blueEyes();
    }
}
