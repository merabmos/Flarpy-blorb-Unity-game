using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovingScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public float minScoreToGetFast = 0;
    public float fastingPointsAfterGetMinScore = 0;

    void Start()
    {
    }

    void Update()
    {   
        
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
            Destroy(gameObject);

    }
}
