using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] public float _speedObstacle;
    [SerializeField] private float _speedBoost;

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
        _speedObstacle += _speedBoost;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Hit");
            EventBus.GameOver?.Invoke();
        }
        else if(collision.tag == "Destroyer")
        {
            Debug.Log("Destroy");
            Destroy(this.gameObject);
        }
        
    }



    private void Update()
    {


        transform.Translate(Vector2.left * _speedObstacle * Time.deltaTime);
    }
}
