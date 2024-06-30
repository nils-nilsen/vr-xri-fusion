using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    // Start is called before the first frame update
    private Transform target;
    
    void Awake() {
        target = Camera.main.transform;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // add an offset to the camera of 0, 0, -2
            transform.position = target.position + new Vector3(0, 0, -2) * Time.deltaTime;
            // Debug.Log("Camera position: " + target.position);
            // Debug.Log("Target position: " + transform.position);
        }
        
    }
}