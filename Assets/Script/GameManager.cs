using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagercontrol : MonoBehaviour
{
    public int punto;
    public Text puntosdetexto;
    public Text vidastexto;
    public int vidatotal;
   public GameObject paredadestruir;
   
    public void Start()
    {
        Sumarpuntos(0);
        Vidastotal(0);
    }
    public void Sumarpuntos(int puntos)
    {
        punto = puntos + punto;
        puntosdetexto.text = "Puntos: " + punto;
        if (punto >= 100)
        {
            Destroy(paredadestruir);
        }

    }
    public void Vidastotal(int vidas)
    {
        vidatotal = vidatotal + vidas;
        vidastexto.text = "Miedo:" + vidatotal;
        if (vidatotal >= 200)
        {
            SceneManager.LoadScene("Derrota");
        }
    }

}
