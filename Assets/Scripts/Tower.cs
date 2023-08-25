using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float visionRange = 5f;

    private void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            float distance = Mathf.Sqrt(
                Mathf.Pow(player.transform.position.x - transform.position.x, 2) +
                Mathf.Pow(player.transform.position.y - transform.position.y, 2));

            if (distance <= visionRange)
            {
            
                float dotProduct = (
                    (player.transform.position.x - transform.position.x) *
                    transform.up.x +
                    (player.transform.position.y - transform.position.y) *
                    transform.up.y);

                if (dotProduct >= 0)
                {
                    
                    Debug.Log("Player detected! Restart the game.");
                   
                }
            }
        }
    }
}