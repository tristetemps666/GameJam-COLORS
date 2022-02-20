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

    private bool finIntro=false;
    

    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            finIntro=true;
        }

        if (finIntro==true)
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
        if (horizontal !=0 || vertical !=0){ // on se déplace
            if (!source.isPlaying){
               //Debug.Log("SOOOOOOOON !!");
                source.PlayOneShot(mySound);
            }
        }

        if (horizontal == 0 && vertical == 0){ // on est fixe
            source.Stop();
            //Debug.Log("STOOOOP   SOOOOOOOON !!");
        }


        Vector3 direction = mainCamera.transform.TransformDirection(horizontal, 0, vertical);
        direction *= speed;
        controller.SimpleMove(direction); 

        }
    }
}


