using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    #region Singletone
    public static CoinSpawner instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _coinPrefab;

    private RotateController _circleRotateController;

    private void Start()
    {
        _circleRotateController = GameObject.FindWithTag("Circle").GetComponent<RotateController>();

        SpawnCoin();
    }

    public void SpawnCoin()
    {
        GameObject coin = (GameObject)Instantiate(_coinPrefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);

        coin.GetComponent<RotateController>().SetRotationSpeed(-_circleRotateController.GetRotationSpeed());

        coin.transform.SetParent(GameObject.FindWithTag("Circle").transform);
    }
}