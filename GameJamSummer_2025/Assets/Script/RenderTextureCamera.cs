using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderTextureCamera : MonoBehaviour
{

    public RawImage _displayImage;
    public Camera _rendercamera;

    //�J�����̏o�͂��Ǘ�
    //��������̂Ŕz��ŊǗ�
    public RenderTexture[] _renderTextures;

    void Start()
    {
        //�J�����̃����_�C���O���ʂ������_�[�e�N�X�`���ɏo��
        _rendercamera.targetTexture = _renderTextures[0];

        //�����_�[�e�N�X�`���[���C���[�W�̃e�N�X�`���[�Ƃ��Đݒ�
        _displayImage.texture = _renderTextures[0];
    }

    void Update()
    {
        
    }
}
