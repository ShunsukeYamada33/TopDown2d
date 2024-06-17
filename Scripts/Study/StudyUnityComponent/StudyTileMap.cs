using UnityEngine;
using UnityEngine.Tilemaps;

public class StudyTileMap : MonoBehaviour
{
    private Tilemap _tileMap;
    public TileBase tile;

    private void Awake()
    {
        _tileMap = GetComponent<Tilemap>();
    }

    void Start()
    {
        Vector3Int checkPosition = new Vector3Int(0, 0, 0);
        // SetTile(Vector3Int 座標, TileBase タイル);
        _tileMap.SetTile(checkPosition, tile);

        // 座標上に TileBase が何か配置されているか確認
        bool hasTile = _tileMap.HasTile(checkPosition);

        if (hasTile)
        {
            // 座標上の TileBase を取得
            TileBase getTile = _tileMap.GetTile(checkPosition);
            // 座標上の Sprite を取得
            Sprite getSprite = _tileMap.GetSprite(checkPosition);
        }

        // _tileMapの特定のタイルの中央をワールド座標に変換
        Vector3 worldPosition = _tileMap.GetCellCenterWorld(checkPosition);
        // ある座標を_tileMapのタイルの座標に変換
        Vector3Int tilePosition = _tileMap.WorldToCell(worldPosition);


        GameObject timeObject = _tileMap.GetInstantiatedObject(tilePosition);
        Debug.Log(timeObject);

        // 全てのタイルをクリア（削除）
        //_tileMap.ClearAllTiles();
    }
}
