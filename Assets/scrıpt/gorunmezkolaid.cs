using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gorunmezkolaid : MonoBehaviour
{
    [SerializeField] float hiz = 5.1f;
    public Tilemap sprTilmap;
    // Start is called before the first frame update
    void Start()
    {
        sprTilmap = GetComponent<Tilemap>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void HidingTheBox( )
    {
        sprTilmap.color += new Color(0, 0, 0, 0); 
    }
private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {

            // spr.color = Color.green * Time.deltaTime *hiz;
            sprTilmap.color += new Color(255, 255, 255, 255);

        }
    }
    
  /* private void OnCollisionExit2D(Collision2D collision)
    {
       
        if (collision.gameObject) {

            sprTilmap.color = Color.clear;
        }
    }*/
}
