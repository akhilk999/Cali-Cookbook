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

    private void Swap() {
        Vector3 temp = this.transform.position;
        this.transform.position = other.transform.position;
        other.transform.position = temp;
    }
}
