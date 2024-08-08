using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // 인스펙터 변수 노출
public class ItemInfo // 아이템 속성 관리
{
    public string item_name = null; // 아이템 이름
    public Sprite item_image = null; // 아이템 이미지
    public string item_explanation = null; // 아이템 설명
    public int item_price = 0;  // 아이템 가격
}