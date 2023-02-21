using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour {

    public BoxCollider playAreaCollider;
    public bool pelialueenSisalla;
    public Transform pelaaja;

    private void FixedUpdate()
    {
        // Tarkista, onko pelaaja pelialueen sisällä
        if (playAreaCollider.bounds.Contains(pelaaja.transform.position))
        {
            Debug.Log("Pelaaja on pelialueen sisällä.");
            pelialueenSisalla = true;
        }
        else
        {
            Debug.Log("Pelaaja on pelialueen ulkopuolella.");
            pelialueenSisalla = false;
        }
    }
}
