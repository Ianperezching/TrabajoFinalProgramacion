using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientodejugador : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    public int direccionx;
    public int direcciony;
    public int speedx;
    public Animator animator;
    private SpriteRenderer _compspriteRenderer;
    public Transform detectordespawner;
    public GameManagercontrol gameManager;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        _compspriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d") == true)
        {
            direccionx = 1;
            _compspriteRenderer.flipX = false;
            animator.SetInteger("caminar abajo",direccionx);

        }
        else if (Input.GetKey("a") == true)
        {
            direccionx = -1;
            _compspriteRenderer.flipX = true;
            animator.SetInteger("caminar abajo", direccionx);
        }
        else
        {
            _compspriteRenderer.flipX = false;
            direccionx = 0;
            animator.SetInteger("caminar abajo",0);
            
        }
        if (Input.GetKey("w") == true)
        {
            direcciony = 1;
            _compspriteRenderer.flipY = false;
            animator.SetInteger("caminar arriba", direcciony);
        }
        else if (Input.GetKey("s") == true)
        {
            direcciony = -1;
            _compspriteRenderer.flipY = false;
            animator.SetInteger("caminar derecha", direcciony);
        }
        else
        {
            _compspriteRenderer.flipY = false;
            animator.SetInteger("caminar derecha", 0);
            animator.SetInteger("caminar arriba", 0);
            direcciony = 0;
        }

    }
    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(direccionx * speedx, direcciony * speedx);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            recibidaño();
        }
        else if (collision.gameObject.tag == "fantasma2")
        {
            recibidaño(3);
        }
        else if (collision.gameObject.tag == "fantasma3")
        {
            recibidaño(15,-10);
        }
    }
    public void recibidaño()
    {
        gameManager.Vidastotal(10);
    }
    public void recibidaño(int velocidad)
    {
        gameManager.Vidastotal(5);
        speedx = velocidad;
    }
    public void recibidaño(int daño,int puntuacion)
    {
        gameManager.Vidastotal(daño);
        gameManager.Sumarpuntos(puntuacion);
    }
   

}

