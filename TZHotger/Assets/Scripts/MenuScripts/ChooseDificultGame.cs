using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChooseDificultGame : MonoBehaviour
{
    [SerializeField] private Button _buttonEasyGame;
    [SerializeField] private Button _buttonMidGame;
    [SerializeField] private Button _buttonHardGame;

    [SerializeField] private DificultGame.Dificult _dificult;
  


    
    public void SetDificult(DificultGame.Dificult dif) 
    {
        
        _dificult = dif;
    }


    public DificultGame.Dificult GetDificult() 
    {
       
        return _dificult;
    }






}
