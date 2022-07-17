using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoinController;

public class MovementJump : MonoBehaviour
{
    public GameObject GameoverPanel;
    public GameObject NavbarPanel;
    public float MovementSpeed;
    Rigidbody2D RigidBody;
    //float dirX;
    float keyboardMovement;
    public AudioSource GameOverSFX;


    void Start()
    {
        RigidBody = GetComponent<Rigidbody2D>();
        RigidBody.simulated = true;
    }
    void Update()
    {
       // dirX = Input.acceleration.x * MovementSpeed;
       // transform.position = new Vector2(Mathf.Clamp(transform.position.x, -75f, 75f), transform.position.y);
       keyboardMovement = Input.GetAxis("Horizontal") * MovementSpeed;
    }
    private void FixedUpdate()
    {
      //  RigidBody.velocity = new Vector2(dirX, RigidBody.velocity.y);
       Vector2 velocity = RigidBody.velocity;
       velocity.x = keyboardMovement;
       RigidBody.velocity = velocity;

    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DeadZone")
        {
            Time.timeScale = 0;
            GameoverPanel.SetActive(true);
            NavbarPanel.SetActive(false);
            GameOverSFX.Play();      
        }
    }
    

}
