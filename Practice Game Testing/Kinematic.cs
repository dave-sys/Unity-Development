using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematic : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2D;
    private Vector2 direction = Vector2.down;


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (rb2D.transform.position.y < -15)
        {
            direction = Vector2.up;
        }
        else if (rb2D.transform.position.y > 2)
        {
            direction = Vector2.down;
        }
    }

    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direction * speed * Time.deltaTime);
    }
    //void OnCollisionEnter2D(Collision2D collision)
    //{
        //collision.transform.SetParent(gameObject.transform,true);
    //}
    //void OnCollisionExit2D(Collision2D collision)
    //{
        //collision.transform.SetParent(null);
    //}
}
