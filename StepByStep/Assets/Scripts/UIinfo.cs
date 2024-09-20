using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIinfo : MonoBehaviour
{
    public static UIinfo Instatnce;

    [SerializeField]
    GameObject removeAdsBtn;
    
    void Start()
    {
        Instatnce = this;
        UpdateRemoveAds();
    }
    public void UpdateRemoveAds()
    {
        bool removeAds = PlayerPrefs.GetInt("RemoveAds") == 1;
        removeAdsBtn.SetActive(!removeAds);
    }

    public void UpdateBuyCoins()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
