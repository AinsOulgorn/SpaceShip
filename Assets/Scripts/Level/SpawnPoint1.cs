using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint1 : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;


    private void Start()
    {
        Instantiate(_obstacle,transform.position,Quaternion.identity);

    }

}
