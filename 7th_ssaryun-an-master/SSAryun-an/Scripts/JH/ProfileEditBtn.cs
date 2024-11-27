using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

using System;

public class ProfileEditBtn : MonoBehaviour
{
    public RawImage img;

    public TextMeshProUGUI userNamePlaceholder;
    public TMP_InputField newPlayerName;

    public void LoadProfileInfo()
    {
        newPlayerName.text = "";
        Texture2D tex = new Texture2D(0, 0);
       // tex.LoadImage(File.ReadAllBytes(DataManager.instance.nowPlayer.imgPath));
        Texture2D rotex = rotateTexture(tex, true);

        //img.texture = tex;
        img.texture = rotex;
        img.SetNativeSize();
        ImageSizeSetting(img, 150, 200);
       // userNamePlaceholder.text = DataManager.instance.nowPlayer.name;
    }

    void ImageSizeSetting(RawImage img, float x, float y)
    {
        var imgX = img.rectTransform.sizeDelta.x;
        var imgY = img.rectTransform.sizeDelta.y;

        if (x / y > imgX / imgY)
        { // 이미지의 세로길이가 더 길다
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, y);
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, imgX * (y / imgY));
        }
        else
        { // 이미지의 가로길이가 더 길다
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, x);
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, imgY * (x / imgX));
        }
    }

    Texture2D rotateTexture(Texture2D originalTexture, bool clockwise)
    { // exif 변환 과정에서 회전된 이미지가 출력되는 것을 보정
        Color32[] original = originalTexture.GetPixels32();
        Color32[] rotated = new Color32[original.Length];
        int w = originalTexture.width;
        int h = originalTexture.height;

        int iRotated, iOriginal;

        for (int j = 0; j < h; ++j)
        {
            for (int i = 0; i < w; ++i)
            {
                iRotated = (i + 1) * h - j - 1;
                iOriginal = clockwise ? original.Length - 1 - (j * w + i) : j * w + i;
                rotated[iRotated] = original[iOriginal];
            }
        }

        Texture2D rotatedTexture = new Texture2D(h, w);
        rotatedTexture.SetPixels32(rotated);
        rotatedTexture.Apply();
        return rotatedTexture;
    }
}
