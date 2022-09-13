using System;

Insolacao sol = new Insolacao();

Preciptacao chuva = new Preciptacao();

for (int i = 0; i < 9; i++)
{
    sol.FazerSol(chuva);
    chuva.Chover(sol);

}
