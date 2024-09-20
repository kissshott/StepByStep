using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdInitialize : MonoBehaviour
{
    private void Awake()
    {
        MobileAds.Initialize(initStatus => { });
        RequestConfiguration requestConfiguration = new RequestConfiguration.Builder()
        .SetMaxAdContentRating(MaxAdContentRating.G)
        .build();
        MobileAds.SetRequestConfiguration(requestConfiguration);
    }
}
