using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public float finalScore;
    [SerializeField] private PlayerDeath death;
    [SerializeField] private PlayerInventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        finalScore = 100;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Total Score: "+ Mathf.Round(FinalScore());
    }
    public float FinalScore()
    {
        return finalScore - 10*death.deathCount+50*inventory.numberOfBerries;
    }
}
