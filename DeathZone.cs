using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {
	public class DeathZone : MonoBehaviour {

        public GameObject explosionprefab;

        public int pointValue = 1;

        //private GameControl script;

        void Start(){
            //script = FindObjectOfType<GameControl>();
        }

        void OnCollisionEnter(Collision Player){
            print ("Noget ramte mig: " + Player.gameObject.tag);
            if (Player.gameObject.CompareTag ("Death")) {
                Explode ();
            }
        }

        void Explode(){
            print ("AAARGHHH! - Jeg døøør, siger keglen");
             //transform.localScale *= 0; // hvis den bliver ganged med 0 så forsvinder de bare, hvilket nok ikke er den bedste løsning
            Destroy(gameObject, 1); // fjerner det som den er lagt på, efter 1 sekundt i dette tilfælde.
            var ildkugle = (GameObject)Instantiate(
                explosionprefab,
                transform.position,
                transform.rotation
            ); /*
            script.AddScore(pointValue);*/
        }

    }
}
