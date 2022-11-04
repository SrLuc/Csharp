

Mexicano rMexicano = new Mexicano("El farro del Perro");
rMexicano.Localizacao="Tulum";
rMexicano.comidaPicante=true;
rMexicano.qntGarcom=1;

Japones rJapones = new Japones("Ramem Ichiraku");
rJapones.Localizacao="Konoha";
rJapones.menu="afrodisiaco";
rJapones.sushiBrazileiro=false;

Italiano rItaliano = new Italiano("Santo Madero");
rItaliano.Localizacao="Cagliari";
rItaliano.menuEuropeu=true;
rItaliano.especilistaPizza=true;

Brazileiro rBrazileiro = new Brazileiro("O melhor da região");
rBrazileiro.Localizacao="Recife";
rBrazileiro.menuInternacional=true;
rBrazileiro.mscAoVivo=true;
rBrazileiro.qtdGarcom=2;

Brazileiro rBrazileiro2 = new Brazileiro("Cantina do Moura",true);
rBrazileiro2.Localizacao="Alto do Moura";
rBrazileiro2.menuInternacional=false;
rBrazileiro2.mscAoVivo=true;
rBrazileiro2.qtdGarcom=6;

System.Console.WriteLine("O restaurante mexicano " + rMexicano.Nome + " fica localizado na ilha de " + rMexicano.Localizacao);
System.Console.WriteLine(" e  o restaurante Japones localizado em " +rJapones.Localizacao + " é conhecido pelos seu menu " + rJapones.menu);
System.Console.WriteLine("O Brasil tem o poder de juntar as culinárias globais e dessa forma em uma cidade do interior chamada " + rBrazileiro2.Localizacao);
rBrazileiro2.tocarMusica();
System.Console.WriteLine("E possivel dizer que. . ");
rBrazileiro2.Servir();


