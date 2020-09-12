using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBrazoIzquierd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("CerrandoBrazoIzq");
            CerrarBrazoIZQ();

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("AbriendoBrazoIzq");
            AbrirBrazoIZQ();

        }
    }

    private void CerrarBrazoIZQ()
    {
        transform.Rotate(new Vector3(0f, 0f, 10f));
    }
    private void AbrirBrazoIZQ()
    {
        transform.Rotate(new Vector3(0f, 0f, -10f));
    }
}
