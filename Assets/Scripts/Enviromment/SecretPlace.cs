using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretPlace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            SpriteRenderer objectSR = GetComponent<SpriteRenderer>();
            objectSR.color = new Color(255, 255, 255, 0.5f);
        
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            SpriteRenderer objectSR = GetComponent<SpriteRenderer>();
            objectSR.color = new Color(255, 255, 255, 1f);
        }
    }

}
