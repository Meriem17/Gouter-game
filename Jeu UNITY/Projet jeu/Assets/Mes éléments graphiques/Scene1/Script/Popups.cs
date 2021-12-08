using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popups : MonoBehaviour
{
    public GameObject GO;
    public void openPopUp(){
        Debug.Log("open");
        GO.SetActive(true);
    }
        public void closePopUp(){
        Debug.Log("close");
        GO.SetActive(false);
    }
}
