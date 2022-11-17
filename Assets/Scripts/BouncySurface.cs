using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Gives us the object (ball) that collided with the surface
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // Checks if it was the ball that collided with the surface
        if(ball != null)
        {
            // The direction the ball bounces towards
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
            FindObjectOfType<AudioManager>().Play("Bounce");      
        }
    }
}
