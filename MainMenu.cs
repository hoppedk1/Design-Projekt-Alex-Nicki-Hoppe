using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Digiteknik {

    
    public class MainMenu : MonoBehaviour
    {
        private GameControl gc;

        public void Start() {
            gc = FindObjectOfType<GameControl>();
            Time.timeScale = 0f;
        }

        /* Kaldes fra startskærmen. Loader første bane, hvis startskærmen er scene 0 (dvs. 
           hvis startskærmen er en selvstændig scene med build index 0). 
           Ellers kaldes blot ResumeGame 
        */
        public void PlayGame() {
            //SceneManager.LoadScene(0);
            ResumeGame();
        }

        /* Kaldes når man trykker på "Menu"-knappen i en scene */
        public void AabenMenu() {
            Time.timeScale = 0f;  // Dette standser tiden, så spillet ikke kører mens man er i menuen
        }
        
        /* Kaldes når man trykker "Resume" i menuen */
        public void ResumeGame() {
            Time.timeScale = 1f;

        }

        /* Kaldes hver gang "+"-knappen på Cheat-menuen trykkes ned. 
           Kalder videre ind i GameControl 
        */
        public void MereTid() {
            gc.AddHealth(10);
            Debug.Log("Vi har nu " + gc.tid + " sekunder til at vinde");
        }

        /* Kaldes når man trykker "QUIT". 
           Det stopper ikke editoren, så derfor Debug.Log-ordren, så man kan se at noget sker
        */
        public void QuitGame() {
            Debug.Log("Quitting!");
            Application.Quit();
        }
    }
}
    /*  OPGAVER

        1. a) Træk den tilrettede GameController prefab med knap ind i din scene i stedet for
            den tidligere, eller b) Lav selv en ny knap (TextMeshPro) og skriv "Menu" på den, 
            og læg den under din GameController. Træk MenuCanvas prefab'en ind i din scene, og 
            sæt de actions, der skal ske når man trykker på de forskellige knapper: GameObjects 
            skal gøres aktive eller inaktive, funktioner skal køres, etc. Få det til at spille.

        2. Tilføj en "Options"-menu i MenuCanvas prefab'en, og sørg for at den åbner når man
            klikker på "Options"-knappen, samt at den lukker igen/genåbner Main Menu, når man 
            trykker på "Tilbage". Menuen skal ikke gøre noget lige nu, bortset fra måske at give 
            lidt info om hvilke kontroller, der er til rådighed i spillet.
            Hint: Lav en kopi af "Cheat"-menuen og tilret teksterne etc.

        3. Lav en funktion, der nulstiller spillet og giver mulighed for at starte det forfra,
            når man har tabt. Vis de relevante skærmbilleder og UI-komponenter
        
        4. Se om du kan få de øvrige tekster til at ligne menuen

        5. Tilpas det grafiske udtryk så det passer bedre til dit spil
    */
