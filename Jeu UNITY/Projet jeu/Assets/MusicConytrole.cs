using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicConytrole : MonoBehaviour
{
    public AudioSource backGround;
    

    public void VolumeUp()
    {
      backGround.volume += 0.1f;
    }
    public void VolumeDown()
    {
      backGround.volume -= 0.1f;
    }

}
