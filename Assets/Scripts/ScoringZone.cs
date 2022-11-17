using UnityEngine;
using UnityEngine.EventSystems;

// This script is similar to BouncySurface.cs
public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if(ball != null)
        {
            // When the ball hits the scoring zone, this event will trigger
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
            FindObjectOfType<AudioManager>().Play("Score");

        }
    }
}
