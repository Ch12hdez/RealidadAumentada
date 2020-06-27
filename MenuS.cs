/*
Nombre de desarrollador: Jesús Alberto Toríz Hernández
Asignatura: Realidad Aumentada
Profesor: Josué Rivas Díaz
Nombre de código: MenuS
Descripción: Codigo que se encargara de almacenar los datos o objetos del menu de seleccion
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuS : MonoBehaviour
{
    //El array se encargara de almacenar cada objeto a ser seleccionado
    public GameObject[] objetos;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in objetos)
        {
            go.SetActive(false);
        }

        if (objetos[0])
        {
            objetos[0].SetActive(true);
        }
    }

   
}
