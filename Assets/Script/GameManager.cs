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
    public GameObject textTry;    
    [SerializeField] private TextMeshProUGUI textScore;
    public int Score { get=>_score;
        set
        {
            textScore.text = value.ToString();
            _score = value;
        } }
    public int _score { get; set; }

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
        Score = 0;
        textStart.SetActive(false);
        Ball.Instance.OnStart();
    }
}
