using System.IO;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    static GameObject container;

    // ---�̱������� ����--- //
    static CharManager instance;
    public static CharManager Instance
    {
        get
        {
            if (!instance)
            {
                container = new GameObject();
                container.name = "CharManager";
                instance = container.AddComponent(typeof(CharManager)) as CharManager;
                DontDestroyOnLoad(container);
            }
            return instance;
        }
    }

    // --- ���� ������ �����̸� ���� ("���ϴ� �̸�(����).json") --- //
    string CharDataFileName = "CharManager.json";

    // --- ����� Ŭ���� ���� --- //
    public CharData data = new CharData();


    // �ҷ�����
    public void LoadCharData()
    {
        string filePath = Application.persistentDataPath + "/" + CharDataFileName;

        // ����� ������ �ִٸ�
        if (File.Exists(filePath))
        {
            // ����� ���� �о���� Json�� Ŭ���� �������� ��ȯ�ؼ� �Ҵ�
            string FromJsonData = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<CharData>(FromJsonData);
        }
    }


    // �����ϱ�
    public void SaveGameData()
    {
        // Ŭ������ Json �������� ��ȯ (true : ������ ���� �ۼ�)
        string ToJsonData = JsonUtility.ToJson(data, true);
        string filePath = Application.persistentDataPath + "/" + CharDataFileName;

        // �̹� ����� ������ �ִٸ� �����, ���ٸ� ���� ���� ����
        File.WriteAllText(filePath, ToJsonData);

    }
}