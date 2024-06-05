using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTool : MonoBehaviour
{
    [SerializeField] private ActivityManager activityManager;
    [SerializeField] private HoverOutline hoverOutline;
    [SerializeField] private KitchenCamera kCamera;

    [SerializeField] private GameObject changeFollow;

    [SerializeField] private float orthoSize;
    [SerializeField] private float _xdistance;
    [SerializeField] private float _ydistance;
    [SerializeField] private float _zdistance;
    // Is called when mouse is over collidable object
    IEnumerator OnMouseOver()
    {
      
        if (Input.GetMouseButton(0))
        {
            if (!activityManager.playingGame)
            {
                activityManager.playingGame = true;
                yield return new WaitForSeconds(0.25f);
                hoverOutline.ColorDefault();
                kCamera.ChangeCameraFOV(orthoSize);
                kCamera.ChangeCameraDistance(_xdistance, _ydistance, _zdistance);
                kCamera.ChangeObject(changeFollow);
                activityManager.Swap();
            }
        }
       
    }

   

}
