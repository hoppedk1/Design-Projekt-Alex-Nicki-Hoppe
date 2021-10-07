using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {
	public class Respawn : MonoBehaviour {

        public GameObject KegleSpawn;

        public int pointValue = 1;

        //private GameControl script;

        void Start(){
            //script = FindObjectOfType<GameControl>();
        }

        void OnCollisionEnter(Collision other){
            print ("Noget ramte mig: " + other.gameObject.tag);
            if (other.gameObject.CompareTag ("Player")) {
                Explode ();
            }
        }

        void Explode(){
            print ("AAARGHHH! - Jeg døøør, siger keglen");
             //transform.localScale *= 0; // hvis den bliver ganged med 0 så forsvinder de bare, hvilket nok ikke er den bedste løsning
             //Destroy(gameObject, 2); // fjerner det som den er lagt på, efter 2 sekunder i dette tilfælde.
            var ildkugle = (GameObject)Instantiate(
                KegleSpawn,
                transform.position,
                transform.rotation
            ); /*
            script.AddScore(pointValue);*/
        }

    }
}

