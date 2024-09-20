using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterAd : MonoBehaviour
{
    private InterstitialAd interstitialAd;

    public static InterAd interAd;
    private string interstitialUnitId = "ca-app-pub-9505379398558871/3102267916";

    private void Start()
    {
        interAd = this;
    }
    private void OnEnable()
    {
        interstitialAd = new InterstitialAd(interstitialUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        RequestConfiguration requestConfiguration = new RequestConfiguration.Builder()
        .SetMaxAdContentRating(MaxAdContentRating.G)
        .build();
        MobileAds.SetRequestConfiguration(requestConfiguration);
        interstitialAd.LoadAd(adRequest);
    }

    public void ShowAd()
    {
        if (interstitialAd.IsLoaded())
            interstitialAd.Show();
    }
}