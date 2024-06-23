using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderBar : MonoBehaviour
{
    [SerializeField] private Image barImage;
    [SerializeField] private Customer customer;

    private void Start() {
        //Customer.onProgressChanged += Customer_OnProgressChanged;
        barImage.fillAmount = 0f;
        Hide();
    }

    private void Customer_OnProgressChanged(object sender, Customer.OnProgressChangedEventArgs e) {
        barImage.fillAmount = e.progressNormalized;
        if(e.progressNormalized == 0f || e.progressNormalized == 1f) {
            Hide();
        }
        else {
            Show();
        }
    }

    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }
}
