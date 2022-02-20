using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{

    public float speed = 6f;
    //public float gravity = -9.81f;
    private Vector3 moveD = Vector3.zero;
    public CharacterController controller;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        /*float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, -1f, vertical).normalized;
        //Vector3 grav = new Vector3(0f,gravity, 0f);
        */

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = mainCamera.transform.TransformDirection(horizontal, 0, vertical);
        direction *= speed;
        controller.SimpleMove(direction); 

        /*if (direction.magnitude >= 0.1f){
            controller.Move(direction *speed*Time.deltaTime);
        }*/
        //controller.Move(grav*Time.deltaTime);
    }

}
