using System;
using System.Collections.Generic;
using System.Text;

//Elemento:
//ICalcularPrecoFinal

//Tipo em C#:
//INTERFACE

//Papel na Arquitetura:
//Define o contrato obrigatório para cálculo de valor

//Conceito de POO:
//Contrato / Abstração

namespace SiriCascudo.Interfaces
{
    internal interface ICalcularPrecoFinal
    {
        // Toda classe que assinar essa interface DEVE implementar este método
        double CalcularPrecoFinal();
    }
}