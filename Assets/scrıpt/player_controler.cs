using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;
using System;

public class player_controler : MonoBehaviour
{
   
    [SerializeField] float speed = 0.03f;
    [SerializeField] float jump = 11.9f;
    [SerializeField] float ziplayan = 15.5f;
    [SerializeField] TextMeshProUGUI TextHealth;
    [SerializeField] TextMeshProUGUI TextScore;
    public int player_helth = 100;
    public int score;
    public bool die;
    string hor = "Horizontal";
    string ver = "Vertical";
    bool isjump;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    Transform trans;
    Animator anim;
    //gorunmezkolaid gorunmezkolaid = new gorunmezkolaid();
    Vector3 startplan = new Vector3(-6,2.68f,0);
    void Start()
    {
        die = false;
        score = 0;
        isjump = false;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        trans = GetComponent<Transform>();
        anim = GetComponent<Animator>();
        TextHealth.text =player_helth +"";
        TextScore.text = score + "";
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //transform.Translate(new Vector3(-0.1f,0,0));
            sprite.flipX = true;

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //transform.Translate(new Vector3(+0.1f, 0, 0));
            sprite.flipX = false;

        }
        if (Input.GetButtonDown("Jump") && !isjump)
            {
                rb.velocity = new Vector2(0, jump);
                isjump = true;
            anim.SetBool("isjump", true);
        }
        if(Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            isjump = false;
            anim.SetBool("isjump",false);
        }
        anim.SetFloat("speed", Mathf.Abs( rb.velocity.x));
    }

    private void FixedUpdate()
        {
            rb.velocity = new Vector2(speed * Input.GetAxis(hor), rb.velocity.y);

            //Debug.Log(Time.deltaTime);
        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("yemek"))
        {
            Destroy(collision.gameObject);
            if (player_helth < 100)
            {
                player_helth = player_helth + 10;
                Debug.Log("player helth : " + player_helth);
                TextHealth.text = player_helth + "";
            }


        }
        else if (collision.gameObject.CompareTag("elmas"))
        {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("score : " + score);
            TextScore.text = score + "";

        }
        else if (collision.gameObject.CompareTag("deai"))
        {
            IsDie();
        }
        else if (collision.gameObject.CompareTag("enemiygarga"))
        {

            if (isjump && rb.velocity.y < 0)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                player_helth = player_helth - 10;
                TextHealth.text = player_helth + "";
                anim.SetBool("isdaia", true);
                Debug.Log(player_helth);
                if (player_helth <= 0)
                {
                    Debug.Log("daei");
                    IsDie();
                }
            }



        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemiygarga")
        {
            anim.SetBool("isdaia", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enimy"))
        {

            if (isjump && rb.velocity.y < 0)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                player_helth = player_helth - 10;
                TextHealth.text = player_helth + "";
                anim.SetBool("isdaia", true);
                Debug.Log(player_helth);
                if (player_helth <= 0)
                {
                    Debug.Log("daei");
                    IsDie();
                }
            }



        }
        if (collision.gameObject.tag == "ziplayan")
        {
            
            isjump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Enimy")
        {
            anim.SetBool("isdaia", false);
        }
        


    }
  
  void IsDie()
    {
        die=true;
        trans.position = startplan;
        player_helth = 100;
        TextHealth.text = player_helth + "";
        //gorunmezkolaid.sprTilmap.color = Color.clear; 
    }



}
