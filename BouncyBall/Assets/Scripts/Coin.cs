using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _scorePoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GAME_MANAGER.instance.AddScore(_scorePoint);
            CoinSpawner.instance.SpawnCoin();
            Destroy(gameObject);
        }
    }
}
