using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            transform.Rotate(0f, 0f, _rotationSpeed * Time.deltaTime);
    }
}
