using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAleatoire : MonoBehaviour
{
    void Start()
    {
        // Rotation completement aleatoire
        // transform.rotation = Random.rotation;

        // Rotation aléatore entre une rangé des valeurs
        float rotationY = Random.Range(-180f, 180f);
        transform.Rotate(0, rotationY, 0,Space.World);
    }
}
