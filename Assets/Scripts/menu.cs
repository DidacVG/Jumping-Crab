using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Credits");
    }
}