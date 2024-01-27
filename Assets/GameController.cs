using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Ui user
    public ProgressBar progressBar;

    // booleanos transicion estados
    public bool visionNublada {  get; set; }
    public bool sonidosMolestos {  get; set; }
    public int victimasMaldad = 0;
    public bool nuevaVictima { get; set; }
    public int buenasAcciones = 0;
    bool nuevaBuenaAccion {  get; set; }



    //Booleans condicion victoria/derrota
    bool gano = false;
    bool perdio = false;


    // Start is called before the first frame update
    void Start()
    {
        visionNublada = false;
        sonidosMolestos = false;
        nuevaVictima = false;
        nuevaBuenaAccion = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(gano || perdio)
        {
            EndGame();
        }

        if(nuevaVictima)
        {
            nuevaVictima = false;
            victimasMaldad++;
            visionNublada=false;
            sonidosMolestos=false;
            buenasAcciones=0;
            AumentarBarraLocura(20);
        }

        if (nuevaBuenaAccion)
        {
            nuevaBuenaAccion = false;
            buenasAcciones++;
            visionNublada = true;
            sonidosMolestos = true;
            victimasMaldad = 0;
            DisminuirBarraLocura(15);
        }
        // se procesan los estados modificados por las acciones
        //ProcesarEstadosAlterados();

    }

    private void ProcesarEstadosAlterados()
    {
        if (visionNublada)
        {
            NublarVision();
        }
        else
        {
            VisionNormal();
        }

        if (sonidosMolestos) 
        {
            PrenderSonidos();
        }
        else
        {
            ApagarSonidos();
        }
    }

    private void VisionNormal()
    {
        throw new NotImplementedException();
    }

    private void NublarVision()
    {
        throw new NotImplementedException();
    }

    private void ApagarSonidos()
    {
        throw new NotImplementedException();
    }

    private bool PrenderSonidos()
    {
        throw new NotImplementedException();
    }



    // End game 
    private void EndGame()
    {
        if (gano)
        {
            Ganar();
        }
        if (perdio)
        {
            Perder();
        }
    }

    void Ganar()
    {

    }

    void Perder()
    {

    }

    // Manejo Barra Locura
    void AumentarBarraLocura(int value)
    {
        progressBar.AumentarBarra(value);
    }
    void DisminuirBarraLocura(int value)
    {
        progressBar.DisminuirBarra(value);
    }
}
