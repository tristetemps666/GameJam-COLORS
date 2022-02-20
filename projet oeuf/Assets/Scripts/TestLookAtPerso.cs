using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestLookAtPerso : MonoBehaviour
{
    public Transform targetObject;
    private Quaternion angle;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(targetObject);
        transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
    }
}
