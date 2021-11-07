using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private GameObject efecto;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(efecto, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
