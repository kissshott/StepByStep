using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    [SerializeField]
    private UIButtons uiButtons;

  

    private void Start()
    {
        

        int[] arr = new int[4] { 1, 2, 3, 4 };
        int rand = Random.Range(0, 4);
        uiButtons = GameObject.Find("Canvas").GetComponent<UIButtons>();
    }
    private void OnCollisionEnter(Collision playerCol)
    {
        if(playerCol.gameObject.tag == "Player")
        {
            if(PlayerPrefs.GetString("vibration") != "No")
            {
                Handheld.Vibrate();
            }
            if (PlayerPrefs.GetInt("RemoveAds") != 1)
            {
                int rand = Random.Range(0, 3);
                if (rand == 1)
                {
                    InterAd.interAd.ShowAd();
                }
            }
            
            uiButtons.Lose();
            
        }
    }
}
