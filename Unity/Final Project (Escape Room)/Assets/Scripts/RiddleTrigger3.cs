using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleTrigger3 : MonoBehaviour
{
    public GameObject BlueArrow;
    public GameObject YellowArrow;
    public GameObject RedArrow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Knight")
        {
            Debug.Log("Primary colors are my favorite. Especially when I look up at the sky. The Depth of The Ocean, Is The Same Color As I. Click which arrow I am.");
        }
    }

}






