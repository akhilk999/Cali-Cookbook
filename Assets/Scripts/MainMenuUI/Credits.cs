using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [SerializeField] private Button XButton;
    [SerializeField] private GameObject other;

    /**
     * Goes back to main screen when X is clicked by swapping them back
     */
    private void Awake() {
        XButton.onClick.AddListener(() => {
            Swap();
        });
    }

    /**
     * Swaps Credits frame with Main Screen frame to display main screen
     */
    private void Swap() {
        Vector3 temp = this.transform.position;
        this.transform.position = other.transform.position;
        other.transform.position = temp;
    }
}
