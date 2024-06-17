using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/Study", fileName = "名前")]
[Serializable]
public class StudyScriptableObject : ScriptableObject
{
    // ScriptableObject スクリプタブルオブジェクト
    // MonoBehavior ではない Unity で大切なクラス

    // ゲームオブジェクトという形ではなく Unity 内で利用できる。
    
    // 敵のパラメータ
    public string enemyName;
    public int health;
    public int attack;

    // シーン間のデータ共有
    // コンフィグ画面で設定して
    // 戦闘画面でそれを利用する

    // 戦闘画面ではゲームオブジェクトのステータスとして
    // 図鑑画面ではステータスを表示用


    // [CreateAssetMenu(menuName = "Scriptable/Study", fileName = "名前")]
    // menuName  Unity Editor でクリエイトする際の名前の宣言
    // fileName  クリエイトした際の初期の名前

    // Serializable  Unity Editor で利用できるようにするためのおまじない
}
