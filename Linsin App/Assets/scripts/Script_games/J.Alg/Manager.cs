using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour{

    public GameObject Inicio, Entrada, Processamento, Condi��o, Saida, InicioBlack, EntradaBlack, ProcessamentoBlack, Condi��oBlack, SaidaBlack;

    Vector2 InicioInitialPos, EntradaInitialPos, ProcessamentoInitialPos, Condi��oInitialPos, SaidaInitialPos;

    bool InicioCorrect, EntradaCorrect, ProcessamentoCorrect, Condi��oCorrect, SaidaCorrect= false;

    public void start()
    {
        InicioInitialPos = Inicio.transform.position;   
        EntradaInitialPos = Entrada.transform.position;
        ProcessamentoInitialPos =  Processamento.transform.position;    
        Condi��oInitialPos = Condi��o.transform.position;
        SaidaInitialPos = Saida.transform.position;
    }

    public void DragInicio()
    {
        Inicio.transform.position = Input.mousePosition; 
    }

    public void DragEntrada()
    {
        Entrada.transform.position = Input.mousePosition;
    }

    public void DragProcessamento()
    {
        Processamento.transform.position = Input.mousePosition;
    }

    public void DragCondi��o()
    {
        Condi��o.transform.position = Input.mousePosition;
    }

    public void DragSaida()
    {
        Saida.transform.position = Input.mousePosition;
    }




    public void DropInicio()
    {
        float Distance = Vector3.Distance(Inicio.transform.position, InicioBlack.transform.position);
        if (Distance > 2) 
        {
            Inicio.transform.position = InicioBlack.transform.position;
            InicioCorrect = true;
        }
        else
        {
            Inicio.transform.position = InicioInitialPos;   
        }
    }

    public void DropEntrada()
    {
        float Distance = Vector3.Distance(Entrada.transform.position, EntradaBlack.transform.position);
        if (Distance > 2)
        {
            Entrada.transform.position = EntradaBlack.transform.position;
            EntradaCorrect = true;
        }
        else
        {
            Entrada.transform.position = EntradaInitialPos;
        }
    }

    public void DropProcessamento()
    {
        float Distance = Vector3.Distance(Processamento.transform.position, ProcessamentoBlack.transform.position);
        if (Distance > 2)
        {
            Processamento.transform.position = ProcessamentoBlack.transform.position;
            ProcessamentoCorrect = true;
        }
        else
        {
            Processamento.transform.position = ProcessamentoInitialPos;
        }
    }

    public void DropCondi��o()
    {
        float Distance = Vector3.Distance(Condi��o.transform.position, Condi��oBlack.transform.position);
        if (Distance > 2)
        {
            Condi��o.transform.position = Condi��oBlack.transform.position;
            Condi��oCorrect = true;
        }
        else
        {
            Condi��o.transform.position = Condi��oInitialPos;
        }
    }

    public void DropSaida()
    {
        float Distance = Vector3.Distance(Saida.transform.position, SaidaBlack.transform.position);
        if (Distance > 2)
        {
            Saida.transform.position = SaidaBlack.transform.position;
            SaidaCorrect = true;    
        }
        else
        {
            Saida.transform.position = SaidaInitialPos;
        }
    }
    void update()
    {
        if (InicioCorrect && EntradaCorrect && ProcessamentoCorrect && Condi��oCorrect && SaidaCorrect)
        {
            Debug.Log("You Win!");
        }
    }
}
