using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class level2_scorevalue : MonoBehaviour
{
    public TextMeshProUGUI score;
    public Text currentScore;

    void Update()
    {
        currentScore.text = score.text;
    }
}
