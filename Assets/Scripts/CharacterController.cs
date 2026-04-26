using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    [SerializeField] private GameObject dartPrefab;
    [SerializeField] private GameObject dartSpawnPoint;
    void Start()
    {
        GameInput.Instance.OnShootAction += GameInput_OnShootAction;
    }

    private void GameInput_OnShootAction(object sender, System.EventArgs e)
    {
        Instantiate(dartPrefab, dartSpawnPoint.transform.position, Quaternion.identity);
    }
}
