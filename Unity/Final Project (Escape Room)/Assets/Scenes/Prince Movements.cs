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
            //GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
            moPrin.Play("madarianwalkfront");
        }
        if (Input.GetKey(KeyCode.S))
        {
            moPrin.Play("madarianwalkback");
        }
        if (Input.GetKey(KeyCode.A))
        {
            moPrin.Play("madarianwalkleft");

        }
        if (Input.GetKey(KeyCode.D))
        {
            moPrin.Play("madarianwalkright");

        }

    }
}

