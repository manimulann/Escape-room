using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceMovement : MonoBehaviour
{
    public Animator moPrin;
    float horizontialMove = 0f;
    float verticalMove = 0f;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        moPrin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontialMove = Input.GetAxisRaw("Horizontal") * speed;
        verticalMove = Input.GetAxisRaw("Vertical") * speed;
        moPrin.SetFloat("speed", horizontialMove);
        moPrin.SetFloat("vspeed", verticalMove);
        if (Input.GetKey(KeyCode.W))
        {
         GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
           
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            
        }

  

    }
}

