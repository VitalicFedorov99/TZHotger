using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    
    public void LoadSceneGame() 
    {
        SceneManager.LoadScene("Game",LoadSceneMode.Single);
    }
}
