using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ActivityManager : MonoBehaviour
{

    [SerializeField] private GameObject defaultFollow;
    [SerializeField] private float _defaultx;
    [SerializeField] private float _defaulty;
    [SerializeField] private float _defaultz;
    [SerializeField] private float _defaultfov;
    [SerializeField] public CinemachineVirtualCamera m_Camera;

    [SerializeField] private GameObject blank;
    [SerializeField] private GameObject change;

    private Transform camDefault;
    public bool playingGame = false;
    // Set Camera to Default Position

    public void SetCamDefault()
    {
        camDefault = defaultFollow.transform;
        m_Camera.LookAt = camDefault;
        m_Camera.Follow = camDefault;
        m_Camera.m_Lens.OrthographicSize = _defaultfov;
        m_Camera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset = new Vector3(_defaultx, _defaulty, _defaultz);
    }

    public void RevertUI(GameObject main, GameObject other)
    {
        Vector3 temp = main.transform.position;
        main.transform.position = other.transform.position;
        other.transform.position = temp;
    }

    public void Swap()
    {
        Vector3 temp = blank.transform.position;
        blank.transform.position = change.transform.position;
        change.transform.position = temp;
    }
    }
