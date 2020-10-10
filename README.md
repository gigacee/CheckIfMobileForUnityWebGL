# Check if Mobile for Unity WebGL

The plugin to check if your Unity WebGL game is running on a PC or mobile device.

## Sample

### on PC

<img src="https://user-images.githubusercontent.com/5264444/95643110-df006400-0ae7-11eb-97a1-5c330a532dff.png" width="50%">

### on Mobile

<img src="https://user-images.githubusercontent.com/5264444/95643132-02c3aa00-0ae8-11eb-9207-3abcd30a07a9.png" width="50%">

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
