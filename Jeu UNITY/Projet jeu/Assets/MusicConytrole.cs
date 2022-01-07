using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicConytrole : MonoBehaviour
{
    public AudioSource backGround;
    public Slider musicSlider;

    

    public void VolumeUp()
    {
      backGround.volume += 0.1f;
      musicSlider.value += 0.1f;
    }
    public void VolumeDown()
    {
      backGround.volume -= 0.1f;
      musicSlider.value -= 0.1f;
    }

}
