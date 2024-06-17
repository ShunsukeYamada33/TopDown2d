using UnityEngine;

public class SavePlayerPrefs : ISaveData
{
    public string Load(string key)
    {
        // PlayerPrefs����f�[�^�����[�h���鏈��
        return PlayerPrefs.GetString(key);
    }

    public void Save(string key, string value)
    {
        // PlayerPrefs�Ƀf�[�^��ۑ����鏈��
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
    }
}
