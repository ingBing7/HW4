using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //player movement stuff
    private Rigidbody2D rb;

    public float jumpForce = 5f;

    private bool canMove = true;

    //events
    public delegate void EmptyDelegate();

    public event EmptyDelegate BirdJumped;

    public event EmptyDelegate BirdScored;

    public event EmptyDelegate BirdDied;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canMove == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            BirdJumped?.Invoke();
        }
            
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PointsCollider"))
        {
            BirdScored?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("KillBox"))
        {
            BirdDied?.Invoke();
            canMove = false;
        }
    }
}
