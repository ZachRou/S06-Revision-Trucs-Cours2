using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaieBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    
    void Start()

    {
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        Instantiate(_prefabOriginal, position, rotation);
    }
}
