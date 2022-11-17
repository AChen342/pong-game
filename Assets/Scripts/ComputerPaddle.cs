using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate() // Physics related logic
    {   
        // Checks if the ball is moving to the right or towards the AI paddle
        if (this.ball.velocity.x > 0.0f)
        {   
            // If the ball is above the paddle then the AI paddle needs to move up
            if(this.ball.position.y > this.transform.position.y){
                _rigidbody.AddForce(Vector2.up * this.speed);  

            // If the ball is below the paddle, then the AI paddle needs to move down
            }else if(this.ball.position.y < this.transform.position.y){
                _rigidbody.AddForce(Vector2.down * this.speed);

            }

        // If the ball is moving to the left or away from the AI paddle
        }else{
            // The paddle will try and move towards the center

            //If the paddle is above the center, then it will move downwards
            if(this.transform.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * this.speed);
            
            //If the paddle is below the center, then it will move upwards
            }else if(this.transform.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
