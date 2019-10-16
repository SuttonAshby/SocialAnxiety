using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestTracker : MonoBehaviour
{
    public bool turned = false;
    public bool watch = false;
    public bool isBlue = false;
    public string name;
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
        if(collider.gameObject.tag == "Player" && !turned){
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
        // if(Input.GetKey("r")){
        //     StartCoroutine("Turner");


        // }
    }
    public void GetTurned(){
        StartCoroutine("Turner");
    }

    IEnumerator Turner(){
        turned = true;
        watch = true;
        isBlue = true;
        blueEyes();
        GameManager.Instance.numTurned++;
        Debug.Log(name + " got turned");
        float randInt = Random.Range(.1f, 2.834f) * 1f;
        gameObject.GetComponent<Animator>().Play("Agony", 0, 0f);
        yield return new WaitForSeconds(randInt);
        Debug.Log("stopping after: " + randInt);
        gameObject.GetComponent<Animator>().enabled = false;
    }

}
