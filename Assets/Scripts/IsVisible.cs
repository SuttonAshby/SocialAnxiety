using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour {
    
    public Renderer rend;
    private GuestTracker tracker;

    void Start()
    {
        rend = GetComponent<Renderer>();
        tracker = GetComponentInParent<GuestTracker>();
    }

    //NEED TO REVERSE VISIBILTY LIST
    void Update(){
        List<string> notVisible = GameManager.Instance.notVisible;
        if(rend.isVisible){
            notVisible.Remove(tracker.name);
            // if(!notVisible.Contains(tracker.name)){
            //     notVisible.Add(tracker.name);
            // }
            // Debug.Log(gameObject.name + " is visible");
        } else {
            if(!notVisible.Contains(tracker.name) && !tracker.turned){
                notVisible.Add(tracker.name);
            }
            // notVisible.Remove(tracker.name);
            // Debug.Log(gameObject.name + " is NOT visible");
        }
    }

}
