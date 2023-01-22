using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isDead;

    [SerializeField] ParticleSystem bloodEffect;

    [SerializeField] Transform headTransform;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow") || collision.gameObject.CompareTag("NinjaStar"))
        {
            Transform arrow = collision.gameObject.transform;
            bool isRight;

            if (arrow.position.x > transform.position.x) isRight = true;
            else isRight = false;

            headTransform.position = SetPos(arrow.position, arrow.localScale.x / 2, isRight);

            bloodEffect.Play();
            isDead = true;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Star"))
        {
            collision.gameObject.SetActive(false);
            ScoreManager.starNumber++;
        }
    }

    Vector2 SetPos(Vector2 targetPos, float targetSize, bool isRight)
    {
        Vector2 headPosition;
        if (isRight)
        {
            headPosition = new Vector2(targetPos.x - targetSize, targetPos.y);
        }
        else
        {
            headPosition = new Vector2(targetPos.x + targetSize, targetPos.y);
        }
        return headPosition;
    }

}
