using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    #region  variables

    public AudioSource audioData;
    
    private int played = 0;

    public AudioSource winsound;
    public AudioSource background;
    
    #region vitamines
    public Text B12Score;
    private int B12ScireNb;

    public Text CAScore;
    private int CAScireNb;

    public Text FeScore;
    private int FEScoreNb;
    #endregion

    public Slider slider;
    public GameObject win;

    
    #region Animations
    public Animator p1;
    public Animator p2;
    public Animator p3;
    public Animator p4;
    public Animator p5;
    public Animator p6;
    public Animator p7;
    public Animator p8;
    public Animator p9;
    public Animator p10;
    public Animator p11;
    public Animator p12;
    #endregion
    #endregion
    
    #region methods

    void Start(){
        B12ScireNb = 0;
        B12Score.text = B12ScireNb.ToString();

        CAScireNb = 0;
        CAScore.text = CAScireNb.ToString();

        FEScoreNb = 0;
        FeScore.text = FEScoreNb.ToString();

        slider.value = 0;
    }
     void Update()
    {
        
        switch(slider.value)
        {
            case (float)0.1 :
                p1.Play("Animation_Biscuit1");
                break;
            case (float)0.2 :
                p2.Play("Animation_Puzzle2");
                break;
            case (float)0.3 :
                p3.Play("Animation_Puzzle3");
                break;
            case (float)0.4 :
                p4.Play("Animation_Puzzle4");
                p5.Play("Animation_Puzzle5");
                break;
            case (float)0.5 :
                p6.Play("Animation_Puzzle6");
                break;
            case (float)0.6:
                p7.Play("Animation_Puzzle7");
                break;

        }

        if(slider.value > 0.65 && slider.value < 0.8) 
        {
        Debug.Log("0.7"); 
        p8.Play("Animation_Puzzle8");
        }

        if(slider.value >= 0.8 && slider.value < 0.9) 
        {
        Debug.Log("0.8");
        p9.Play("Animation_Puzzle9");
        p10.Play("Animation_Puzzle10");
        }

        if(slider.value > 0.9 && slider.value < 1) 
        {
            Debug.Log("0.9"); 
        p11.Play("Animation_Puzzle11");
        }

        if(slider.value ==1)
        {
            p12.Play("Animation_Puzzle127");
        StartCoroutine(WaitAnimationEnd());
        }
    }
    //counter
    private IEnumerator WaitAnimationEnd() 
    {
        yield return new WaitForSeconds(3);
        Debug.Log("waited");
        win.SetActive(true);
        background.Pause();
        played ++;
        if(played == 1) winsound.Play();
    }
    //Incriment Counter when eat Vitamin
    #region On Trigger Enter
    private void OnTriggerEnter2D (Collider2D col) {
        
        if (col.gameObject.tag == "Vitamin" ) {
            
            audioData.Play();
            col.gameObject.active = false;
            Incriment(0.1);
            if(col.gameObject.name.Contains("B12"))
            {
                B12ScireNb++;
                B12Score.text = B12ScireNb.ToString();
            }
            if(col.gameObject.name.Contains("CA"))
            {
                CAScireNb++;
                CAScore.text = CAScireNb.ToString();
            }
            if(col.gameObject.name.Contains("FE"))
            {
                FEScoreNb++;
                FeScore.text = FEScoreNb.ToString();
            }
        }
    }
    #endregion
    
    //Incriment Slider
    #region Incriment 
    private void Incriment(double addedProgress){
        slider.value += (float)addedProgress;
    }
    #endregion
    
    #endregion
}
