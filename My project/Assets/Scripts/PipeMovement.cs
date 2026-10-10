using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PipeKillBox"))
        {
            Destroy(gameObject);
        }
    }
}
