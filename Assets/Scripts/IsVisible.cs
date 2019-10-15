using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsVisible : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(renderer.IsVisibleFrom(Camera.main)){
    //         Debug.Log("Visible");
    //     } else {
    //         Debug.Log("Not Visible");
    //     }
    // }

    public Renderer rend;

    private float timePass = 0.0f;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnWillRenderObject()
    {
        GameManager.Instance.isRendered = true;
    //     timePass += Time.deltaTime;

    //     if (timePass > 1.0f)
    //     {
    //         timePass = 0.0f;
    //         print(gameObject.name + " is being rendered by " + Camera.current.name + " at " + Time.time);
    //     }
    // }
    }
}
