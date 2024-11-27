using System;

[Serializable] // 직렬화

public class CharData
{
    // 각 챕터의 잠금여부를 저장할 배열
    public bool[] isUnlock = new bool[3];
}