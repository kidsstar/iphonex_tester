using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace iPhoneXTester
{
    [ExecuteInEditMode]
    public class Controller : MonoBehaviour
    {
        private const string SceneName = "iPhoneX_Tester";

        [SerializeField] private Image landscape;
        [SerializeField] private Image portrait;
        private Image Landscape => landscape;
        private Image Portrait => portrait;

        private void Awake()
        {
            gameObject.name = SceneName;
            if (Application.isPlaying)
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        private void Start()
        {
            if (!Application.isPlaying)
            {
                return;
            }
            ActivateImages();
        }

#if UNITY_EDITOR

        private Vector2Int PreviousScreenResolution { get; set; }

        private void LateUpdate()
        {
            if (PreviousScreenResolution.x == Screen.width && PreviousScreenResolution.y == Screen.height)
            {
                return;
            }

            PreviousScreenResolution = new Vector2Int(Screen.width, Screen.height);
            ActivateImages();
        }

#endif

        private void ActivateImages()
        {
            if (Application.isEditor)
            {
#if UNITY_EDITOR
                if (Portrait.gameObject.activeSelf != IsPortrait())
                {
                    EditorUtility.SetObjectEnabled(Portrait.gameObject, IsPortrait());
                }
                if (Landscape.gameObject.activeSelf == IsPortrait())
                {
                    EditorUtility.SetObjectEnabled(Landscape.gameObject, !IsPortrait());
                }
#endif
            }
            else
            {
                if (Portrait.gameObject.activeSelf != IsPortrait())
                {
                    Portrait.gameObject.SetActive(IsPortrait());
                }
                if (Landscape.gameObject.activeSelf == IsPortrait())
                {
                    Landscape.gameObject.SetActive(!IsPortrait());
                }
            }
        }

        private static bool IsPortrait()
        {
            return Screen.width < Screen.height;
        }
    }
}