using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D BallRigidBody;
    public float speed = 10.0f;
    
    public float jumpHeight = 1f;
    public bool activeJump = false;

    private void Start()
    {
        
    }

    //part of Zigurous code
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.position +=  Vector3.left * this.speed * Time.deltaTime; 
        } else if ( Input.GetKey(KeyCode.RightArrow)){
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }

        Jump();
    }

    void Jump(){
        if (Input.GetButtonDown("Jump") && activeJump == true) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
