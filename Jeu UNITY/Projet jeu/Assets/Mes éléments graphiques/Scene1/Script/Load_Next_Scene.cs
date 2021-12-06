using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Next_Scene : MonoBehaviour
{
    
    public void Load_Scene(string name)
    {
         SceneManager.LoadScene(name);
    }
    public void exit(){
        Application.Quit();
    }

}
