using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// 저장하는 방법
// 1. 저장할 데이터가 존재
// 2. 데이터를 JSON으로 변환
// 3. JSON을 외부에 저장

// 불러오는 방법
// 1. 외부에 저장된 JSON을 가져옴
// 2. JSON을 데이터형태로 변환
// 3. 불러온 데이터를 사용

// 슬롯별로 다르게 저장

// 저장할 데이터
public class PlayerData
{
    // 이름, 사진
    public string name;
}

public class DataManager : MonoBehaviour
{
    // ---싱글톤으로 선언--- //
    // 싱글톤 : DataManager에 항상 접근하기 쉽도록 함
    static DataManager instance;

    PlayerData nowPlayer = new PlayerData();

    string path;
    string filename = "save"; // 슬롯마다 다른 파일name사용, 우린 한개

    private void Awake()
    {
        #region 싱글톤
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        #endregion

        path = Application.persistentDataPath + "/";
    }

    // Start is called before the first frame update
    void Start()
    {
        //nowPlayer.name = "가보자9";
        //print(nowPlayer.name);
    }

    public void SaveData()
    {
        string userData = JsonUtility.ToJson(nowPlayer);
        File.WriteAllText(path + filename, userData);
    }

    public void LoadData()
    {
        string userData = File.ReadAllText(path + filename);
        nowPlayer = JsonUtility.FromJson<PlayerData>(userData);
    }
}