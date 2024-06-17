using System.IO;
using UnityEngine;

public class SaveFile : ISaveData
{
    public string Load(string key)
    {
        // ファイルからデータをロードする処理
        var path = GetPath(key);
        if (File.Exists(path))
        {
            return File.ReadAllText(path);
        }
        else
        {
            return "";
        }
    }

    public void Save(string key, string value)
    {
        // ファイルにデータを保存する処理
        var path = GetPath(key);
        File.WriteAllText(path, value);
    }

    private string GetPath(string key)
    {
        // Application.persistentDataPath　覚えてください
        // 二つ目の引数はファイル名
        return Path.Combine(Application.persistentDataPath, $"{key}.json");
    }
}
