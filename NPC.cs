using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject text;
    bool npc = false;
    public TMP_Text NPC_TextOut;
    public static float timer = 0;
    public static float timerlenght = 0;
    public static string NPC_TextIn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (npc)
            timer -= Time.deltaTime;
        if (timer < 0)
        {
            text.SetActive(false);
            npc = false;
            timerlenght = 0;
        }
    }

    IEnumerator Typing()
    {
        int i = -1;
        float zeit = 0.1f;
        while (!NPC_TextOut.text.ToString().Equals(NPC_TextIn))
        {
            string typ = NPC_TextIn.Substring(i + 1);
            string typadd = typ.Substring(0, 1);
            NPC_TextOut.text += typadd;
            yield return new WaitForSeconds(zeit);
            i++;
        }

    }

    public int CoinSearch()
    {
        GameObject player = GameObject.FindWithTag("Player");
        int coin = 0;
        coin = player.GetComponent<Purse>().coins;
        return coin;
    }

    public static void Textzeit()
    {
        for (int i = 0; i < NPC_TextIn.Lenght; i++)
        {
            timerlenght += 0.2f;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            int coin = CoinSearch();
            NPC_TextOut.text = "Du hast " + coin + " Münzen!";
            NPC_TextIn = NPC_TextOut.text.ToString();
            NPC_TextOut.text = "";
            Textzeit();
            timer = timerlenght;
            text.SetActive(true);
            npc = true;
            StartCoroutine(Typing());
        }
    }
}
