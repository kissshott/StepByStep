using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public static int coins;
    private int coinPiece;
    private GameObject coin;

    private AudioSource collect_audio;
    private void Start()
    {
        collect_audio = GameObject.FindGameObjectWithTag("Collect").GetComponent<AudioSource>();
        coinPiece = PlayerPrefs.GetInt("Coins");
        coin = this.gameObject;
    }
    
    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.tag == "Player")
        {
            coins++;
            coinPiece++;
            PlayerPrefs.SetInt("Coins", coinPiece);
            collect_audio.Play();
            Destroy(coin);
        }
    }
}
