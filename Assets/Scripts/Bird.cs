using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool isDead = true;
    public float velocity = 1.0f;
    public Rigidbody2D birdRb;

    public GameManager managerGame;
    public GameObject DeathScreen;
    void Start()
    {
        Time.timeScale = 1;
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // jump
            birdRb.velocity = Vector2.up * velocity;
            
        }
        transform.eulerAngles = new Vector3(0, 0, birdRb.velocity.y * 0.2f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }
}
