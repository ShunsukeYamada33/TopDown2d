using UnityEngine;

public interface ISaveData
{
    void Save(string key, string value);
    string Load(string key);
}
