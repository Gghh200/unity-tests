using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color basec, offset;
    [SerializeField] private SpriteRenderer Renderer;
    [SerializeField] private GameObject highlight;
    public bool IsIn;
    public void Init(bool IsOffSet){
        Renderer.color = IsOffSet ? offset : basec;
    }
    void OnMouseEnter(){
        IsIn = true;
        highlight.SetActive(true);
    }
    void OnMouseExit(){
        IsIn = false;
        highlight.SetActive(false);
    }
}
