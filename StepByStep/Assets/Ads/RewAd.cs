using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class RewAd : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-9505379398558871/5345287872";

    private RewardedAd rewardedAd;

    [SerializeField]
    private Text levelcoin;
    private void OnEnable()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        RequestConfiguration requestConfiguration = new RequestConfiguration.Builder()
        .SetMaxAdContentRating(MaxAdContentRating.G)
        .build();
        MobileAds.SetRequestConfiguration(requestConfiguration);
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        int lcoin = int.Parse(levelcoin.text);
        lcoin *= 2;
        int coins = PlayerPrefs.GetInt("Coins");
        coins += lcoin;
        PlayerPrefs.SetInt("Coins", coins);

        Invoke("DelayRestart", 0.2f);
    }

    public void DelayRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ShowAd()
    {
        if (rewardedAd.IsLoaded())
            rewardedAd.Show();
    }
}
