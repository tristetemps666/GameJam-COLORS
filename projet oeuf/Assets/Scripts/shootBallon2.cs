using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBallon2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

    public Animator AnimPlayer;
    public float distanceMin;
    public float intensité;
    private float distance;
    private Vector3 difference;
    /*private float xx;
    private float yy;*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        difference = (transform.position - player.position); // on récup le vecteur directeur sur lequel on va faire l'envoie
        /*xx = Mathf.Sign(difference.x);
        yy = Mathf.Sign(difference.y);*/
        distance = difference.magnitude; // on récup que la direction dans le plan
        if (distance<distanceMin){
            Debug.Log("touched !!");
            difference.Normalize();
            Debug.Log(difference);
            GetComponent<Rigidbody>().AddForce(difference.x*intensité, intensité*2,difference.y*intensité);

            AnimPlayer.SetBool("shoot", true);
        }
        
    }
}
