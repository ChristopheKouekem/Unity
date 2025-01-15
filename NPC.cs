using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    public string newText = "Hello World!";
    public GameObject text;


    public TMP_Text NPC_text;

    float timer = 0;
    private object displayText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer > displayText.Length - 1)
        {
            text.GetComponent<TMP_Text>().text = displayText.Substring(0, (int)timer);

        }
        else
        {
            text.SetActive(false);
            //NPC_text.text = "haha du loser";

        }




    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            text.SetActive(true);
            text.GetComponent<TMP_Text>().text = "";
            displayText = "";
        }


    }
}
