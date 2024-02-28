using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour{

    public GameObject Inicio, Entrada, Processamento, Condição, Saida, InicioBlack, EntradaBlack, ProcessamentoBlack, CondiçãoBlack, SaidaBlack;

    Vector2 InicioInitialPos, EntradaInitialPos, ProcessamentoInitialPos, CondiçãoInitialPos, SaidaInitialPos;

    bool InicioCorrect, EntradaCorrect, ProcessamentoCorrect, CondiçãoCorrect, SaidaCorrect= false;

    public void start()
    {
        InicioInitialPos = Inicio.transform.position;   
        EntradaInitialPos = Entrada.transform.position;
        ProcessamentoInitialPos =  Processamento.transform.position;    
        CondiçãoInitialPos = Condição.transform.position;
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

    public void DragCondição()
    {
        Condição.transform.position = Input.mousePosition;
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

    public void DropCondição()
    {
        float Distance = Vector3.Distance(Condição.transform.position, CondiçãoBlack.transform.position);
        if (Distance > 2)
        {
            Condição.transform.position = CondiçãoBlack.transform.position;
            CondiçãoCorrect = true;
        }
        else
        {
            Condição.transform.position = CondiçãoInitialPos;
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
        if (InicioCorrect && EntradaCorrect && ProcessamentoCorrect && CondiçãoCorrect && SaidaCorrect)
        {
            Debug.Log("You Win!");
        }
    }
}
