using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class ChampiRandom : MonoBehaviour
{
 /* // Start is called before the first frame update

    void Start()
    {
       transform.position = 
       float positionX = Random.value(0f, 1f);

        if (Random.value > 0.5f){

                GameObject.Champignons

        } else {


        }
    } */

    [SerializeField] private GameObject Champignons;  
    [SerializeField] private Transform BGL;           
    [SerializeField] private Transform BGL3;          

    void Start()
    {
        float randomChance = Random.value;

        if (randomChance > 0.5f)
        {
            Instantiate(Champignons,BGL.position, Quaternion.identity);
        }
        else 
        {
            Instantiate(Champignons,BGL3.position, Quaternion.identity); 
        }
    }
}
