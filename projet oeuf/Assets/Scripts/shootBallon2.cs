using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBallon2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float distanceMin;
    public float intensité;
    private float distance;
    private Vector3 difference;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        difference = (transform.position - player.transform.position); // on récup le vecteur directeur sur lequel on va faire l'envoie
        distance = difference.magnitude; // on récup que la direction dans le plan
        if (distance<distanceMin){
            Debug.Log("touched !!");
        GetComponent<Rigidbody>().AddForce(difference.x*intensité, intensité*2,difference.y*intensité);
        }
        
    }
}
