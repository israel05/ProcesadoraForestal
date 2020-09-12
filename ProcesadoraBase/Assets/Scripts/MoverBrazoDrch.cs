using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBrazoDrch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("CerrandoBrazoIzq");
            CerrarBrazoDRC();

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("AbriendoBrazoIzq");
            AbrirBrazoDRC();

        }
    }

    private void CerrarBrazoDRC()
    {
        transform.Rotate(new Vector3(0f, 0f, -10f));
    }
    private void AbrirBrazoDRC()
    {
        transform.Rotate(new Vector3(0f, 0f, 10f));
    }
}
