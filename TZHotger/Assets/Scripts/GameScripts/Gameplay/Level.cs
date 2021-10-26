using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "_level")]
public class Level : ScriptableObject
{
    [SerializeField] private DificultGame.Dificult _dif;
    [SerializeField] private int _force;
    [SerializeField] private float _timeBlock;
    [SerializeField] private int _speedHorizontal;


    public DificultGame.Dificult GetDificult() 
    {
        return _dif;
    }

    public int GetForce() 
    {
        return _force;
    }

    public float GetTimeBlock() 
    {
        return _timeBlock;
    }

    public float GetSpeed() 
    {
        return _speedHorizontal;
    }

}
