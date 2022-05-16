using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class RewardedAdsButton : MonoBehaviour
{
    #if UNITY_IOS
        string gameId = "4659070";
    #else
        string gameId = "4659071";
    #endif

    void Start()
    {
        Advertisement.Initialize(gameId);
    }

    public void PlayRewardedAd()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Show("Rewarded_Android");
            points.instance.AddPoint();
        }
        else
        {
            Debug.Log("Rewarded Ad Not Ready");
        }   
    }
}