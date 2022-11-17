using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D _rigidbody;

    private void Start()    // Will only be called once, which is when game starts
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        // Reset ball position to center
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();    
    }

    public void AddStartingForce()
    {
        // If x is less than half, then go to left
        // If x is greater than half, then go to right
        // Random.value generates random number
        float x = Random.value < 0.5f ? -1.0f : 1.0f;   // Shorthand if-else statement

        // Ball going towards a random angle
        // Negative values = left side
        // Positive values = right side
        float y = Random.value < 0.5 ? Random.Range(-1.0f, -0.5f) :                              
                                       Random.Range(0.5f, 1.0f);

        // Ball movement
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force){
        _rigidbody.AddForce(force);
    }
}
