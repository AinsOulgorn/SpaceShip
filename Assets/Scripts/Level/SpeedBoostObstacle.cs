using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostObstacle : MonoBehaviour
{
    [SerializeField] private Obstacle _obstacle;

    [SerializeField] private float _speedBoost;


    private void Start()
    {
        _obstacle._speedObstacle = 5;
    }
    private void OnEnable()
    {
        EventBus.Complication += SpeedBoost;
    }

    private void OnDisable()
    {
        EventBus.Complication -= SpeedBoost;
    }

 


    private void SpeedBoost()
    {
        _obstacle._speedObstacle += _speedBoost;
    }



}
