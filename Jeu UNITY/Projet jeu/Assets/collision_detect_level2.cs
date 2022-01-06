using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class collision_detect_level2 : MonoBehaviour
{
    public AudioSource hum;
    public Slider slider;

    public TextMeshProUGUI kakiScore;
    private int kakiNb;

    public TextMeshProUGUI creamScore;
    private int creamNb;



    void Start()
    {
        kakiNb = 0;
        kakiScore.text = kakiNb.ToString();

        creamNb = 0;
        creamScore.text = creamNb.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     #region On Trigger Enter
    private void OnTriggerEnter2D (Collider2D col) {
        
        if (col.gameObject.tag == "Vitamin" ) {
            
            hum.Play();
            col.gameObject.active = false;
            //Incriment(0.1);
            if(col.gameObject.name.Contains("kaki"))
            {
                kakiNb++;
                kakiScore.text = kakiNb.ToString();
            }
            if(col.gameObject.name.Contains("crème"))
            {
                creamNb++;
                creamScore.text = creamNb.ToString();
            }
           
        }
    }
    #endregion

}
