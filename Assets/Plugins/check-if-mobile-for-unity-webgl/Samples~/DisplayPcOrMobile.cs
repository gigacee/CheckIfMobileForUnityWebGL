using UnityEngine;
using UnityEngine.UI;

namespace CheckIfMobileForUnityWebgl.Samples
{
    [RequireComponent(typeof(Text))]
    public class DisplayPcOrMobile : MonoBehaviour
    {
        bool isMobile;

#if !UNITY_EDITOR && UNITY_WEBGL
        [System.Runtime.InteropServices.DllImport("__Internal")]
        static extern bool IsMobile();
#endif

        void Start()
        {
#if !UNITY_EDITOR && UNITY_WEBGL
            isMobile = IsMobile();
#endif

            GetComponent<Text>().text = isMobile ? "Mobile" : "PC";
        }
    }
}
