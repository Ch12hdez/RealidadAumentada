/*
Nombre de desarrollador: Jesús Alberto Toríz Hernández
Asignatura: Realidad Aumentada
Profesor: Josué Rivas Díaz
Nombre de código: Reproducir Animacion
Descripción: Codigo encargado de identificar y aplicar las animaciones indicadas, cuando se activa la corrutina
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ReproducirAnimacion : MonoBehaviour
{
    //Declaracion de variables para identificar las animaciones
    public Animator anim;
    public AnimationClip animation;

   
    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    //Codigo que identifica y manda a llamar a la animación correspondiente y la activa
    public void EmpezarCo()
    {
        StartCoroutine(ReproducirAnimacionR());
    }

    //Codigo que activa la animacion "Spin" y se espera a que se aplique y posteriormente se activa la de "idle"
    public IEnumerator ReproducirAnimacionR()
    {
        anim.Play("Spin");
        yield return new WaitForSeconds(animation.length);
        anim.Play("idle");
        yield return null;
        StopAllCoroutines();
        yield break;

    }
}
