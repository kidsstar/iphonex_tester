using UnityEngine;
using UnityEngine.SceneManagement;

namespace iPhoneXTester {

    public class Controller : MonoBehaviour {

        private const string SCENE_NAME = "iPhoneX_Tester";

        private void Awake() {
            this.gameObject.name = SCENE_NAME;
            DontDestroyOnLoad(this.gameObject);
        }

        private void Start() {
            SceneManager.UnloadSceneAsync(SCENE_NAME);
        }

    }

}