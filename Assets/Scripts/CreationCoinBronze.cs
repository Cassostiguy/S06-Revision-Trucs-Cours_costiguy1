using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCoinBronze : MonoBehaviour
{


    [SerializeField] GameObject _prefabOriginal;
    

    void Start()
    {
        
        Instantiate(_prefabOriginal, transform.position, transform.rotation);
    }
}
