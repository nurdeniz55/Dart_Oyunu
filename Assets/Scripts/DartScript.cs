using UnityEngine;

public class DartScript : MonoBehaviour
{
   
    
    private void OnCollisionEnter(Collision collision)
    {
        DestroySelf();
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
