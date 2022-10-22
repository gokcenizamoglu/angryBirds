using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDragging : MonoBehaviour
{
    Bird _bird;
    [SerializeField] LineRenderer catapultLineFront;
    [SerializeField] LineRenderer catapultLineBack;


    void Start()
    {
        _bird = FindObjectOfType<Bird>();
        catapultLineFront.SetPosition(0, catapultLineFront.transform.position);
        catapultLineBack.SetPosition(0, catapultLineBack.transform.position);

    }

    void Update()
    {
        
        catapultLineFront.sortingLayerName = "Foreground";
        catapultLineBack.sortingLayerName = "Foreground";

        catapultLineFront.sortingOrder = 3;
        catapultLineBack.sortingOrder = 1;

        if (_bird.IsDragging)
        {
            catapultLineBack.enabled = true;
            catapultLineFront.enabled = true;
            Vector3 holdPoint = transform.position;
            catapultLineFront.SetPosition(1, holdPoint);
            catapultLineBack.SetPosition(1, holdPoint);

        }
        else
        {
            catapultLineBack.enabled = false;
            catapultLineFront.enabled = false;
        }





    }
}
