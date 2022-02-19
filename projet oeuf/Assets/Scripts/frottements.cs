using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frottements : MonoBehaviour
{
    public float valFrottement;
    public Rigidbody obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.velocity.magnitude > 0.05){
            obj.velocity = obj.velocity*(valFrottement);
        }
    }
}
