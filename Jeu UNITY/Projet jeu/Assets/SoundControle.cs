using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControle : MonoBehaviour
{
    public AudioSource click;
    public Slider soundSlider;
    

    public void VolumeUp()
    {
      click.volume += 0.1f;
      soundSlider.value += 0.1f;
    }
    public void VolumeDown()
    {
      click.volume -= 0.1f;
      soundSlider.value -= 0.1f;
    }
}
