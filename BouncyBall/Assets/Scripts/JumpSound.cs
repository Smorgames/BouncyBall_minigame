using UnityEngine;

public class JumpSound : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Circle")
            AudioManager.instance.Play("Jump");
    }
}
