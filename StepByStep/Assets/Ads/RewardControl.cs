using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardControl : MonoBehaviour
{
    [SerializeField]
    GameObject reward;
    [SerializeField]
    Text coinLevel;
    int coin;
    void Update()
    {
        coin = int.Parse(coinLevel.text);
        //int rand = Random.Range(0, 2);
        if (coin >= 5)
        {
            reward.SetActive(true);
        }
    }

   
}
