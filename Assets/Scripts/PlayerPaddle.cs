using UnityEngine;

public class PlayerPaddle : Paddle
{
    // Keep track of paddle's direction
    private Vector2 _direction;

    private void Update()   // Update() is called every single frame in the game
    {
        // Player can both use WASD or arrow keys
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            _direction = Vector2.up;

        }else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            _direction = Vector2.down;
        
        }else{
            // No player input = no movement
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()  // FixedUpdate() is called at a fixed time interval
    {
        // Checks for movement before adding force onto paddle
        if(_direction.sqrMagnitude != 0){
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
