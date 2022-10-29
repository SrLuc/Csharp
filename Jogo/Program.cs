

//Inicializando no construtor: quantidade, nome
Local Taverna = new Local(15, "Bode Cabeçudo");
Taverna.pacifico = true;

//Inicializando no construtor: quantidade, nome, npc
Local Floresta = new Local(30, "Bosque Saltitante", true, true);
Floresta.pacifico = false;

//Inicializando no construtor: quantidade, nome, npc
Local Acampamento = new Local(30, "Acampamento", true);
Acampamento.pacifico = true;

//Inicializando no construtor: monstros, nome, chefe, quantidade de Jogadores
Local Masmorra = new Local(true, "Floresta Escura", "Srivir", 30);
Masmorra.Chefe = "Srivir o Carvalho Espinhoso";
Masmorra.descricao = "Floresta onde a luz não toca as folhas do chão";
Masmorra.pacifico = false;





