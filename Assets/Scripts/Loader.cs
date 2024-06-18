using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader {

    public enum Scene {
        MainMenuScene,
        LoadingScene,
        GameScene
    }

    private static Scene targetScene;

    /*
     * Loads the Loading Screen
     */
    public static void Load(Scene targetScene) {
        Loader.targetScene = targetScene;

        SceneManager.LoadSceneAsync(Scene.LoadingScene.ToString());
    }
    /*
     * Loads the Target Scene
     */
    public static void LoaderCallback() {
        SceneManager.LoadSceneAsync(targetScene.ToString());
    }
}
