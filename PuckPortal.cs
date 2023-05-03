using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckPortal : MonoBehaviour
{

    public GameObject portal;
   
    private GameObject player;
    
    float x1;
    float y1;
    float x2;
    float y2;

    private Timer time;

    


    void Start()
    {
        player = GameObject.FindWithTag("Puck");
        portal = GameObject.FindWithTag("PortalExit");
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
       
            if (other.tag == "Puck")
            {
              player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
              StartCoroutine(ResetPortal());
           
            }

           
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Puck")
        {
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
            player.transform.position.AsVector2();
         
            StartCoroutine(ResetPortal());
            

        }
    }

    private void  Update()
    {
        


        x1 = Random.Range(-3.4f, 3.4f);
        y1 = Random.Range(-2.3f, 2.33f);
        y2 = Random.Range(-3.1f, 3.1f);
        x2 = Random.Range(-2.7f, 2.7f);




    }

    public IEnumerator ResetPortal()
    {

        yield return new WaitForSecondsRealtime(3);

        portal.transform.position = new Vector2(x2, y2);
        

    }
    public IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(15);
    }

    private void FixedUpdate()
    {
        StartCoroutine(Wait());
    }


    
   
  
}
