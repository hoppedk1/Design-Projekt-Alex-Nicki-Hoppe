using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {

	public class MazeCoin : MonoBehaviour {

        public GameObject explosionprefab;

        public int pointValue = 1;

        public Rigidbody rb; // gør at man kan ændre i rigidbody, bruges i respawn til at ændre hastighed

        private GameControl script;

        void Start(){
            script = FindObjectOfType<GameControl>();
        }


        void OnCollisionEnter(Collision other){
            print ("Noget ramte mig: " + other.gameObject.tag);
            if (other.gameObject.CompareTag ("Player")) {
                Explode();
              
                Invoke("Respawn",2);
            }
        }

        void Explode(){
            print ("AAARGHHH! - Jeg døøør, siger keglen");
             //transform.localScale *= 0; // hvis den bliver ganged med 0 så forsvinder de bare, hvilket nok ikke er den bedste løsning
            // Destroy(gameObject, 1); // fjerner det som den er lagt på, efter 1 sekundt i dette tilfælde. // har slået den fra siden at jeg prøver at have dem respawn
            var ildkugle = (GameObject)Instantiate(
                explosionprefab,
                transform.position,
                transform.rotation
            ); 
            script.AddScore(pointValue);
        }
        void Respawn(){ // er "lånt" af Pascal hvor jeg så ændre den til min bane
            int x = Random.Range(500, 600); // Banen er -50 til 50 (var det gælder alle baner)
            float y = 5;            // 5.2 Det her er banes højde 
            int z = Random.Range(500,600); // Banen er -50 til 50 // den første bane har en bane længere nede som også fungere, og har koordinaterne -172,-262

            transform.position = new Vector3(x, y, z);  // Den her teleporter den til et nyt sted når den rammes
            rb.velocity = new Vector3(0,0,0);           // Den her sørger for at hastigheden fjernes
             }

    }
}

