using iPhoneXTester;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace iPhoneTester.Editor {

    public static class Launcher {

        [MenuItem("Assets/Install iPhone X Tester")]
        public static void Install() {
            if (Application.isPlaying) {
                Debug.LogError("Scene could not install at runtime.");
                return;
            }
            if (Object.FindObjectOfType<Controller>() != default(Controller)) {
                Debug.LogWarning("iPhoneX Tester already installed.");
                return;
            }
            string[] assets = AssetDatabase.FindAssets("t:Scene iPhoneX_Tester");
            if (assets.Length > 0) {
                EditorSceneManager.OpenScene(AssetDatabase.GUIDToAssetPath(assets[0]), OpenSceneMode.Additive);
            }
        }

    }

}