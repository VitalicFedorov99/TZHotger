using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DestroyCircle : MonoBehaviour
{

    [SerializeField] private Defeat _defeat;
    [SerializeField] private CountScore _countScore;
    [SerializeField] private bool _isDeactivate;
    private UnityEvent _eventDefeat;

    private void Start()
    {
       
        InitializeEvent();
    }
    public void SetData(Defeat def, CountScore countScore) 
   {
        _defeat = def;
        _countScore = countScore;
        InitializeEvent();
   }

    public void InitializeEvent() 
    {
        _eventDefeat = new UnityEvent();
        _eventDefeat.AddListener(_defeat.DefeatGame);
    }

    private void OnEnable()
    {
        StartCoroutine("Deactivater");
    }

    

    IEnumerator Deactivater()
    {
        yield return new WaitForSeconds(7f);
        if (_isDeactivate == true)
        {
            //_countScore.ScoreInc();
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.GetComponent<Ball>())
        {
            Destroy(collision.gameObject);
            _eventDefeat.Invoke();
        }
       

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.GetComponent<Ball>())
        {
            Destroy(collision.gameObject);
            _eventDefeat.Invoke();
        }

    }



}
