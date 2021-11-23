using UnityEngine;
using UnityEngine.UI;
#if !UNITY_EDITOR && UNITY_WEBGL
using System.Runtime.InteropServices;
#endif

namespace CheckIfMobileForUnityWebGL.Samples
{
    [RequireComponent(typeof(Text))]
    public class DisplayPCOrMobile : MonoBehaviour
    {
        private void Start()
        {
            var isMobile = false;

#if !UNITY_EDITOR && UNITY_WEBGL
            isMobile = IsMobile();
#endif

            GetComponent<Text>().text = isMobile ? "Mobile" : "PC";
        }

#if !UNITY_EDITOR && UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern bool IsMobile();
#endif
    }
}
