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
        // SetTile(Vector3Int ���W, TileBase �^�C��);
        _tileMap.SetTile(checkPosition, tile);

        // ���W��� TileBase �������z�u����Ă��邩�m�F
        bool hasTile = _tileMap.HasTile(checkPosition);

        if (hasTile)
        {
            // ���W��� TileBase ���擾
            TileBase getTile = _tileMap.GetTile(checkPosition);
            // ���W��� Sprite ���擾
            Sprite getSprite = _tileMap.GetSprite(checkPosition);
        }

        // _tileMap�̓���̃^�C���̒��������[���h���W�ɕϊ�
        Vector3 worldPosition = _tileMap.GetCellCenterWorld(checkPosition);
        // ������W��_tileMap�̃^�C���̍��W�ɕϊ�
        Vector3Int tilePosition = _tileMap.WorldToCell(worldPosition);


        GameObject timeObject = _tileMap.GetInstantiatedObject(tilePosition);
        Debug.Log(timeObject);

        // �S�Ẵ^�C�����N���A�i�폜�j
        //_tileMap.ClearAllTiles();
    }
}
