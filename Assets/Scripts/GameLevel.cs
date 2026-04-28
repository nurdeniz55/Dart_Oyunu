using UnityEngine;

public class GameLevel : MonoBehaviour
{
    [SerializeField]private int balonCount;
    private int levelNumber;

    public int GetLevelNumber()
    {
        return levelNumber;
    }
    
}
