﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Exercicios;

public interface IVeiculo
{
    void Dirigir();
    bool Abastecer(int quantidade);
}