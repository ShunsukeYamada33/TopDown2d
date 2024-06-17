using ObservableCollections;
using R3;
using R3.Triggers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    private Transform _transform;
    public Tilemap backGroundTileMap;
    public Tilemap wallTileMap;
    public GameObject destroyableWallPrefab;
    public EnemyObject enemyPrefab;
    public ObservableList<EnemyObject> enemies = new();
    public Transform playerTransform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        enemies.ObserveCountChanged().Subscribe(count =>
        {
            if (count > 0)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }
        });
    }

    public void GenerateDestroyableWalls(Vector3 playerPosition)
    {
        // backGround の範囲を取得
        BoundsInt bounds = backGroundTileMap.cellBounds;

        // 破壊可能な壁を置ける場所のリスト
        var possiblePositions = new List<Vector3Int>();

        // プレイヤーの位置とその周辺のタイルを除外するリストを作成
        var playerCellPosition = backGroundTileMap.WorldToCell(playerPosition);
        var playerZone = new List<Vector3Int>();
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                playerZone.Add(playerCellPosition + new Vector3Int(x, y, 0));
            }
        }

        // backGroundにタイルがあって、かつ wallにタイルがない場所を検索
        foreach (var position in bounds.allPositionsWithin)
        {
            // backGroundにタイルがあって、かつ wallにタイルがないなら true
            // playerZoneも除外
            if (backGroundTileMap.HasTile(position) && !wallTileMap.HasTile(position) 
                && !playerZone.Contains(position))
            {
                possiblePositions.Add(position);
            }
        }

        // ランダムに 1 / 2 の位置を選択して壁を生成
        var count = possiblePositions.Count / 2;
        for (int i = 0; i < count; i++)
        {
            var random = Random.Range(0, possiblePositions.Count);
            // 実際に破壊可能な壁を設置する位置
            var selectedPosition = possiblePositions[random];
            // 実際に破壊可能な壁を設置する位置のTransform 上の正確な位置を取得
            var worldPosition = backGroundTileMap.GetCellCenterWorld(selectedPosition);

            // 破壊可能な壁を生成
            Instantiate(destroyableWallPrefab, worldPosition, Quaternion.identity, _transform);
            possiblePositions.RemoveAt(random);
        }

        CreateEnemies(possiblePositions);
    }

    private void CreateEnemies(List<Vector3Int> possiblePositions)
    {
        // ランダムに 1 / 4 の位置を選択して敵を生成
        var count = possiblePositions.Count / 4;
        for (int i = 0; i < count; i++)
        {
            var random = Random.Range(0, possiblePositions.Count);
            // 実際に敵を設置する位置
            var selectedPosition = possiblePositions[random];
            // 実際に敵を設置する位置のTransform 上の正確な位置を取得
            var worldPosition = backGroundTileMap.GetCellCenterWorld(selectedPosition);

            // 敵を生成
            var enemy = Instantiate(enemyPrefab, worldPosition, Quaternion.identity, _transform);
            enemy.playerTransform = playerTransform;
            enemies.Add(enemy);
            enemy.OnDestroyAsObservable().Subscribe(_ => enemies.Remove(enemy)).AddTo(gameObject);
            possiblePositions.RemoveAt(random);
        }
    }
}
