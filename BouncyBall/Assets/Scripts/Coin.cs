using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _scorePoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            CoinMechanics();
    }

    public virtual void AddScoreAndSpawnNextCoin()
    {
        GAME_MANAGER.instance.AddScore(_scorePoint);
        AudioManager.instance.Play("PickCoin");
        CoinSpawner.instance.SpawnCoin();
    }

    public void CoinMechanics()
    {
        AddScoreAndSpawnNextCoin();
        Destroy(gameObject);
    }

    public int GetScorePoint()
    {
        return _scorePoint;
    }
}
