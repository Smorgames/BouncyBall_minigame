using UnityEngine;
public class IncreaseSpeedCoin : Coin
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            CoinMechanics();
    }

    public override void AddScoreAndSpawnNextCoin()
    {
        base.AddScoreAndSpawnNextCoin();
        GameObject.FindWithTag("Circle").GetComponent<RotateController>().IncreaseSpeed(30);
        AudioManager.instance.Play("SpeedIncrease");
    }
}


//{
//    GAME_MANAGER.instance.AddScore(GetScorePoint());
//    GameObject.FindWithTag("Circle").GetComponent<RotateController>().IncreaseSpeed(30);
//    CoinSpawner.instance.SpawnCoin();
//    Destroy(gameObject);
//}