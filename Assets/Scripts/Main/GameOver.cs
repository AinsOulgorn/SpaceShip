using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private Player _player;
    

    private void OnEnable()
    {
        EventBus.GameOver += Death;
    }


    private void OnDisable()
    {
     
        EventBus.GameOver -= Death;
    }

    private void Death()
    {
        Debug.Log("GameOver");
        Time.timeScale = 0;

        _gameOverScreen.SetActive(true);
        _player._stepSize = 0f;
    }

}
