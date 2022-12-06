using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private int pontos;
    [SerializeField] private MeuEventoPersonalizadoInt aoPontuar; 

    public void Pontuar()
    {
        this.pontos++;
        this.aoPontuar.Invoke(this.pontos);
    }
}

[System.Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>{

}