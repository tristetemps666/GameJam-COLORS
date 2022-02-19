using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBallon : MonoBehaviour
{
    public GameObject player;
    private Vector3 difference;
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == player.name){
            Debug.Log("touched !!!:");
                // c'est ici qu'on ajoute une force à notre ballon !
            difference = (transform.position - player.transform.position).normalized; // on récup le vecteur directeur sur lequel on va faire l'envoie
            difference.y = 0f; // on récup que la direction dans le plan
            collision.gameObject.GetComponent<Rigidbody>().AddForce(difference.x, 2,difference.z);
        }
    }
    // Start is called before the first frame update
}