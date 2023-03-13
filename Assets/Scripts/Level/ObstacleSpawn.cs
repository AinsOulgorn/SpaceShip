using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    
    [SerializeField] private GameObject[] _obstaclePattern;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _startTimeSpawn;
    [SerializeField] private float _decreaseTime;
    [SerializeField] private float _minTimeSpawn;
    [SerializeField] private float _speedBoostStep;
    [SerializeField] private Player _player;
    


    private void Update()
    {
        if (_timeSpawn <= 0)
        {
            _player._score++; //начисляю очки при спавне
            int _rand = Random.Range(0, _obstaclePattern.Length);
            Instantiate(_obstaclePattern[_rand], transform.position, Quaternion.identity);
            _timeSpawn = _startTimeSpawn;

            if (_player._score % _speedBoostStep == 0 & _player._score != 0) //счет каждый _speedBoostTime увеличивает скорость
            {
                EventBus.Complication?.Invoke();
            }


            if (_startTimeSpawn > _minTimeSpawn)
            {
                _startTimeSpawn -= _decreaseTime;

                



            }
           
        }
        else
        {

            _timeSpawn -= Time.deltaTime;
        }




    }
}
