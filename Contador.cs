/*
Nombre de desarrollador: Jesús Alberto Toríz Hernández
Asignatura: Realidad Aumentada
Profesor: Josué Rivas Díaz
Nombre de código: Contador
Descripción: El contador tendra todas las variables y metodos que desencadenaran la seleccion de un objeto y su asignación al imagetarget
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    //Declaracion de variables para identificar a los objetos y sus especificaciones
    #region Declaración de Variables
    public MenuS gemas;
    public GameObject elegido;
    public GameObject destruirObj;
    public GameObject menuHome;
    public Transform objPosition;
    public Transform padrePosition;
    public GameObject[] menus;
    public int contador;
    #endregion

    //Codigo que activa los menus y a la vez llama a las "gemas"
    private void Start()
    {
        gemas = GetComponentInParent<MenuS>();
        menuHome.SetActive(false);
    }

    //Codigo que al entrar en contacto mediante el clic va a ir sumando lo que ira cambiando de objeto, de uno a uno
    public void ContadorSuma()
    {
        gemas.objetos[contador].SetActive(false);
        contador++;

        if (contador == gemas.objetos.Length)
        {
            contador = 0;
        }

        gemas.objetos[contador].SetActive(true);

    }

    //Codigo que al entrar en contacto mediante el clic va a ir restando lo que ira cambiando de objeto, de uno a uno pero en manera contraria
    public void ContadorResta()
    {
        gemas.objetos[contador].SetActive(false);
        contador--;

        if (contador < 0)
        {
            contador = gemas.objetos.Length - 1; //Al indice final del array
        }

        gemas.objetos[contador].SetActive(true);
    }

   //Codigos que identifican a los objetos y al seleccionarlos se aplican en la pantalla y con ello se genera un ciclo que si se da clic al icono de "home" regresa a la pantalla para seleccionar otro objeto
   //y aparecera de igual manera en pantalla
    public void Seleccion()
    {
        GameObject gemaPos = Instantiate(elegido,objPosition.position,objPosition.rotation ) as GameObject;

        gemaPos.transform.SetParent(padrePosition);

        gemaPos.GetComponent<MeshRenderer>().enabled = false;

        gemaPos.AddComponent<BoxCollider>();

        gemaPos.tag = "Player";

        foreach (var m in menus)
        {
            m.SetActive(false);
        }

        menuHome.SetActive(true);
    }

    public void Home()
    {
        destruirObj = GameObject.FindGameObjectWithTag("Player");
        Destroy(destruirObj);

        foreach (var m in menus)
        {
            m.SetActive(true);
        }

        menuHome.SetActive(false);
    }

    private void Update()
    {
        elegido = gemas.objetos[contador];
    }

}
