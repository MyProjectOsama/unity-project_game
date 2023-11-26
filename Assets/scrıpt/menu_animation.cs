using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_animation : MonoBehaviour
{
    [SerializeField] GameObject start;
    [SerializeField] GameObject finish;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enimy_karga;
    [SerializeField] GameObject enimy_slaim;
    [SerializeField] GameObject enimy_dinasor;
    [SerializeField] GameObject enimy_kedi;
    [SerializeField] float time_player = 1f;
    [SerializeField] float time_kedi = 1f;
    [SerializeField] float time_dinasor = 1f;
    [SerializeField] float time_slaim = 1f;
    [SerializeField] float time_karga = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player_movment(time_player);
        karga(time_karga);
        slim(time_slaim);
        kedi(time_kedi);
        dainasor(time_dinasor);
    }
    private IEnumerator player_movment(float time)
    {
        while (true)
        {
            Instantiate(player, new Vector3(start.transform.position.x, start.transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
    private IEnumerator karga(float time)
    {
        while (true)
        {
            Instantiate(enimy_karga, new Vector3(start.transform.position.x, start.transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
    private IEnumerator slim(float time)
    {
        while (true)
        {
            Instantiate(enimy_slaim, new Vector3(start.transform.position.x, start.transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
    private IEnumerator kedi(float time)
    {
        while (true)
        {
            Instantiate(enimy_kedi, new Vector3(start.transform.position.x, start.transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
    private IEnumerator dainasor(float time)
    {
        while (true)
        {
            Instantiate(enimy_dinasor, new Vector3(start.transform.position.x, start.transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }

}
