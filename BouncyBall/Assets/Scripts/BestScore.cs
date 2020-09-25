using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;

    private void OnEnable()
    {
        if (GAME_MANAGER.instance.GetScore() > PlayerPrefs.GetInt("BestScore", 0))
        {
            PlayerPrefs.SetInt("BestScore", GAME_MANAGER.instance.GetScore());
            _score.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
        }
        else
            _score.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
    }
}
