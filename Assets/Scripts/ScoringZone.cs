using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    public UnityEvent OnScoreTrigger;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            this.OnScoreTrigger.Invoke();
        }
    }
}
