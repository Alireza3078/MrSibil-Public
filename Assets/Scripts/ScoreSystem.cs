﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ScoreSystem
{
    public class ScoreSystem : MonoBehaviour
    {
        public  Text ScoreInGame;
        public  Text ScoreInPanel;
        public  Text Highscore;
        public static int ScoreValue = 0;
        private bool isHighScoreReached;
        private int LastScore;
        public AudioSource HighScoreSFX;
        private void Start()
        {
            HighScoreSFX = GetComponent<AudioSource>();
            ScoreInGame.GetComponent<Text>();
            ScoreInPanel.GetComponent<Text>();
            Highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        }
        private void Update()
        {
            ScoreInPanel.text = ScoreValue.ToString();
            ScoreInGame.text = ScoreValue.ToString();
            if (ScoreValue > PlayerPrefs.GetInt("HighScore", 0))
            {
                if (isHighScoreReached == false)
                {
                    isHighScoreReached = true;
                    HighScoreSFX.Play();
                    Highscore.text = ScoreValue.ToString();
                }
                PlayerPrefs.SetInt("HighScore", ScoreValue);
            }
            StartCoroutine(AnimateScore());
        }
        bool isAnimating = false;
        IEnumerator AnimateScore()
        {
            while(isAnimating)
            {
                yield return null;
            }
            isAnimating = true;
            int nonstaticScore = ScoreValue;
            for (int i = LastScore;i < nonstaticScore; i++)
            {
                ScoreInGame.text = i.ToString();
                yield return null;
            }
            LastScore = ScoreValue;
            isAnimating = false;
        }
        
    }
}