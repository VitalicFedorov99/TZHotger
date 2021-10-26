using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OrganizationDataLoss : MonoBehaviour
{

    [SerializeField] private Text _lastTryText;
    [SerializeField] private Text _countTryText;
    public void UpdateCountTry()
    {
        int countTry = PlayerPrefs.GetInt("CountTry");
        countTry++;
        PlayerPrefs.SetInt("CountTry", countTry);
        _countTryText.text = " ���������� ������� : " + countTry.ToString();
    }

    public void UpdateLastTryText(int count) 
    {
        _lastTryText.text = " �������� �������: " + count.ToString();
    }

    public void UpdateText(int count) 
    {
        UpdateCountTry();
        UpdateLastTryText(count);
    }
    


    




}
