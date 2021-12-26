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
 public TextMeshProUGUI  timer;
 public GameObject GameOver;
 public GameObject HasWon;
 public GameObject Paused;
 public Slider slider;
 #endregion
 
 #region methods

 void Start()
 {
     currentTime = startingTime;
 }

 void Update()
 {
     
     if(currentTime > 0 && HasWon.active == false && slider.value != 1 && Paused.active == false) 
     {
     currentTime -= 1*Time.deltaTime;
     timer.SetText(((int)(currentTime)).ToString()) ;
     }
     else if(currentTime <= 0 && HasWon.active == false ) 
     {
         Debug.Log("Game Over");
         GameOver.SetActive(true);
     }    
     
 }
#endregion
}
