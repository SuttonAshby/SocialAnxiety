using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollow : MonoBehaviour
{
    public Transform target;
    public Transform buddy;
    public float speed = 2;


    // Update is called once per frame
    void Update()
    {
        Transform lookTo;
        if(gameObject.GetComponentInParent<GuestTracker>().watch){
            lookTo = target;
        } else {
            lookTo = buddy;
        }
        Quaternion rot = Quaternion.LookRotation(lookTo.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, speed * Time.deltaTime);
    }
}
