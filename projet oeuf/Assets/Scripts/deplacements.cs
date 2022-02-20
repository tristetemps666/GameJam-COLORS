using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{

    public float speed = 6f;
    //public float gravity = -9.81f;
    private Vector3 moveD = Vector3.zero;
    public CharacterController controller;
    public Animator animator;

    private Vector3 diff;

    public GameObject aSuivre;
    private float distance; 
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        
        //// GESTION DES ANIMATIONS POUR LE PERSO
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (name == "Personnage"){
            
           
           
            if (horizontal == 1){
                animator.SetBool("droite", true);
            }
            if (horizontal != 1){
                animator.SetBool("droite", false);
            }

            if (horizontal == -1){
                animator.SetBool("gauche", true);
            }
            if (horizontal != -1){
                animator.SetBool("gauche", false);
            }
        }


        Vector3 direction = mainCamera.transform.TransformDirection(horizontal, 0, vertical);
        direction *= speed;
        controller.SimpleMove(direction); 
        /*if (aSuivre.name == "Personnage"){
        Vector3 direction = mainCamera.transform.TransformDirection(horizontal, 0, vertical);
        direction *= speed;
        controller.SimpleMove(direction); 

            if (distance > 3){ // trop loin, doit se rapprocher
                diff.Normalize();
                controller.Move(diff *speed*Time.deltaTime);
            }
        */
        }
    }

}
