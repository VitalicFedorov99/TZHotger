using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificultInButton : MonoBehaviour
{
    [SerializeField] private DificultGame.Dificult _dificultButton;
    [SerializeField] private ChooseDificult _chooseDif;
    [SerializeField] private ChangeColorChooseButton _changeColor;
     

    
    public void GiveDificultButton() 
    {
        _chooseDif.SetDificult(_dificultButton);
        _changeColor.ChooseButton(_dificultButton);
    }
}
