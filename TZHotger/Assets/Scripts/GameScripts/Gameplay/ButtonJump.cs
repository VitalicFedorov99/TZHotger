using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class ButtonJump : MonoBehaviour
{
    [SerializeField] private Button but;
    private Ball _ball;

    public void AddJump() 
    {
        but.onClick.AddListener(_ball.Jump);
    }

    public void SetBall(Ball ball) 
    {
        _ball = ball;
        AddJump();
    }



}
