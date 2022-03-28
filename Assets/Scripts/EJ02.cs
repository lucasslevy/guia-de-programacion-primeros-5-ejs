//2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
//a. Suma 
//b. Producto 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ02 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int producto;
    int suma;
    
    void Start()
    {
        suma = num1 + num2;
        Debug.Log("4 mas 5 es igual a " + suma);
        producto = num1 * num2;
        Debug.Log("Al multiplicarlos el resultado es " + producto);
    }

    
    void Update()
    {
        
    }
}
