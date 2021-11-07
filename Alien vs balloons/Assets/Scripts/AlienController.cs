using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    //Activating animation
    Animator _anim;

    private Rigidbody2D _rb;
    Vector2 input;
    public float sped = 50f;


    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        input.y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown (KeyCode.W))
        {
            _anim.GetComponent<Animator>().Play("Upload");
            _anim.SetBool("Upload", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _anim.GetComponent<Animator>().Play("GoDown");
            _anim.SetBool("GoDown", true);


        }


    }

    private void FixedUpdate()
    {
        _rb.velocity = input * sped * Time.fixedDeltaTime;
    }
}
