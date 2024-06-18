using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button creditButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject other;

    /*
     * Runs play, credits, or exit based on which is clicked
     */
    private void Awake() {
        playButton.onClick.AddListener(() => {
            Debug.Log("Play");
            Loader.Load(Loader.Scene.GameScene);
        });
        creditButton.onClick.AddListener(() => {
            Swap();
        });
        exitButton.onClick.AddListener(() => {
            Debug.Log("Exit");
            Application.Quit();
        });
    }

    /*
     * Swaps Main Screen frame with Credits frame to display credits
     */
    private void Swap() {
        Vector3 temp = this.transform.position;
        this.transform.position = other.transform.position;
        other.transform.position = temp;
    }
}
