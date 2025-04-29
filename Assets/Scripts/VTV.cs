using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    // variables ingresadas por usuario
    public string patente;
    public int modelo;
    public float km;
    public int vencimiento;
    public float hc;
    // variables del programa
    float minPromedioKm = 10000;
    int añoActual = 2025;
    int minModelo = 1900;
    int maxHc = 100;
    int minHc = 5;
    int añosAuto;
    float promedioKM;
    // Start is called before the first frame update
    void Start()
    {
        // comprobaciones
        if(patente=="" || patente ==" ")
        {
            Debug.Log("patente invalida");
            Debug.Log("VTV no aprobada");
            return;
        }
        if(modelo<minModelo || modelo > añoActual)
        {
            Debug.Log("Año de fabricacion invalido");
            Debug.Log("VTV no aprobada");
            return;
        }
        if (km < 0)
        {
            Debug.Log("Kilometraje invalido");
            Debug.Log("VTV no aprobada");
            return;
        }
        if(vencimiento>= añoActual || vencimiento < modelo)
        {
            Debug.Log("Vencimiento invalido");
            Debug.Log("VTV no aprobada");
            return;
        }
        if (hc < minHc)
        {
            Debug.Log("HC ppm invalido");
            Debug.Log("VTV no aprobada");
            return;
        }
        if (hc > maxHc)
        {
            Debug.Log("Nivel de HC mayor a 100");
            Debug.Log("VTV no aprobada");
            return;
        }
        // proceso
        añosAuto = añoActual - modelo;
        promedioKM = km / añosAuto;
        Debug.Log("El promedio de kiometraje del vehiculo es de " + promedioKM + " kilometros");
        if (promedioKM < minPromedioKm)
        {
            Debug.Log("VTV otorgada por 2 años");
        }
        else
        {
            Debug.Log("VTV otorgada por 1 años");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
