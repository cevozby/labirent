using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<BoxCollider2D>();

        string kevser = "17";
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.one;
    }
}
