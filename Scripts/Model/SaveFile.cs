using System.IO;
using UnityEngine;

public class SaveFile : ISaveData
{
    public string Load(string key)
    {
        // �t�@�C������f�[�^�����[�h���鏈��
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
        // �t�@�C���Ƀf�[�^��ۑ����鏈��
        var path = GetPath(key);
        File.WriteAllText(path, value);
    }

    private string GetPath(string key)
    {
        // Application.persistentDataPath�@�o���Ă�������
        // ��ڂ̈����̓t�@�C����
        return Path.Combine(Application.persistentDataPath, $"{key}.json");
    }
}
