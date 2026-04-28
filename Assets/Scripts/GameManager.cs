using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int levelNumber;
    [SerializeField] private List<GameLevel> gameLevelList;
    private void Awake()
    {
        instance = this;
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
}