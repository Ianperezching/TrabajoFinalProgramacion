using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaciondeSpawners2 : MonoBehaviour
{
    public GameObject[] spawners;
    public GameManagercontrol GameManager;
    public GameObject Objetivoaseguir;
    public GameObject Jugador;
    void Start()
    {
        Invoke("CrearSpawn", 3);
    }
    void CrearSpawn()
    {
        int random = Random.Range(0, spawners.Length);
        GameObject randomenemy = spawners[random];
        float rnddistacia = Random.Range(1.1f, 4.06f);
        float rnddistanciay = Random.Range(-1.92f, -3.87f);
        GameObject Spawn = Instantiate(randomenemy, new Vector2(rnddistacia, rnddistanciay), transform.rotation);
        if (random == 0)
        {
            Spawn.GetComponent<Crearenemigos>().setgameManager(GameManager);
            Spawn.GetComponent<Crearenemigos>().SetObjetivoasegir(Objetivoaseguir);
            Spawn.GetComponent<Crearenemigos>().SetPersonaje(Jugador);
        }
        else if (random == 1)
        {
            Spawn.GetComponent<crearenemigos2>().setgameManager(GameManager);
            Spawn.GetComponent<crearenemigos2>().SetObjetivoasegir(Objetivoaseguir);
            Spawn.GetComponent<crearenemigos2>().SetPersonaje(Jugador);
        }
        Invoke("CrearSpawn", 10);

    }
}
