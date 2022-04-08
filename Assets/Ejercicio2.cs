//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si
// la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float PrecioProd1;
    public float PrecioProd2;
    public float PrecioProd3;
    public float MontoDisponible;
    // Start is called before the first frame update
    void Start()
    {
        if (PrecioProd1 + PrecioProd2 + PrecioProd3 > MontoDisponible)
        {
            Debug.Log("La suma de los precios de los 3 productos supera tu monto disponible. Te faltan $"+(PrecioProd1+PrecioProd2+PrecioProd3-MontoDisponible));
        }
        else
        {
            Debug.Log("La suma de los precios de los 3 productos no supera tu monto disponible. Te sobrarán $" + (MontoDisponible - PrecioProd3 - PrecioProd2 - PrecioProd1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
