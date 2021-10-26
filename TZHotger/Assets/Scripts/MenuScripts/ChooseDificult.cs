using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChooseDificult : MonoBehaviour
{

    [SerializeField] private DificultGame.Dificult _dificult;
   

    public void SetDificult(DificultGame.Dificult dif)
    {

        _dificult = dif;
    }

    public void Start()
    {
        int numberDif = PlayerPrefs.GetInt("DificultGame");
        switch (numberDif) 
        {
            case 0:
                _dificult = DificultGame.Dificult.Easy;
                break;
            case 1:
                _dificult = DificultGame.Dificult.Mid;
                break;
            case 2:
                _dificult = DificultGame.Dificult.Hard;
                break;
        }

        GetComponent<ChangeColorChooseButton>().ChangeColor(numberDif);
      
       
        
        
    }

    public DificultGame.Dificult GetDificult()
    {

        return _dificult;
    }
}
