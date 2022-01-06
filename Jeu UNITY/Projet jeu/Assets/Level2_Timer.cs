using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level2_Timer : MonoBehaviour
{
 #region variables
 private float currentTime = 0f;

 private int played = 0;

 public AudioSource lose;
 public AudioSource win;
 public AudioSource background;

 public TextMeshProUGUI kakiScore;
 public TextMeshProUGUI fromageScore;
 public GameObject GameOver;
 public GameObject HasWon;
 public GameObject Paused;
 public GameObject EditSound;
 public GameObject instructions;
 public Slider slider;
 #endregion

#region functions
    void Update()
    {
     
    //win/lost controle
     if(currentTime <1 && HasWon.active == false && Paused.active == false && EditSound.active == false && instructions.active == false ) 
     {
     slider.value += (float)0.05*Time.deltaTime;
     currentTime = slider.value;
     //timer.SetText(((int)(currentTime)).ToString()) ;
     }
     else if((currentTime == 1 && HasWon.active == false && kakiScore.text != fromageScore.text )||( currentTime == 1 && HasWon.active == false && kakiScore.text == "0" && fromageScore.text == "0")) 
     {
         Debug.Log("Game Over");
         background.Pause();
         played ++;
         if(played == 1) lose.Play();
         GameOver.SetActive(true);
     } 
     else if(currentTime == 1 && kakiScore.text == fromageScore.text && kakiScore.text != "0")
     {
         background.Pause();
         played ++;
         if(played == 1) win.Play();
         HasWon.SetActive(true);
     }   
    }
#endregion   
   
}
