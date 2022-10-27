using System;

Lutador Lutador1 = new Lutador();
Lutador1.nome = "Diogo";
//Lutador1.forca = 7;
Lutador1.vida = 10;


Lutador Lutador2 = new Lutador();
Lutador2.nome = "Maikon";
//Lutador2.forca = 9;
Lutador2.vida = 10;


for (int i = 1; i < 15; i++)
{
    Lutador1.Lutar(Lutador2);
    Lutador2.Lutar(Lutador1);
    
}