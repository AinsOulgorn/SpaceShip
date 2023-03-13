using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGame : MonoBehaviour
{

    [SerializeField] private GameObject _startScreen;
    [SerializeField] private GameObject _obstacleSpawn;
    [SerializeField] private Player _player;
    

    void Start()
    {
        Time.timeScale = 0;
        _player._stepSize = 0f;
    }

    public void StartGameClick()
    {
        _startScreen.SetActive(false);
        Time.timeScale= 1;
        _player._stepSize=3.5f;
        _obstacleSpawn.SetActive(true);


    }


}
