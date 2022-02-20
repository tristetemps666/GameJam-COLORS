using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuiviCam : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetObject;
    public float smoothSpeed = 0.125f;
    private Vector3 cameraOffset;
    public Vector3 cameraPos;


    //public bool pointe;
    //public bool follow;
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (follow){
            Vector3 desiredPosition = targetObject.transform.position + cameraOffset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position,desiredPosition, smoothSpeed);
            
            transform.position = smoothPosition;
            //transform.LookAt(targetObject);
        //}

        /*if (pointe){
            transform.LookAt(targetObject);
            
            if(!follow) transform.position = cameraPos;
        }*/
    }
}
