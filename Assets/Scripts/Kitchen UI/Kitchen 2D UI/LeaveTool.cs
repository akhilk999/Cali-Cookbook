using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveTool : MonoBehaviour
{
    [SerializeField] private ActivityManager activityManager;

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject other;
    [SerializeField] private Button toolEscape;
    [SerializeField] private KitchenCamera kCamera;
    // Start is called before the first frame update
    private void Awake()
    {
        toolEscape.onClick.AddListener(() => {
            activityManager.SetCamDefault();
            activityManager.Swap(main, other);
            activityManager.playingGame = false;
        });
    }

 
}
