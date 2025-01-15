using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("Moving", false);
        GetComponent<Animator>().SetInteger("Direction", 0);
        float x = 0;
        float y = 0;
        if (Input.GetKey("w"))
        {
            y += 1;
            GetComponent<Animator>().SetBool("Moving", true);
            GetComponent<Animator>().SetInteger("Direction", 1);
        }
        if (Input.GetKey("s"))
        {
            y -= 1;
            GetComponent<Animator>().SetBool("Moving", true);
            GetComponent<Animator>().SetInteger("Direction", -1);
        }
        if (Input.GetKey("a"))
        {
            x -= 1;
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetBool("Moving", true);
            GetComponent<Animator>().SetInteger("Direction", 2);
        }
        if (Input.GetKey("d"))
        {
            x += 1;
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetBool("Moving", true);
            GetComponent<Animator>().SetInteger("Direction", 2);
        }
        if (x != 0 && y != 0)
        {
            x *= 0.7f;
            y *= 0.7f;
        }
        transform.position += (Vector3.up * y + Vector3.right * x) * 0.02f;
    }

}
