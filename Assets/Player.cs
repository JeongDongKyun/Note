using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour // 아이템 생성
{
    [SerializeField] private SetItemInfo set_item_info = null;
    [SerializeField] private Inventory inventory = null;

    private void Start()
    {
        FirstSentence();
    }

    private void Update()
    {
        Shortcuts();
    }

    private void FirstSentence()
    {
        Debug.LogWarning("[단축키]");
        Debug.LogWarning("Q: 아이템 설명");
        Debug.LogWarning("W: 아이템 가격");

        Debug.Log("[상점 리스트]");

        for (int i = 0; i < set_item_info.item_list.Count; i++)
        {
            Debug.Log($"{i + 1}. {set_item_info.item_list[i].item_name}");
        }
    }

    private void Shortcuts()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < set_item_info.item_list.Count; i++)
            {
                if (i == 0)
                    Debug.Log("==============================");

                Debug.Log($"{i + 1}. {set_item_info.item_list[i].item_explanation}");
            }
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < set_item_info.item_list.Count; i++)
            {
                if (i == 0)
                    Debug.Log("==============================");

                Debug.Log($"{i + 1}. {set_item_info.item_list[i].item_price}");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddItem();
        }
    }

    private void AddItem()
    {
        var shop_item = set_item_info.item_list[Random.Range(0, set_item_info.item_list.Count)];

        inventory.inventory_list.Add(shop_item);
    }

    /* private void Update()
    {
        AddItem(iteminfo);
    }

    public void AddItem(ItemInfo item)
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            inventory.inventory_list.Add(item);

            Debug.Log("아이템 생성 완료!");
        }
    } */
}