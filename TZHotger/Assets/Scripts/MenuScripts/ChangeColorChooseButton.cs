using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColorChooseButton : MonoBehaviour
{
    [SerializeField] private Image[] _imgButton;
   

    public void ChooseButton(DificultGame.Dificult dif)
    {

        int d = (int)dif;
        switch (d)
        {
            case 0:
                ChangeColor(0);
                break;
            case 1:
                ChangeColor(1);
                break;
            case 2:
                ChangeColor(2);
                break;
        }
    }


    public void ChangeColor(int element) 
    { 
        for(int i=0; i<_imgButton.Length; i++)
        {
            if (i == element) 
            {
                _imgButton[i].color = Color.green;
            }
            else 
            {
                _imgButton[i].color = Color.white;
            }
        }
        SaveInPlayerPrefsDificult(element);
    }

    public void SaveInPlayerPrefsDificult(int number) 
    {
        PlayerPrefs.SetInt("DificultGame", number);
    }



}
