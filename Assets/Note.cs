using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private void Start()
    {
        /* #region List

        List<string> string_list = new List<string>(); // ����Ʈ ����

        string_list.Add("�ȳ��ϼ���"); // ����Ʈ �ȿ� �� �ֱ�
        string_list.Add("�ݰ����ϴ�"); // ����Ʈ �ȿ� �� �ֱ�
        string_list.Remove("�ȳ��ϼ���"); // ����Ʈ �ȿ� ���� �Է� ������� �� ����
        string_list.RemoveAt(0); // ����Ʈ �ȿ� �ε��� �Է� ������� �� ����
        string_list.Add("�����ٶ󸶹ٻ�"); // ����Ʈ �ȿ� �� �ֱ�
        string_list.Insert(0, "�̰� ���� ���� ��"); // ��� °�� ������ �� �ֱ�
        string_list.Clear(); // ����Ʈ �ȿ� ���� ���� ����
        // Debug.Log(string_list.IndexOf("�̰� ���� ���� ��")); // �� ���� �ε����� ã��
        // Debug.Log(string_list.Contains("�̰� ���� ���� ��")); // ����Ʈ �ȿ� Ư�� ���� �ִٸ� True or Flase

        for (int i = 0; i < string_list.Count; i++) // ����Ʈ ũ�⸸ŭ ����
        {
            Debug.Log(string_list[i]); // �α� ���
        }

        Debug.Log($"List�� ũ��: {string_list.Count}"); // �α� ���

        #endregion

        #region Dictionary

        Dictionary<int, string> test_dict = new Dictionary<int, string>(); // ��ųʸ� ����

        test_dict.Add(1, "��"); // ��ųʸ� �ȿ� �� �ֱ�
        test_dict.Add(2, "��"); // ��ųʸ� �ȿ� �� �ֱ�
        test_dict.Add(3, "��"); // ��ųʸ� �ȿ� �� �ֱ�
        // Debug.Log(test_dict[1]); // 1�̶�� Ű ������ ������ ��� (�� ���)
        // Debug.Log(test_dict.ContainsKey(1)); // ��ųʸ��� 1�̶�� Ű ���� �����ϴ��� true, false ���
        // Debug.Log(test_dict.ContainsValue("��")); // ��ųʸ��� "��"�̶�� ���� ���� �����ϴ��� true, false ���
        test_dict.Clear(); // ��ųʸ��� �ִ� ���� ���� ����

        Debug.Log($"Dictionary�� ũ��: {test_dict.Count}"); // �α� ���

        #endregion

        #region Equals

        string name0 = "������"; // ���� ����
        string name1 = "JDK"; // ���� ����

        if (!name0.Equals(name1)) // name0�̶�� ������ name1 ������ ���� ���� �ʴٸ�
        {
            Debug.Log($"{name0}�̶� {name1}�� �ٸ� �����̾�"); // �α� ���
        }

        #endregion */
    }
}