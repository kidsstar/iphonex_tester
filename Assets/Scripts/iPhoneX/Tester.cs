using UnityEngine.SceneManagement;

namespace iPhoneX {

    public static class Tester {

        /// <summary>
        /// インストールする
        /// </summary>
        public static void Install() {
#if UNITY_EDITOR
            SceneManager.LoadSceneAsync("iPhoneX_Tester", LoadSceneMode.Additive);
#endif
        }

        /// <summary>
        /// アンインストールする
        /// </summary>
        public static void Uninstall() {
#if UNITY_EDITOR
            SceneManager.UnloadSceneAsync("iPhoneX_Tester");
#endif
        }

    }

}