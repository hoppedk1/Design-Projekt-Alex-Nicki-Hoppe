using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {
    public class KegleSpawner : MonoBehaviour
    {
        // Keglerne/objekterne, der skal spawnes undervejs - vælges i Editor'en
		public GameObject kegleprefab;

		// Sætter gang i processen med at skabe en ny kegle efter lidt tid. 
		// Kaldes fra den "gamle" kegle, som er ved at blive ødelagt
        public void NyKegle(float spawntid) {
            StartCoroutine(KegleFabrik(spawntid));
        }

        IEnumerator KegleFabrik(float tid) {
            print("Spawner en ny kegle om " + tid + ", tiden er nu " + Time.time);
            yield return new WaitForSeconds(tid);
            print("... og her kom den: " + Time.time);            
            
            Instantiate (kegleprefab, 
						 new Vector3(Random.Range(-50.0f, 50.0f), 5, Random.Range(-50.0f, 50.0f)), 
						 Quaternion.identity
			);
        }	
    }
}
