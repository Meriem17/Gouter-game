using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreValue : MonoBehaviour
{
    public Slider slider;
    public Text score;
    void Update()
    {
        score.text = ((int)(slider.value *100)).ToString();
    }

}
