Ferramenta marreta = new Ferramenta();
marreta.nome = "martelo";
marreta.dureza = 4;
marreta.porrada = 7;

Obstaculo parede = new Obstaculo();
parede.material = "tijolo";
parede.resistencia = 4;

Pintura tinta = new Pintura();
tinta.cor = "vermelho";
tinta.tintaOleo = true;


for (int i = 0; i < 14; i++)
{
    marreta.Bater(parede); 
}

for (int i = 0; i < 1; i++)
{
    tinta.Pintar(parede);
}
