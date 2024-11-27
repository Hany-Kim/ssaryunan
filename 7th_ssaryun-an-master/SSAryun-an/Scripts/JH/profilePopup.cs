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

        // �������ص� ���� ����
        //if (File.Exists(Application.persistentDataPath + "/Image")) // ��ο� ���� �ִٸ� = �ѹ��̶� �����ߴٴ� ��
        //{
        //    File.ReadAllBytes(Application.persistentDataPath + "/Image" + "/userProfile.png");
        //}
    }

    public void OnClickImageLoad()
    {
        NativeGallery.GetImageFromGallery((file)=>
        {
            FileInfo selected = new FileInfo(file);

            // �ҷ����� ���� �뷮 ����
            if (selected.Length > 50000000) return;// 50MB ����

            // �ҷ�����
            if (!string.IsNullOrEmpty(file)) // ������ �����ϸ�
                // �ҷ��Ͷ�
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

        if (x / y > imgX / imgY) { // �̹����� ���α��̰� �� ���
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, y);
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, imgX * (y / imgY));
        }
        else { // �̹����� ���α��̰� �� ���
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, x);
            img.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, imgY * (x / imgX));
        }
    }

    Texture2D rotateTexture(Texture2D originalTexture, bool clockwise)
    { // exif ��ȯ �������� ȸ���� �̹����� ��µǴ� ���� ����
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
