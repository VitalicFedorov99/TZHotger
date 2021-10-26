using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]private float _force;
    [SerializeField] private float _constForce;
    public Rigidbody2D _rg2D;
    private void Start()
    {
        _rg2D = GetComponent<Rigidbody2D>();
        _force = _constForce;
        StartCoroutine("ForceUpInc");
    }
   


    public void Jump() 
    {
        _rg2D.velocity = Vector2.up * _force;
    }
    IEnumerator ForceUpInc()
    {
        
        yield return new WaitForSeconds(15f);
        ForceInc();
        StartCoroutine("ForceUpInc");
    }

    public void ForceInc() 
    {
        _force++;
    }

    public void SetConstForce(float constForce) 
    {
        _constForce = constForce;
    }





}
