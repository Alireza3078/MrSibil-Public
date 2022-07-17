using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{

    public float JumpPower;
    public AudioSource SpringSFX;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpPower);
            }
            if (this.gameObject.CompareTag("Spring"))
            {
                if (ScoreSystem.ScoreSystem.ScoreValue < 15000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 535;
                    SpringSFX.Play();
                    anim.SetBool("isPlay", true);
                }
                if (ScoreSystem.ScoreSystem.ScoreValue < 75000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 1650;
                    SpringSFX.Play();
                    anim.SetBool("isPlay", true);
                }
                if (ScoreSystem.ScoreSystem.ScoreValue < 155000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 2675;
                    SpringSFX.Play();
                    anim.SetBool("isPlay", true);
                }
                if (ScoreSystem.ScoreSystem.ScoreValue < 255000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 3745;
                    SpringSFX.Play();
                    anim.SetBool("isPlay", true);
                }
               
            }
           
        }

    }
}
