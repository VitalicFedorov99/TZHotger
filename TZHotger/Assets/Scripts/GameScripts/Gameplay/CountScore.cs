using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountScore : MonoBehaviour
{
    [SerializeField] private int _score=0;
    [SerializeField] private UIGame _uiGame;


   
    private void OnCollisionEnter2D(Collision2D collision)
    {
       Debug.Log(collision.gameObject.name);
        if (collision.gameObject.GetComponent<DestroyCircle>())
        {
            _score++;
            _uiGame.UpdateTextScore(_score);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.GetComponent<DestroyCircle>())
        {
            _score++;
            _uiGame.UpdateTextScore(_score);
        }
    }

    public void ScoreInc()
    {
        _score++;
        _uiGame.UpdateTextScore(_score);
    }

    public int GetScore() 
    {
        return _score;
    }
}
