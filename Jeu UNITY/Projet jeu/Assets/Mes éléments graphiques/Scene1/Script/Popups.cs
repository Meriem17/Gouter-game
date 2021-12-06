using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popups : MonoBehaviour
{
    public GameObject GO;

    public void openPopUp(){
        GO.SetActive(true);
    }
        public void closePopUp(){
        GO.SetActive(false);
    }
}
