using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public static CoinSpawner instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _coinPrefab;

    private void Start()
    {
        SpawnCoin();
    }

    public void SpawnCoin()
    {
        GameObject coin = (GameObject)Instantiate(_coinPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);

        coin.transform.SetParent(GameObject.FindWithTag("Circle").transform);
    }
}