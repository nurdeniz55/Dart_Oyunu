using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI scoreTMP;

    // Update is called once per frame
    void Update()
    {
        scoreTMP.text = "Skor: "+ScoreManager.Instance.getScore();
    }
}
