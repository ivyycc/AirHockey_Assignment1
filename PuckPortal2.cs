using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckPortal2 : MonoBehaviour
{
    public GameObject portal2;

    private GameObject player;
    float x1;
    float y1;
    float x2;
    float y2;




    void Start()
    {
        player = GameObject.FindWithTag("Puck");
        portal2 = GameObject.FindWithTag("Portal");
        
 

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.tag == "Puck")
        {
            player.transform.position = new Vector2(portal2.transform.position.x, portal2.transform.position.y);
            StartCoroutine(ResetPortal());
 
        }
      

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Puck")
        {
            StartCoroutine(ResetPortal());
         
           


        }
    }
    public IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(10);
    }

    private void Update()
    {
        
       


        x1 = Random.Range(-3.4f, 3.4f);
        y1 = Random.Range(-2.3f, 2.33f);
        y2 = Random.Range(-3.1f, 3.1f);
        x2 = Random.Range(-2.7f, 2.7f);



    }

    public IEnumerator ResetPortal()
    {

        yield return new WaitForSecondsRealtime(7);

        portal2.transform.position = new Vector2(x1, y1);
        

    }
}
