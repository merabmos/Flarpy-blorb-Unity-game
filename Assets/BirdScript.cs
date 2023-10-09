using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public float flapStrength;
    public float maxHeight;
    public float mixHeight;

    private LogicScript logic;
    private bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && birdIsAlive)
            birdRigidBody.velocity = Vector2.up * flapStrength;

        if (transform.position.y > maxHeight || transform.position.y < mixHeight)
            GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    => GameOver();

    public void GameOver()
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}
