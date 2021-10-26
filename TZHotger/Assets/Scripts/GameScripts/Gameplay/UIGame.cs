using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIGame : MonoBehaviour
{
    [SerializeField] private Text _textScore;
    void Start()
    {
        
    }


    public void UpdateTextScore(int scr) 
    {
        _textScore.text = scr.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
