using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Ajoute ce namespace

public class Score : MonoBehaviour
{
    int score;
    TMP_Text scoreText; // Change le type à TMP_Text

    void Start()
    {
        score = 0;
        scoreText = GetComponent<TMP_Text>(); // Assigne le composant TextMeshProUGUI
        UpdateScoreText(); // Met à jour le texte au démarrage
    }

    public void ScoreUp()
    {
        score++;
        UpdateScoreText(); // Met à jour le texte quand le score change
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString(); // Met à jour le texte du score
    }
}
