using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleTrigger1 : MonoBehaviour
{
    public GameObject Axe;
    public GameObject Sword;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) == Sword)
        {
            Debug.Log("No Damage. Reread the riddle and try again.");
        }

        else if (Input.GetMouseButton(0) == Axe)
        {
            Debug.Log("DAMAGE. You are correct.");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Knight")
        {
            Debug.Log("I am sharp to the point and single-handled. I can be used for battle, but not well. Click who am I.");
        }
    }

    

}



