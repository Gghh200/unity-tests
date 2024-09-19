using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    [SerializeField] private Color basec, offset;
    [SerializeField] private SpriteRenderer Renderer;
    [SerializeField] private GameObject highlight;
    public bool IsIn;
    public string OldName;
    public void Init(bool IsOffSet){
        OldName = name;
        Renderer.color = IsOffSet ? offset : basec;
    }
    public void Update(){
        if(name == "NotCurrent"){
            name = OldName;
        }
        if(IsIn){
            if (Input.GetMouseButtonDown(0)){
                if(GameObject.Find("Current") != null){
                    GameObject.Find("Current").name = "NotCurrent";
                    gameObject.name = "Current";
                }else{
                    gameObject.name = "Current";
                }
            }
        }
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
