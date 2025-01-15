using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class AdventureNPC : MonoBehaviour
{
    public GameObject text;
    float xfactor = 1;
    int time = 0;
    bool npc = false;
    public TMP_Text NPC_text;
    bool neu = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.right * 0.005f) * xfactor;
        if (transform.position.x > 0)
        {
            xfactor = -1;
        }
        if (transform.position.x < -5)
        {
            xfactor = 1;
        }
        if (npc)
        {
            time++;
        }
        if (time % 500 == 0 && npc)
        {
            text.SetActive(false);
            npc = false;
            neu = true;
        }
        if (neu)
        {
            NPC_text.text = "Cooler Junge";
        }
    }

    void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.SetActive(true);
            npc = true;
            time = 0;
        }
    }
}
