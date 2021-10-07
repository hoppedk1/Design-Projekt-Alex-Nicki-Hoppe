using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Denne pakke bruges til at skifte mellem scener/baner
using TMPro;  // TextMeshPro pakken - giver mange flere muligheder for at shine teksterne op

namespace Digiteknik {

	// Dette script skal holde styr på fremgangen i spillet og på de forskellige scener
	// Det skal ligge på et tomt GameObject i spil-scenen - kald det GameController
	
	public class GameControl : MonoBehaviour {

		// TextMeshPro objekter
        public TextMeshProUGUI sceneTekst;
		public TextMeshProUGUI pointTekst;
	
		// "Gammeldags" UI Text objekt, blot for sammenligningens skyld
		public Text timeTekst;

		public int tid = 100;
		public int vinderScore = 20;

		private int score;
		private int bane = 0;

		// Hver gang vi starter en ny scene tjekker vi om der er mere end en "Player"
		// Hvis der er, skal de overskydende fjernes, mens den "rigtige" Player skal 
		// bevares når scenen igen skifter.
		void Awake() {
			GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
			for (int i = objs.Length-1; i > 0; i--)
			{
				Destroy(objs[i]);
			}
			bane = SceneManager.GetActiveScene().buildIndex;
			DontDestroyOnLoad(objs[0]);//(this.gameObject);
		}

		// Brug Start() til initialisering - her startes tiden og nulstilles scoren på skærmen
		// Hvis man løber tør for tid har man tabt
		// Hvis score er større end VinderScore har man vundet
		void Start () {
			score = 0;
			UpdateScore ();			
			sceneTekst.enabled = false;
			// Coroutines er metoder som kan køre uafhængigt af selve scenen. 
			StartCoroutine (showTime());
		}

		// Viser resterende antal sekunder (dvs. health), samt tjekker om man har tabt
		IEnumerator showTime(){
			while (tid >= 0) {
				timeTekst.text = tid.ToString() + " Sek";
				yield return new WaitForSeconds (1); // Venter 1 sekund før tiden igen tælles ned
				tid--;
				if (tid < 0) {
					Taber();
				}
			}
		}

		// Sætter en ny score, og tjekker om man har vundet 
		public void AddScore (int addScoreValue){
			score += addScoreValue;
			UpdateScore ();
			if(score > vinderScore){				
				Vinder();
			}
		}

		// Tilføjer ekstra levetid ( = health). Kaldes blandt andet fra "Cheat"
		public void AddHealth (int howMuch){
			print ("Ekstra liv: " + howMuch);
			tid += howMuch;
		}

		// Sætterscore-værdien på skærmen
		void UpdateScore (){
			pointTekst.text = "Score: " + score;
		}		

		// Disse to funktioner kan senere bruges til at skifte scene og meget mere
		void Vinder() {
			StartCoroutine(showEnd("Du Vinder!!", true));
		}

		void Taber(){
			StartCoroutine(showEnd("Du TABER!", false));
		}	

		//Viser sluttekst i et antal sekunder og skifter scene, hvis der er en ny
		IEnumerator showEnd(string t, bool levelUp){
			sceneTekst.text = t;
			sceneTekst.enabled = true;
			yield return new WaitForSeconds (4);
			sceneTekst.enabled = false;
			if (levelUp) {
				bane += 1;
				print ("Skifter scene til " + bane);
				Scene thisScene = SceneManager.GetActiveScene();
				Debug.Log("Aktive Scene var: " + thisScene.name + ".");
				// Gør linjen nedenfor aktiv, når du har lavet en ny scene at skifte til
				SceneManager.LoadScene((thisScene.buildIndex + 1) % 2);
			}
		}		
	}
}

/* Lav et tomt GameObject og kald det GameController
 * Læg dette script på det. Scriptet har tre felter - hvad mon de gør?
 * Lav et UI Text GameObject - det laver så også et Canvas og et EventSystem
 * Kald Text objektet ScoreText, og lav to til der kunne hedde HealthText og SceneText.
 * Træk disse tre objekter ind på scriptet. Kør, og se hvad der sker

 * Gør teksterne større, og gør dem røde og grønne. Men pas på - dimensionerne skal 
 * følge med op, når man øger skriftstørrelsen

 * Så skal vi have teksterne til at stå rigtigt. Det er deres Rect Transforms vi skal have 
 * fat i. Undersøg hvad der sker når du ændrer på pivot og position. Bemærk, at man kan vælge
 * at rette disse ting til ved hjælp af Shift- og Alt-tasterne

 * Til sidst skal vi have score og helbred til at ændre sig. Kan du regne ud hvordan og hvor?
 */

