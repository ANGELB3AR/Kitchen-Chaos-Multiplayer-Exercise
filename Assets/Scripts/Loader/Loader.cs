using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;

public static class Loader {


    public enum Scene {
        MainMenuScene,
        GameScene,
        LoadingScene
    }


    private static Scene targetScene;



    public static void Load(Scene targetScene) {
        Loader.targetScene = targetScene;

        //SceneManager.LoadScene(Scene.LoadingScene.ToString());
        NetworkManager.singleton.ServerChangeScene(targetScene.ToString());
    }

    public static void LoaderCallback() {
        //SceneManager.LoadScene(targetScene.ToString());
        NetworkManager.singleton.ServerChangeScene(targetScene.ToString());
    }

}