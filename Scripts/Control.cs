using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public Text scoreText;
    public int score;


    void Update()
    {

            ScoreManager.score += 1;


    }
}
