using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class profilePopup : MonoBehaviour
{
    public RawImage img;

    private void Start()
    {
        Debug.Log(Application.persistentDataPath);

        // 앱종료해도 사진 유지
        //if (File.Exists(Application.persistentDataPath + "/Image")) // 경로에 무언가 있다면 = 한번이라도 저장했다는 뜻
        //{
        //    File.ReadAllBytes(Application.persistentDataPath + "/Image" + "/userProfile.png");
        //}
    }

    public void OnClickImageLoad()
    {
        NativeGallery.GetImageFromGallery((file)=>
        {
            FileInfo selected = new FileInfo(file);

            // 불러오는 파일 용량 제한
            if (selected.Length > 50000000) return;// 50MB 제한

            // 불러오기
            if (!string.IsNullOrEmpty(file)) // 파일이 존재하면
                // 불러와라
                StartCoroutine(LoadImage(file));
        });
    }

    IEnumerator LoadImage(string path)
    {
        yield return null;

        byte[] fileData = File.ReadAllBytes(path);
        string filename = Path.GetFileName(path).Split('.')[0];
        //string name = "userProfile";
        string savePath = Application.persistentDataPath + "/Image";

        if (!Directory.Exists(savePath)) {
            Directory.CreateDirectory(savePath);
        }

        //DataManager.instance.nowPlayer.imgPath = savePath + filename + ".png";
        File.WriteAllBytes(savePath + filename + ".png", fileData);
        //File.WriteAllBytes(savePath + name + ".png", fileData);

        var temp = File.ReadAllBytes(savePath + filename + ".png");
        //var temp = File.ReadAllBytes(savePath + name + ".png");

        Texture2D tex = new Texture2D(0, 0);
        tex.LoadImage(temp);
        Texture2D rotex = rotateTexture(tex, true);

        //img.texture = tex;
        img.texture = rotex;
        img.SetNativeSize();
        ImageSizeSetting(img, 192, 256);

    }

    void ImageSizeSetting(RawImage img, float x, float y)
    {
        var imgX = img.rectTransform.sizeDelta.x;
        var imgY = img.rectTransform.sizeDelta.y;

        if (x / y > imgX / imgY) { // 이미지의 세로길이가 더 길다
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, y);
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, imgX * (y / imgY));
        }
        else { // 이미지의 가로길이가 더 길다
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
