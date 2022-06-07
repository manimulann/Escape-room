using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleTrigger2 : MonoBehaviour
{
    public GameObject Skulldoor;
    public GameObject Skullpile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) == Skullpile)
        {
            Debug.Log("Close but not quite. Reread the riddle and try again.");
        }

        if (Input.GetMouseButton(0) == Skulldoor)
        {
            Debug.Log("DAMAGE. Good Job!");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Knight")
        {
            Debug.Log("I Don't Have Eyes, But Once I Did See. Once I Had Thoughts, But Now I'm Empty. To Get Through This Door, I am the Key. Click who I am.");
        }
    }
}
