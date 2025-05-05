using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER1 : MonoBehaviour
{

    public TMP_InputField InputClave;
    public TextMeshProUGUI txtResultado;
    string claveIngresada;
    string claveCorrecta = "jeroCrack";

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = " ";
    }

    public void Clave()
    {
        claveIngresada = InputClave.text;

        if (claveIngresada == claveCorrecta)
        {
            txtResultado.text = "Clave correcta";
        }
        else
        {
            txtResultado.text = "Clave incorrecta";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
