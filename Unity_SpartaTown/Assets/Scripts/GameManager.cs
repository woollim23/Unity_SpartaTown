using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private string playerTag;
    public Player player;
    public int playerId;

    public string playerName;

    public Transform PlayerTransform { get; private set; } // �÷��̾� transform

    private void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this;
        playerId = 0;
    }

    public void GameStart()
    {
        player.gameObject.SetActive(true);
        PlayerTransform = GameObject.FindGameObjectWithTag(playerTag).transform;
        // �÷��̾� �±׸� �˻��Ͽ�, �÷��̾� ������Ʈ�� ã�� transform���� ������
    }

    public void SetId(int id)
    {
        playerId = id;
    }
}
