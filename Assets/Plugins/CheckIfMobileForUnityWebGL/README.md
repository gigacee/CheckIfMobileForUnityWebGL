# Check if Mobile for Unity WebGL

The plugin to check if your Unity WebGL game is running on a PC or mobile device.

| on PC                                                                                                           | on Mobile                                                                                                       |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| <img src="https://user-images.githubusercontent.com/5264444/95644234-3aceeb00-0af0-11eb-8b93-754c0b3f1062.png"> | <img src="https://user-images.githubusercontent.com/5264444/95644297-a9ac4400-0af0-11eb-9c9d-7440e783666d.png"> |

## 日本語による説明 / Explanation in Japanese

[Unity WebGL の実行環境が PC かモバイル端末かを判別するスクリプトを公開しました](https://blog.gigacreation.jp/entry/2020/10/10/124015)

## Usage

This script uses [.jslib plugin](https://docs.unity3d.com/Manual/webgl-interactingwithbrowserscripting.html). You can check if your Unity WebGL game is running on a PC or mobile device by calling `IsMobile()` in `CheckIfMobileForUnityWebgl.jslib` as follows:

```cs
    bool isMobile;

#if !UNITY_EDITOR && UNITY_WEBGL
    [System.Runtime.InteropServices.DllImport("__Internal")]
    static extern bool IsMobile();
#endif

    void CheckIfMobile()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
        isMobile = IsMobile();
#endif
    }
```

## Installation

### Package Manager

`https://github.com/Gigacee/check-if-mobile-for-unity-webgl.git?path=Assets/Plugins/check-if-mobile-for-unity-webgl`

### Manual

Copy `Assets/Plugins/check-if-mobile-for-unity-webgl/CheckIfMobileForUnityWebgl.jslib` to your project.

:warning: Be sure to put it in `Assets/Plugins/` .
