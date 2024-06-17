using System.Collections.Generic;
using UnityEngine;

public class GameClearData
{
    public readonly bool GameClear;
    public readonly List<float> Times;

    public GameClearData(bool gameClear, List<float> times)
    {
        GameClear = gameClear;
        Times = times;
    }
}
