using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nolose : MonoBehaviour
{
    string clave = "tic2025";
   
    // Update is called once per frame
    void Update()
    {

    }
    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        if (claveIngresada != clave)
        {
            txtMensaje.text = "Acceso denegado";
        }
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
