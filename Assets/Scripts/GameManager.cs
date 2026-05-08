using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject player;
    [SerializeField] private int levelNumber;
    [SerializeField] private List<GameLevel> gameLevelList;
    [SerializeField] private TextMeshProUGUI finalScore;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        LoadCurrentLevel();
        
    }
    private void LoadCurrentLevel()
    {
        foreach (GameLevel level in gameLevelList)
        {
            if (level.GetLevelNumber() == levelNumber)
            {
                Instantiate(level, Vector3.zero, Quaternion.identity);
            }
        }
    }
    public void StopGame()
    {
        PlayerLook pl = player.GetComponent<PlayerLook>();
        pl.enabled = false;
        CharacterController cc = pl.GetComponent<CharacterController>();
        cc.enabled = false;

        
        finalScore.text = "FINAL SCORE: " + ScoreManager.Instance.getScore();
    }
}