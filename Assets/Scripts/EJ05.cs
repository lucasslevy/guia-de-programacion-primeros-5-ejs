﻿//5. Realizá un programa que, dados dos números enteros num1 y num2 cargados desde  el Inspector muestre el resultado de la división del primero por el segundo en la consola siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.  
//En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:  “No se puede dividir por cero”. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ05 : MonoBehaviour
{
    public int num1;
    public int num2;
    int resultado;

    void Start()
    {
            if (num2 == 0)
            {
                Debug.Log("no se puede dividir por cero");
            }
            else
            {
                res = num1 / num2;
                Debug.Log(num1 + "/" + num2 + " = " + resultad);
            }
    }

    
    void Update()
    {
        
    }
}
