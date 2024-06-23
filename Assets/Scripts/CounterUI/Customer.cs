using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public EventHandler<OnProgressChangedEventArgs> onProgressChanged;
    public class OnProgressChangedEventArgs : EventArgs {
        public float progressNormalized;
    }

    public int orderProgress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void onMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed Customer");
            orderProgress = 0;
            onProgressChanged?.Invoke(this, new OnProgressChangedEventArgs {
                progressNormalized = (float) orderProgress / 10
            });
        }
    }
}
