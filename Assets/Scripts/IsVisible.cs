using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour {
    
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update(){
        if(rend.isVisible){
            Debug.Log(gameObject.name + " is visible");
        } else {
            Debug.Log(gameObject.name + " is NOT visible");
        }
    }

}
