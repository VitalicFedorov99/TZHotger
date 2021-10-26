using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDifInGame : MonoBehaviour
{
    [SerializeField] private GameObject _imageUIChangeDif;

    public void CloseChangeDif() 
    {
        _imageUIChangeDif.SetActive(false);
    }

    public void OpenChangeDif() 
    {
        _imageUIChangeDif.SetActive(true);
    }
   
}
