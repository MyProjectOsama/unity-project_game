using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform player;
    [SerializeField] float eagleHieght = 2;
    [SerializeField] float speed = 2;
    SpriteRenderer sr;
    Vector3 startpos;
    void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        startpos = transform.position;
        StartCoroutine(eagleanimation());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x < transform.position.x)
            sr.flipX= true;
        else
            sr.flipX= false;
    }

    IEnumerator eagleanimation()
    {
        Vector3 endpos = new Vector3(startpos.x,startpos.y + eagleHieght,startpos.z);
        bool isflight = true;
        float value = 0;
        while (1 == 1)
        {
            yield return null;
            if (isflight)
            {
                transform.position = Vector3.Lerp(startpos,endpos,value);
            }
            else
            {
                transform.position = Vector3.Lerp(endpos, startpos, value);

            }
            value = value + Time.deltaTime * speed;
            if (value> 1)
            {
                value = 0;
                isflight = !isflight;
            }

        }
        
       
    }
}
