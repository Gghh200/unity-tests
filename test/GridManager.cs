using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Tile TilePrefab;
    [SerializeField] private Pieces Piece;
    [SerializeField] private Transform cam;

    void Start(){
        GridGen();
    }
    void GridGen(){
        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                var spawnedTile = Instantiate(TilePrefab, new Vector3(x,y,0), Quaternion.identity);
                spawnedTile.name = $"Tile {x}, {y}";
                var IsOffSet = (x % 2 == 0 && y % 2 != 0) || (y % 2 == 0 && x % 2 != 0);
                spawnedTile.Init(IsOffSet);
                if(y == 1){
                    var spawnedPiece = Instantiate(Piece, new Vector3(x,y,0), Quaternion.identity);
                    spawnedPiece.name = $"white pawn {x}";
                    spawnedPiece.Init(false);
                }else if(y == 6){
                    var spawnedPiece = Instantiate(Piece, new Vector3(x,y,0), Quaternion.identity);
                    spawnedPiece.name = $"black pawn {x}";
                    spawnedPiece.Init(true);
                }
            }
        }
        cam.transform.position = new Vector3((float) width/2 -0.5f, (float) height/2 -0.5f, -10);
    }
}
