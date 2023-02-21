using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public Text scoreText;  // Tekstikomponentti pistetuloksen näyttämiseksi
    private int score = 0;  // Pisteet
    private AudioSource audioSource;  // AudioSource-komponentti ääntehosteelle
    public Test2 pelialueenSis;

    void Start() {
        // Etsitään AudioSource-komponentti tästä GameObjectista
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        // Tarkistetaan, osuiko pallo reikään
        if (other.CompareTag("Pallo") && pelialueenSis.pelialueenSisalla) {
            Debug.Log("piste");
             // Lisätään yksi piste
            score++;
            // Päivitetään pistenäyttö
            scoreText.text = "Pisteet: " + score;
            // Toistetaan äänitehoste
            audioSource.Play();
        }
    }
}
