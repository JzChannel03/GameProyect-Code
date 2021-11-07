using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    private bool canMove = true;
    public float bound_Y = 5f;

    
    private Animator anim;
    //private AudioSource explosionSound;

    void Awake()
    {
        anim = GetComponent<Animator>();
        //explosionSound = GetComponent<AudioSource>();
    }

    void Start()
    {
        Move();
    }

    void Update()
    {
        Move();
     
    }

    void Move()
    {
        if (canMove)
        {
            //speed = GetBalloonSpeed();
            Vector2 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;
            //Debug.Log(gameObject.name + " " + speed);
            if (temp.y > bound_Y)
                gameObject.SetActive(false);
        }
    }
}
