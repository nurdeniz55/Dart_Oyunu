using UnityEngine;

public class CharacterController : MonoBehaviour
{
    
    [SerializeField] private GameObject dartPrefab;
    [SerializeField] private GameObject dartSpawnPoint;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float dartSpeed;
    void Start()
    {
        GameInput.Instance.OnShootAction += GameInput_OnShootAction;
    }

    private void GameInput_OnShootAction(object sender, System.EventArgs e)
    {
        GameObject dart = Instantiate(dartPrefab, dartSpawnPoint.transform.position,playerCamera.transform.rotation);
        Rigidbody rb = dart.GetComponent<Rigidbody>();
        rb.AddForce(playerCamera.transform.forward * dartSpeed, ForceMode.Impulse);

    }
}
