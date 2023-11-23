using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gorunmezkolaid : MonoBehaviour
{
    Tilemap spr;
    [SerializeField] float hiz = 5.1f;
    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {

            // spr.color = Color.green * Time.deltaTime *hiz;
            spr.color += new Color(255, 255, 255 , 255);
             
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       
        if (collision.gameObject) {

            spr.color += new Color(0, 0, 0, 0);
        }
    }
}
