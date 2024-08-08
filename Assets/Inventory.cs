using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour // 인벤토리 관리
{
    [Header("보유한 아이템")] // 인스펙터 텍스트 노출
    public List<ItemInfo> inventory_list = new List<ItemInfo>(); // ?
}