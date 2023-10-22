using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    #region public properties

    public Rigidbody2D birdRigidBody;
    public GameObject birdWingObject;
    public float flapStrength;
    public float maxHeight;
    public float mixHeight;
    #endregion

    #region private properties
    private LogicScript logic;
    private SpriteRenderer birdWingSprite;
    private AudioSystem audioSystem;
    private bool birdIsAlive = true;
    #endregion
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdWingSprite = birdWingObject.GetComponent<SpriteRenderer>();
        audioSystem = GameObject.FindGameObjectWithTag("AudioSys").GetComponent<AudioSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && birdIsAlive) { 
            birdRigidBody.velocity = Vector2.up * flapStrength;
            birdWingSprite.flipY = true;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
            birdWingSprite.flipY = false;

        if (transform.position.y > maxHeight || transform.position.y < mixHeight)
            GameOver();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    => GameOver();

    public void GameOver()
    {
        logic.gameOver();
        birdIsAlive = false;
        audioSystem.StopMusic();
    }

}
