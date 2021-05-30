#define ENABLE_STARTUPSCENE

using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.IO;

// ensure class initializer is called whenever scripts recompile
[InitializeOnLoad]
public static class StartupScene
{
    // The path to the scene you want to launch from.
    static readonly string  splashScene = Path.Combine("Assets", "Scenes", "Splash.unity");
    // The build index of the above scene.
    static readonly int     buildIndex  = 0;
#if ENABLE_STARTUPSCENE
    static StartupScene()
    {
        EditorSceneManager.sceneOpened += SceneChanged;
        if (EditorSceneManager.GetActiveScene().buildIndex != buildIndex)
        {
            SceneAsset splash = AssetDatabase.LoadAssetAtPath<SceneAsset>(splashScene);
            EditorSceneManager.playModeStartScene = splash;
        }
    }

    private static void SceneChanged(Scene scene, OpenSceneMode openSceneMode)
    {
        if (EditorSceneManager.GetActiveScene().buildIndex != buildIndex)
        {
            SceneAsset splash = AssetDatabase.LoadAssetAtPath<SceneAsset>(splashScene);
            EditorSceneManager.playModeStartScene = splash;
        }
    }
#else
    static StartupScene()
    {
        EditorSceneManager.playModeStartScene = null;
    }
#endif
}
