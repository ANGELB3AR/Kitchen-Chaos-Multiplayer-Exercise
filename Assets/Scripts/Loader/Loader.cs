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

        NetworkManager.singleton.ServerChangeScene(targetScene.ToString());
    }

    public static void LoaderCallback() {
        NetworkManager.singleton.ServerChangeScene(targetScene.ToString());
    }

}