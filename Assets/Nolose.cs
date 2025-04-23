using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nolose : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;
    

    string clave = "tic2025";
   
    // Update is called once per frame
    void Update()
    {
        txtMensaje.text = string.Empty;
    }
    public void ComprobarClaveIngresada()
    {
        string claveIngresada = InputClave.text;
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
