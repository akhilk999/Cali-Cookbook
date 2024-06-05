using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [SerializeField] private Button XButton;
    [SerializeField] private GameObject other;

    private void Awake() {
        XButton.onClick.AddListener(() => {
            Swap();
        });
    }
    private void Swap() {
        Vector3 temp = this.transform.position;
        this.transform.position = other.transform.position;
        other.transform.position = temp;
    }
}
