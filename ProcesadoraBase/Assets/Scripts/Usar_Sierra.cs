using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usar_Sierra : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("USANDO SIERRA Dentro");
            MoverHojaDentro();

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            print("USANDO SIERRA Fuera");
            MoverHojaFuera();

        }
    }

    private void MoverHojaDentro()
    {
        transform.Rotate(new Vector3(0f, 10f, 0f));
    }
    private void MoverHojaFuera()
    {
        transform.Rotate(new Vector3(0f, -10f, 0f));
    }
}
