using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{

    [SerializeField] private List<GameObject> _objectMoveRight = new List<GameObject>();
    [SerializeField] private float _speed;
    
    private void FixedUpdate()
    {
        for (int i = 0; i < _objectMoveRight.Count; i++)
        {
           _objectMoveRight[i].transform.Translate(_speed * Time.fixedDeltaTime, 0, 0);
        }
    }


    public void SetSpeed(float speed) 
    {
        _speed = speed;
    }

    public void AddObjectInMoveRight(GameObject _object) 
    {
        _objectMoveRight.Add(_object);
    }


}
