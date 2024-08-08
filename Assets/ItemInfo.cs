using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // �ν����� ���� ����
public class ItemInfo // ������ �Ӽ� ����
{
    public string item_name = null; // ������ �̸�
    public Sprite item_image = null; // ������ �̹���
    public string item_explanation = null; // ������ ����
    public int item_price = 0;  // ������ ����
}