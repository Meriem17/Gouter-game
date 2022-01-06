using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControle : MonoBehaviour
{
    public AudioSource click;
    

    public void VolumeUp()
    {
      click.volume += 0.1f;
    }
    public void VolumeDown()
    {
      click.volume -= 0.1f;
    }
}
