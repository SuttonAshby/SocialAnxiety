using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollow : MonoBehaviour
{
    public bool track = true;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if(track){
            transform.LookAt(target);        
        }
    }
}
