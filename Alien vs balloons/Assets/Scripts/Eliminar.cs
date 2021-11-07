using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eliminar : MonoBehaviour
{
    public GameObject Explocion;
    //Animator anim;
    public Text gameOver;

    private void Awake()
    {
        gameOver.gameObject.SetActive(false);
    }

    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Instantiate(Explocion, transform.position, transform.rotation);
            Destroy(gameObject);
            gameOver.gameObject.SetActive(true);
        }
    }

    
}
