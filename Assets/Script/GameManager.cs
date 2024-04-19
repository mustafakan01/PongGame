using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] Canvas canvas;
    [SerializeField] private GameObject textStart;
    [SerializeField] private GameObject textTry;
    public int Score { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        textTry.SetActive(true);
        textStart.SetActive(false);
    }

    public void OnClickStartButton()
    {
        textStart.SetActive(false);
        Ball.Instance.OnStart();
    }
}
