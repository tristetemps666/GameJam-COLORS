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

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        //// SETUP DES VAR
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
    
        Vector3 direction = new Vector3(horizontal, -1f, vertical).normalized;

        
        //// GESTION DES ANIMATIONS POUR LE PERSO
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

        
        //// DEPLACEMENT APPLIQUER
        if (direction.magnitude >= 0.1f){
            controller.Move(direction *speed*Time.deltaTime);
        }

        // Pour la sauterelle follow le man

        if (aSuivre.name == "Personnage"){
            diff = (aSuivre.transform.position - transform.position);
            distance = diff.magnitude;
            if (distance > 3){ // trop loin, doit se rapprocher
                diff.Normalize();
                controller.Move(diff *speed*Time.deltaTime);
            }
        }
        //controller.Move(grav*Time.deltaTime);
    }

}
