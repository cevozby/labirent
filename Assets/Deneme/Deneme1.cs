using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme1 : MonoBehaviour
{
    string deneme = "Çakýþma var mý?";
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<BoxCollider2D>();

        string kevser = "17";
        int kevserYas = 15;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.one;
        string kevserortu = "mavi"; 
    }
}
