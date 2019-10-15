using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour {
    
    public Renderer rend;
    private Component tracker;

    void Start()
    {
        rend = GetComponent<Renderer>();
        tracker = GetComponentInParent<GuestTracker>();
    }

    void Update(){
        List<string> visible = GameManager.Instance.visible;
        if(rend.isVisible){
            if(!visible.Contains(tracker.name)){
                visible.Add(tracker.name);
            }
            // Debug.Log(gameObject.name + " is visible");
        } else {
            visible.Remove(tracker.name);
            // Debug.Log(gameObject.name + " is NOT visible");
        }
    }

}
