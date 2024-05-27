using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Cuando el usuario presione el botón BtnAceptar
//debe escribirse un mensaje en la consola
//con una contraseña predefinida del
public class LoginManager : MonoBehaviour
{
    public Text txtaceptar;
    public InputField MiContra;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Contrasena()
    {
        if (MiContra.text == "Messi123")
        {
            Debug.Log("Accesso granted");
        }
        else
        {
            Debug.Log("Accesso denied");
        }
    }
}
        
