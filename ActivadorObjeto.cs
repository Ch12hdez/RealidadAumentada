/*
Nombre de desarrollador: Jesús Alberto Toríz Hernández
Asignatura: Realidad Aumentada
Profesor: Josué Rivas Díaz
Nombre de código: Activador Objeto
Descripción: Codigo encargado de marcar e identificar a los objetos que seran activados o desactivados dependiendo si estan activos o inactivos
*/

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ActivadorObjeto : MonoBehaviour
{
    //Declaracion de variables para activar y localizar al objeto indicado
    public GameObject activarObj;
    public Transform vinculaObj; 
    
    //Lineas de codigo que indican que al estar despierto o activo se busca al objeto y si esta desactivado deja se buscarlo, estas sirven para que se logre identificar automaticamente los objetos que tenemos en la escena, volviendolo mas autonomo y rapido
    private void Awake()
    {
        activarObj.SetActive(false);
    }
    
    public void ObjetoActivado()
    {
        activarObj.SetActive(true);
        vinculaObj.SetParent(transform);
    }

    public void ObjetoDesactivado()
    {
        activarObj.SetActive(false);
    }
}
