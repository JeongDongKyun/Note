using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetItemInfo : MonoBehaviour // 아이템 정보 관리
{
    [Header("상점 아이템")] // 인스펙터 텍스트 노출
    public List<ItemInfo> item_list = new List<ItemInfo>(); // 인스펙터에서 아이템 정보 관리
}