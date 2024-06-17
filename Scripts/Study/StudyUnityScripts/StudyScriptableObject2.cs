using UnityEngine;

public class StudyScriptableObject2 : MonoBehaviour
{
    public StudyScriptableObject status;


    private string _enemyName;
    private int _health;
    private int _attack;

    private void Start()
    {
        _enemyName = status.name;
        _health = status.health;
        _attack = status.attack;
    }
}
