using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirSpawners : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spawner"))
        {
            Destroy(collision.gameObject);
        }
        
    }
}
