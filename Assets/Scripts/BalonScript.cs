using UnityEngine;

public class BalonScript : MonoBehaviour
{
    [SerializeField]private int health=1;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out DartScript dartscript))
        {
            TakeDamage();
        }
        
    }
    private void TakeDamage()
    {
        health--;
        if(health <= 0)
        {
            DestroySelf();
        }
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
