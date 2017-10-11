using UnityEngine;
using UnityEngine.SceneManagement;

namespace iPhoneX {

    public static class TesterInstaller {

        /// <summary>
        /// インストールする
        /// </summary>
        public static AsyncOperation Install() {
#if UNITY_EDITOR
            return SceneManager.LoadSceneAsync("iPhoneX_Tester", LoadSceneMode.Additive);
#else
            return null;
#endif
        }

        /// <summary>
        /// アンインストールする
        /// </summary>
        public static AsyncOperation Uninstall() {
#if UNITY_EDITOR
            return SceneManager.UnloadSceneAsync("iPhoneX_Tester");
#else
            return null;
#endif
        }

    }

}