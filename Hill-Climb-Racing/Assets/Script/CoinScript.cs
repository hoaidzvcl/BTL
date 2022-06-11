using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public Text CoinText;
    private int CoinNum;
    public AudioSource sou;
    public AudioClip coin;

    void Start()
    {
        CoinNum = 0;
        CoinText.text = "" + CoinNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            CoinNum += 1;
            sou.PlayOneShot(coin);
            Destroy(Coin.gameObject);
            CoinText.text = "" + CoinNum;

        }
    }

    void Update()
    {

    }
}