using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float JumpPower;
    public AudioSource PlatformSFX;
    private bool UsedScore = false;


  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpPower);
            }
            if (this.gameObject.CompareTag("ScoreZone") && !UsedScore)
            {
                if (ScoreSystem.ScoreSystem.ScoreValue < 15000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 220;
                    PlatformSFX.Play();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue >15000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 440;
                    PlatformSFX.Play();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 45000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 660;
                    PlatformSFX.Play();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 75000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 880;
                    PlatformSFX.Play();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 115000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 1100;
                    PlatformSFX.Play();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 155000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 1320;
                    PlatformSFX.Play();
                }
                if (ScoreSystem.ScoreSystem.ScoreValue > 205000)
                {
                    UsedScore = true;
                    ScoreSystem.ScoreSystem.ScoreValue += 1540;
                    PlatformSFX.Play();
                }
            }
            if (this.gameObject.CompareTag("ScoreZone") && UsedScore)
            {
                PlatformSFX.Play();
            }

            if (this.gameObject.CompareTag("NormalScoreZone") && !UsedScore)
            {
                UsedScore = true;
                ScoreSystem.ScoreSystem.ScoreValue += 285;
                PlatformSFX.Play();
            }
            if (this.gameObject.CompareTag("NormalScoreZone") && UsedScore)
            {
                PlatformSFX.Play();
            }

        }

    }
}
