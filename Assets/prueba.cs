using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    // Start is called before the first frame update
    public libreriaVectores prueba1;
    public libreriaVectores prueba2;    
    public libreriaVectores diferencia;
    public libreriaVectores mitad;
    public libreriaVectores lerpPrueba;
    public float x = 0.5f;

    void Start()
    {
        prueba1 = new libreriaVectores(20, 5);
        prueba2 = new libreriaVectores(3, 3);      


    }


   
    void Update()
    {

        diferencia = diferencia.resta(prueba2, prueba1);
        diferencia.traslado(prueba1, diferencia);
        lerpPrueba.lerp(prueba1, prueba2, x);
        
        prueba2.dibujar(prueba2, Color.green);
        prueba1.dibujar(prueba1, Color.yellow);       

        lerpPrueba.dibujar(lerpPrueba, Color.blue);

        


    }
}