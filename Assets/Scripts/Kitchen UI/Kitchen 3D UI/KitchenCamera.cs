using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class KitchenCamera : MonoBehaviour
{     
    

    [SerializeField] private ActivityManager activityManager;

    private Transform camTarget;
    // Start is called before the first frame update

    public void ChangeCameraFOV(float orthoSize)
    {
        activityManager.m_Camera.m_Lens.OrthographicSize = orthoSize;
    }

    public void ChangeCameraDistance(float xdis, float ydis, float zdis)
    {
        activityManager.m_Camera.GetCinemachineComponent<CinemachineTransposer>().m_FollowOffset = new Vector3(xdis, ydis, zdis);
    }

    public void ChangeObject(GameObject obj)
    {
        camTarget = obj.transform;
        activityManager.m_Camera.LookAt = camTarget;
        activityManager.m_Camera.Follow = camTarget;
    }

   
}
