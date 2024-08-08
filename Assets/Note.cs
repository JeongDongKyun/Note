using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private void Start()
    {
        /* #region List

        List<string> string_list = new List<string>(); // 리스트 선언

        string_list.Add("안녕하세요"); // 리스트 안에 값 넣기
        string_list.Add("반갑습니다"); // 리스트 안에 값 넣기
        string_list.Remove("안녕하세요"); // 리스트 안에 내용 입력 방식으로 값 삭제
        string_list.RemoveAt(0); // 리스트 안에 인덱스 입력 방식으로 값 삭제
        string_list.Add("가나다라마바사"); // 리스트 안에 값 넣기
        string_list.Insert(0, "이게 먼저 값이 들어감"); // 몇번 째에 끼워서 값 넣기
        string_list.Clear(); // 리스트 안에 값들 전부 삭제
        // Debug.Log(string_list.IndexOf("이게 먼저 값이 들어감")); // 이 값의 인덱스를 찾기
        // Debug.Log(string_list.Contains("이게 먼저 값이 들어감")); // 리스트 안에 특정 값이 있다면 True or Flase

        for (int i = 0; i < string_list.Count; i++) // 리스트 크기만큼 실행
        {
            Debug.Log(string_list[i]); // 로그 출력
        }

        Debug.Log($"List의 크기: {string_list.Count}"); // 로그 출력

        #endregion

        #region Dictionary

        Dictionary<int, string> test_dict = new Dictionary<int, string>(); // 딕셔너리 선언

        test_dict.Add(1, "일"); // 딕셔너리 안에 값 넣기
        test_dict.Add(2, "이"); // 딕셔너리 안에 값 넣기
        test_dict.Add(3, "삼"); // 딕셔너리 안에 값 넣기
        // Debug.Log(test_dict[1]); // 1이라는 키 값으로 벨류를 출력 (일 출력)
        // Debug.Log(test_dict.ContainsKey(1)); // 딕셔너리에 1이라는 키 값이 존재하는지 true, false 출력
        // Debug.Log(test_dict.ContainsValue("삼")); // 딕셔너리에 "삼"이라는 벨류 값이 존재하는지 true, false 출력
        test_dict.Clear(); // 딕셔너리에 있는 값들 전부 삭제

        Debug.Log($"Dictionary의 크기: {test_dict.Count}"); // 로그 출력

        #endregion

        #region Equals

        string name0 = "정동균"; // 변수 선언
        string name1 = "JDK"; // 변수 선언

        if (!name0.Equals(name1)) // name0이라는 변수랑 name1 변수의 값이 같지 않다면
        {
            Debug.Log($"{name0}이랑 {name1}는 다른 문장이야"); // 로그 출력
        }

        #endregion */
    }
}