using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestLookAt : MonoBehaviour
{
    public Transform targetObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(targetObject);
    }
}
