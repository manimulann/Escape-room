using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceMovement : MonoBehaviour
{
    public Animator moPrin;
    // Start is called before the first frame update
    void Start()
    {
        moPrin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
            moPrin.Play("madarianwalkback");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
            moPrin.Play("madarianwalkfront");
        }

        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
            moPrin.Play("madarianwalkleft");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            moPrin.Play("madarianwalkright");
        }

        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}

