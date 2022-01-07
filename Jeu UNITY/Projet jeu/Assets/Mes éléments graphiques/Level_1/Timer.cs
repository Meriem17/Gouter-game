using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

 #region variables
 private float currentTime = 0f;
 private float startingTime = 30f;
 private int played = 0;

 public AudioSource lose;
 public AudioSource background;
 public TextMeshProUGUI  timer;
 public GameObject GameOver;
 public GameObject HasWon;
 public GameObject Paused;
 public GameObject EditSound;
 public GameObject instructions;
 public Slider slider;
 #endregion
 
 #region methods

 void Start()
 {
     currentTime = startingTime;
 }

 void Update()
 {
   
     if(currentTime > 0 && HasWon.active == false && Paused.active == false && EditSound.active == false && instructions.active == false) 
     {
     currentTime -= 1*Time.deltaTime;
     timer.SetText(((int)(currentTime)).ToString()) ;
     }
     else if(currentTime <= 0 && HasWon.active == false ) 
     {
         Debug.Log("Game Over");
         GameOver.SetActive(true);
         background.Pause();
         played ++;
         if(played ==1) lose.Play();
     }    
     
 }
#endregion
}
