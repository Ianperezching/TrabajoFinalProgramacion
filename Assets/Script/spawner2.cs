using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearenemigos2 : MonoBehaviour
{ 
    public GameObject[] prefabenemigo;
    public GameManagercontrol GameManagercontrols;
    public int Peso;
    public GameObject Objetivoaseguir;
    public GameObject personaje;
    void Start()
    {
        Invoke("Crearenemigo", 5);
    }

    void Crearenemigo()
    {
        GameObject randomenemy = prefabenemigo[Random.Range(0, prefabenemigo.Length)];

        Instantiate(randomenemy, transform.position, transform.rotation);
        Invoke("Crearenemigo", 10);
    }
   public void setgameManager(GameManagercontrol gm)
    {
        GameManagercontrols = gm;
    }
     public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "a")
        {
            Destroy(gameObject, 1);
            GameManagercontrols.Sumarpuntos(20);
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            this.transform.position = new Vector2(Objetivoaseguir.transform.position.x, Objetivoaseguir.transform.position.y);
        }
    }
    public void SetObjetivoasegir(GameObject objetivo)
    {
        Objetivoaseguir = objetivo;
    }
    public void SetPersonaje(GameObject player)
    {
        personaje = player;
    }
   
}
