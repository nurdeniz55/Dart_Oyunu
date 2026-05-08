using UnityEngine;

public class GameLevel : MonoBehaviour
{   
    public static GameLevel Instance;
    [SerializeField]private int balonCount;
    private int levelNumber;

    private void Awake()
    {
        Instance = this;
    }
    public int GetBalonCount() {  return balonCount; }
    public void DecreaseBalonCount() {  balonCount --; }
    public int GetLevelNumber()
    {
        return levelNumber;
    }
    
}
