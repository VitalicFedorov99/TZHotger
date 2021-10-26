using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{

    [SerializeField] private OpenLossImage _openUI;
    [SerializeField] private MoveRight _moveRight;
    [SerializeField] private CameraPlayer _camera;
    [SerializeField] private CountScore _countScore;
    public void DefeatGame() 
    {
        gameObject.GetComponent<OrganizationDataLoss>().UpdateText(_countScore.GetScore());
        _openUI.OpenImageLoss();
        _moveRight.enabled=false;
        _camera.enabled = false;
    }


}
