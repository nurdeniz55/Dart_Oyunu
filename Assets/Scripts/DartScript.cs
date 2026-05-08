using UnityEngine;

public class DartScript : MonoBehaviour
{
    float time;
    private void Start()
    {
        time = 0;
    }
    
    private void Update()
    {
        time += Time.deltaTime;
        if(time > 5)
        {
            ScoreManager.Instance.AddScore(-20);
            DestroySelf();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        DestroySelf();
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
