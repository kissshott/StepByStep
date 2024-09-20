using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text coins;
    void Update()
    {
        coins.text = PlayerPrefs.GetInt("Coins").ToString();
    }

}
