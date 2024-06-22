using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCam : MonoBehaviour
{
    [SerializeField] private ActivityManager activityManager;
    [SerializeField] private Button changeCam;

    [SerializeField] private CinemachineVirtualCamera countercam;
    [SerializeField] private CinemachineVirtualCamera kitchencam;

    private bool onCounter = true; 
    // Start is called before the first frame update
    private void Awake()
    {
        changeCam.onClick.AddListener(() => {
            if (onCounter)
            {
                countercam.m_Priority = 0;
                kitchencam.m_Priority = 1;
                onCounter = false;
            }
            else if (!onCounter)
            {
                countercam.m_Priority = 1;
                kitchencam.m_Priority = 0;
                onCounter = true;
            }
        });
    }

   
}
