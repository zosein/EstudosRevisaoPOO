﻿

namespace _15_Composicao;

public class Professor
{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }

    public Professor(string? nome, string? disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }
}
