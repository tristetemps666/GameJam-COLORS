using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regardCam : MonoBehaviour
{
    public Transform targetObject;
    //private Vector3 scalceInv;

// Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //scalceInv = transform.localScale;
        transform.LookAt(targetObject);
        
    }
}
