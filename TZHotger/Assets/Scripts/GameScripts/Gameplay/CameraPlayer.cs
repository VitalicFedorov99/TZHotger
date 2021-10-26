using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    [SerializeField]private GameObject _player;
    public float cameraDistance = 10.0f;

   
    public void SetPlayer(Ball player) 
    {

        _player = player.gameObject;
    }

    void LateUpdate()
    {
        if (_player != null)
        {
            transform.position = _player.transform.position - _player.transform.forward * cameraDistance;
            transform.LookAt(_player.transform.position);
            transform.position = new Vector3(transform.position.x + 2, 0, transform.position.z);
        }
    }
}
