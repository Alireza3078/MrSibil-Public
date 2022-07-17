
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakPlatform : MonoBehaviour
{
    public float JumpPower;
    public AudioSource BreakSFX;
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
            if (this.gameObject.CompareTag("Break"))
            {
                if (ScoreSystem.ScoreSystem.ScoreValue < 15000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 135;
                    BreakSFX.Play();
                    anim.SetBool("isBreaking", true);
                    DestroyNow();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 15000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 270;
                    BreakSFX.Play();
                    anim.SetBool("isBreaking", true);
                    DestroyNow();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 45000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 405;
                    BreakSFX.Play();
                    anim.SetBool("isBreaking", true);
                    DestroyNow();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 75000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 540;
                    BreakSFX.Play();
                    anim.SetBool("isBreaking", true);
                    DestroyNow();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 115000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 675;
                    BreakSFX.Play();
                    anim.SetBool("isBreaking", true);
                    DestroyNow();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 155000)
                {
                    ScoreSystem.ScoreSystem.ScoreValue += 810;
                    BreakSFX.Play();
                    anim.SetBool("isBreaking", true);
                    DestroyNow();
                }
            }
        }

    }

    void DestroyNow()
    {
        Destroy(this.gameObject,1f);
    }
}
