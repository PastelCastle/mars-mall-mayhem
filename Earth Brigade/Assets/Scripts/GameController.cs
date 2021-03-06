﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    void GameOver(bool timeout)
    {
        ScoreStatus.Timeout = timeout;
        SceneManager.LoadScene(2);
    }

    void GainPoint()
    {
        ScoreStatus.Score += 1;
    }

    void LosePoint()
    {
        ScoreStatus.Score -= 1;
    }
}
