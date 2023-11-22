using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplatan : MonoBehaviour
{
    [SerializeField] float ziplayan = 15.1f;
    
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb =collision.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, ziplayan);
    }
}
