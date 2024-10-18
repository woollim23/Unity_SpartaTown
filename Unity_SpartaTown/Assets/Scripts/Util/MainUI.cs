using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;

public class MainUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI displayTime;
    private IEnumerator Start()
    {
        // IEnumerator ����Ƽ���� �ڷ�ƾ�� �����ϱ� ���� ����ϴ� �������̽�
        // �ڷ�ƾ�� �񵿱������� �۾��� ������ �� �ְ� ���ִ� ���
        // �ַ� ���ӿ��� �ð� �����̳� �ݺ����� �۾��� ó���� �� ����
        while (true)
        {
            displayTime.text = GetCurrntTime();
            yield return new WaitForSeconds(1f);
        }
    }

    public static string GetCurrntTime()
    {
        // ���� ��, �� ���
        return DateTime.Now.ToString(("HH : mm"));
    }
}
