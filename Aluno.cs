﻿using System;
namespace NotasAluno
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double NotaReprovado()
        {
            return 60 - NotaFinal();
        }


    }
}
