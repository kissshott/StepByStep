using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
public class Purchasing : MonoBehaviour
{
   
    public void OnPurchaseCompleted(Product product)
    {
        switch (product.definition.id)
        {
            case "com.azdevop.stepbystep.removeads":
                RemoveAds();
                break;

            case "com.azdevop.stepbystep.150coins":
                Add150coins();
                break;

            case "com.azdevop.stepbystep.300coins":
                Add300coins();
                break;

            case "com.azdevop.stepbystep.500coin":
                Add500coins();
                break;

            case "com.azdevop.stepbystep.1000coins":
                Add1000coins();
                break;
        }
    }

    private void RemoveAds()
    {
        PlayerPrefs.SetInt("RemoveAds", 1);
        Debug.Log("Purchase: RemoveAds");
        UIinfo.Instatnce.UpdateRemoveAds();
    }

    private void Add150coins()
    {
        int coins = PlayerPrefs.GetInt("Coins");
        coins += 150;
        PlayerPrefs.SetInt("Coins", coins);
        Debug.Log("Purchase: get 150 coins");
        UIinfo.Instatnce.UpdateBuyCoins();
    }

    private void Add300coins()
    {
        int coins = PlayerPrefs.GetInt("Coins");
        coins += 300;
        PlayerPrefs.SetInt("Coins", coins);
        Debug.Log("Purchase: get 300 coins");
        UIinfo.Instatnce.UpdateBuyCoins();
    }
    private void Add500coins()
    {
        int coins = PlayerPrefs.GetInt("Coins");
        coins += 500;
        PlayerPrefs.SetInt("Coins", coins);
        Debug.Log("Purchase: get 500 coins");
        UIinfo.Instatnce.UpdateBuyCoins();
    }
    private void Add1000coins()
    {
        int coins = PlayerPrefs.GetInt("Coins");
        coins += 1000;
        PlayerPrefs.SetInt("Coins", coins);
        Debug.Log("Purchase: get 1000 coins");
        UIinfo.Instatnce.UpdateBuyCoins();
    }
}
