using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderTextureCamera : MonoBehaviour
{

    public RawImage _displayImage;
    public Camera _rendercamera;

    //カメラの出力を管理
    //複数あるので配列で管理
    public RenderTexture[] _renderTextures;

    void Start()
    {
        //カメラのレンダイング結果をレンダーテクスチャに出力
        _rendercamera.targetTexture = _renderTextures[0];

        //レンダーテクスチャーをイメージのテクスチャーとして設定
        _displayImage.texture = _renderTextures[0];
    }

    void Update()
    {
        
    }
}
