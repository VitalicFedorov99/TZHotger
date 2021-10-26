using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLossImage : MonoBehaviour
{
    [SerializeField] private GameObject _imageUILoss;

    public void OpenImageLoss() 
    {
        _imageUILoss.SetActive(true);
    }
}
