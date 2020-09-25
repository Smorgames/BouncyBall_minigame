using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _spikes;

    private void Start()
    {
        int randomNumber = Random.Range(0, _spikes.Length);

        _spikes[randomNumber].SetActive(true);

        int secondRandomNumber = Random.Range(0, _spikes.Length);

        while (secondRandomNumber == randomNumber)
            secondRandomNumber = Random.Range(0, _spikes.Length);

        _spikes[secondRandomNumber].SetActive(true);
    }
}
