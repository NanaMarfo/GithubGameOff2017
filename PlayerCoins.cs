using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCoins : MonoBehaviour
{
    public Text Coins;
    public int CoinsMG = 0;

    void Start()
    {
        CoinsMG = 0;
        Coins.text = "CoinsMG: " + CoinsMG.ToString() ;
    }


    void Update()
    {
        Coins.text = "CoinsMG: " + CoinsMG.ToString();
    }

    void OnTriggerEnter(Collider Cinfo)
    {
        if (Cinfo.tag == "MG")
        {
            CoinsMG = CoinsMG + 1;
        }
    }
}