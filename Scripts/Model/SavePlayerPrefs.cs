using UnityEngine;

public class SavePlayerPrefs : ISaveData
{
    public string Load(string key)
    {
        // PlayerPrefsからデータをロードする処理
        return PlayerPrefs.GetString(key);
    }

    public void Save(string key, string value)
    {
        // PlayerPrefsにデータを保存する処理
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
    }
}
