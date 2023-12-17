using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PasarScene : MonoBehaviour
{ 
    public void pasar()
    {
        SceneManager.LoadScene("Juego");
    }
    public void pasarcontroles()
    {
        SceneManager.LoadScene("Controles");
    }
    public void pasarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
   

}
