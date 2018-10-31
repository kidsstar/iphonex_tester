using iPhoneXTester;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace iPhoneTester.Editor
{
    public static class Launcher
    {
        [MenuItem("Assets/Install iPhone X Tester")]
        public static void Install()
        {

            if (Object.FindObjectOfType<Controller>() != default(Controller))
            {
                Debug.LogWarning("iPhoneX Tester already installed.");
                return;
            }

            if (Application.isPlaying)
            {
                LoadPrefab();
            }
            else
            {
                LoadScene();
            }
        }

        private static void LoadPrefab()
        {
            var prefabAssets = AssetDatabase.FindAssets("t:Prefab iPhoneX_Tester");
            if (prefabAssets.Length > 0)
            {
                Object.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(prefabAssets[0])));
            }
        }

        private static void LoadScene()
        {
            var sceneAssets = AssetDatabase.FindAssets("t:Scene iPhoneX_Tester");
            if (sceneAssets.Length > 0)
            {
                EditorSceneManager.OpenScene(AssetDatabase.GUIDToAssetPath(sceneAssets[0]), OpenSceneMode.Additive);
            }
        }
    }
}