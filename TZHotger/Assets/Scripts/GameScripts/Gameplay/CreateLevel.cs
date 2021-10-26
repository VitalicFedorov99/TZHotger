using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{
    [SerializeField] private MoveRight _moveRight;
    [SerializeField] private Ball _ball;
    [SerializeField] private GameObject _placeInstBall;
    [SerializeField] private Level[] _levels ;
    [SerializeField] private Level _choosesLevel;
    [SerializeField] private CreaterBlock _createrBlock;
    [SerializeField] private CameraPlayer _camera;
    [SerializeField] private ButtonJump _btnJupm;
    private void Start()
    {
        Chooselevel();
        ChangeSettingsLevel();
        InstanceBall();
    }

    


    public void Chooselevel()
    {
        int numberDif = PlayerPrefs.GetInt("DificultGame");
        _choosesLevel = _levels[numberDif];
    }

    public void ChangeSettingsLevel() 
    {
        _moveRight.SetSpeed(_choosesLevel.GetSpeed());
        _ball.SetConstForce(_choosesLevel.GetForce());
        _createrBlock.SetTimeCreateBlock(_choosesLevel.GetTimeBlock());
    }

    public void InstanceBall() 
    {
      
        Ball localBall=Instantiate(_ball, _placeInstBall.transform.position, Quaternion.identity) ;
        _btnJupm.SetBall(localBall);
        _camera.SetPlayer(localBall);
        _moveRight.AddObjectInMoveRight(localBall.gameObject);
    }

}
