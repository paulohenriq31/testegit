using System;

namespace Fase1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//VARIAVEL
			string nome, raca, genero, classe ;
			int escolhaClasse = 0, escolhaRaca = 0, dano = 0, vidaRaca = 0, vidaClasse = 0, vidaTotal = 0, idade;
			double altura, peso;
			bool louco;
			Console.Clear ();

			//INICIO DO GAME
			Console.WriteLine ("FASE 1 - START");
			Console.WriteLine ("--------------");

			//FICHA PERSONAGEM
			nome = "TrollFreak";
			idade = 19;
			genero = "Masculino";
			altura = 1.70;
			peso = 70;
			louco = true;

			Console.WriteLine ("Escreva o nome do Persongem");
			nome = Console.ReadLine ();

			Console.WriteLine ("Qual a Idade de " + nome);
			idade = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Qual a Altura de " + nome);
			altura = Convert.ToDouble (Console.ReadLine ());

			Console.WriteLine ("Qual o peso de " + nome);
			peso = Convert.ToDouble (Console.ReadLine ());

			Console.WriteLine ("Qual o Genero de " + nome);
			Console.WriteLine ("1-Masculino");
			Console.WriteLine ("2-Feminino");
			Console.Write ("Escolha entre [1-2]: "); 
			genero = Console.ReadLine ();
			Console.WriteLine ("");
			if (genero == "1"){
				genero = "Masculino";
			} else if (genero == "2"){
				genero = "Feminino";
			}

			//CLASSE

			classe = "nulo";

			while (escolhaClasse  < 1 || escolhaClasse  > 9) {
				Console.WriteLine ("Qual a Classe de " + nome);
				Console.WriteLine ("1-Alquimista");
				Console.WriteLine ("Vida = 60");
				Console.WriteLine ("2-Arqueiro");
				Console.WriteLine ("Vida = 75");
				Console.WriteLine ("3-Assassino");
				Console.WriteLine ("Vida = 70");
				Console.WriteLine ("4-Caçador");
				Console.WriteLine ("Vida = 100");
				Console.WriteLine ("5-Dobrador");
				Console.WriteLine ("Vida = 80");
				Console.WriteLine ("6-Guerreiro");
				Console.WriteLine ("Vida = 130");
				Console.WriteLine ("7-Ladrão");
				Console.WriteLine ("Vida = 50");
				Console.WriteLine ("8-Lutador");
				Console.WriteLine ("Vida = 110");
				Console.Write ("Escolha entre [1-8]: ");
				escolhaClasse  = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("");
				Console.Clear ();
				if (escolhaClasse  == 1) {
					classe = "Alquimista";
					vidaClasse = 60;
				} else if (escolhaClasse  == 2) {
					classe = "Arqueiro";
					vidaClasse = 75;
				} else if (escolhaClasse  == 3) {
					classe = "Assassino";
					vidaClasse = 70;
				} else if (escolhaClasse  == 4) {
					classe = "Caçador";
					vidaClasse = 100;
				} else if (escolhaClasse  == 5) {
					classe = "Dobrador";
					vidaClasse = 80;
				} else if (escolhaClasse  == 6) {
					classe = "Guerreiro";
					vidaClasse = 130;
				} else if (escolhaClasse  == 7) {
					classe = "Ladrão";
					vidaClasse = 50;
				} else if (escolhaClasse  == 8) {
					classe = "Lutador";
					vidaClasse = 110;
				}
			}
			//RAÇA
			raca = "nulo";

			while (escolhaRaca < 1 || escolhaRaca > 9) {
				Console.WriteLine ("Qual Sera a Raça de " + nome);
				Console.WriteLine ("1-Amazona");
				Console.WriteLine ("Vida = 60");
				Console.WriteLine ("2-Dragoniano");
				Console.WriteLine ("Vida = 100");
				Console.WriteLine ("3-Duende");
				Console.WriteLine ("Vida = 50");
				Console.WriteLine ("4-Fada");
				Console.WriteLine ("Vida = 90");
				Console.WriteLine ("5-Marinho");
				Console.WriteLine ("Vida = 150");
				Console.WriteLine ("6-Ninfa");
				Console.WriteLine ("Vida = 30");
				Console.WriteLine ("7-Selvagem");
				Console.WriteLine ("Vida = 40");
				Console.WriteLine ("8-Wendigo");
				Console.WriteLine ("Vida = 70");
				Console.Write ("Escolha entre [1-8]: ");
				escolhaRaca = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("");
				Console.Clear ();
				if (escolhaRaca == 1) {
					raca = "Amazona";
					vidaRaca = 60;
				} else if (escolhaRaca == 2) {
					raca = "Dragoniano";
					vidaRaca = 100;
				} else if (escolhaRaca == 3) {
					raca = "Duende";
					vidaRaca = 50;
				} else if (escolhaRaca == 4) {
					raca = "Fada";
					vidaRaca = 90;
				} else if (escolhaRaca == 5) {
					raca = "Marinho";
					vidaRaca = 150;
				} else if (escolhaRaca == 6) {
					raca = "Ninfa";
					vidaRaca = 30;
				} else if (escolhaRaca == 7) {
					raca = "Selvagem";
					vidaRaca = 40;
				} else if (escolhaRaca == 8) {
					raca = "Wendigo";
					vidaRaca = 70;
				}				
			}
			vidaTotal = (vidaClasse + vidaRaca);
			dano = 100;

			//EXIBIR FICHA
			Console.WriteLine ("Nome: " + nome);
			Console.WriteLine ("Classe: " + classe);
			Console.WriteLine ("Raça: " + raca);
			Console.WriteLine ("Genero: " + genero);
			Console.WriteLine ("Idade: " + idade);
			Console.WriteLine ("Altura: " + altura);
			Console.WriteLine ("Peso: " + peso);
			Console.WriteLine ("Vida: " + vidaTotal);
			Console.WriteLine ("dano: " + dano);
			Console.WriteLine ("Loucura: " + louco);
			Console.WriteLine ("");
			Console.WriteLine ("press enter");
			Console.ReadKey ();
			Console.Clear ();

			int danoInimigo = 25, dados = 0, vidaInimigo = 35;
			string inimigo1, inimigo2;

			inimigo1 = "Duaim";

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("=====INIMIGO=====");
			Console.WriteLine ("");
			Console.WriteLine ("Nome: " + inimigo1);
			Console.WriteLine ("Dano: " + danoInimigo);
			Console.WriteLine ("Vida: " + vidaInimigo);
			Console.WriteLine ("");
			Console.ResetColor ();
			Console.WriteLine ("press enter");
			Console.ReadKey ();


			Random aleatorio = new Random ();
			dados = aleatorio.Next (1, 6);

			danoInimigo = (danoInimigo * dados);
			vidaInimigo = (vidaInimigo * dados);
			Console.WriteLine ("O valor do ataque sera decidido nos dados.");
			Console.WriteLine ("multilplicando o resultado dos dados pelo ataque original");
			Console.WriteLine ("");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine ("Resultado dos dados: " + dados);
			Console.ResetColor ();
			Console.WriteLine ("press enter");
			Console.ReadKey ();

			if (escolhaClasse == 9 && escolhaRaca == 9) {
				vidaTotal = 5000;
				dano = 5000;
			}

			Console.WriteLine ("=====BATALHA=====");
			Console.WriteLine (inimigo1 + " Ataca " + nome);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine ("Valor dos Dados: " + dados);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
			Console.WriteLine ("Dano Inimigo: " + danoInimigo);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("Sua Vida: " + vidaTotal);
			Console.WriteLine ("Seu Atack: " + dano);
			Console.ResetColor ();
			Console.WriteLine ("press enter");
			Console.ReadKey ();	

			while (vidaTotal > 0 || vidaInimigo > 0) {

				if (danoInimigo >= vidaTotal) {
					vidaTotal = (vidaTotal - danoInimigo);
					Console.WriteLine (inimigo1 + " Ataca " + nome);
					Console.WriteLine (inimigo1 + " matou " + nome);
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine ("vida atual: " + vidaTotal);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("GAME OVER");
					Console.ResetColor ();
					Console.WriteLine ("press enter");
					Console.ReadKey ();
					break;
				} else if (danoInimigo < vidaTotal) {
					vidaTotal = (vidaTotal - danoInimigo);
					Console.WriteLine (inimigo1 + " ataca " + nome);
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine ("vida atual: " + vidaTotal);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
					Console.ResetColor ();
					Console.WriteLine ("press enter");
					Console.ReadKey ();
				}

				if (dano >= vidaInimigo) {
					Console.WriteLine (nome + " Atacou " + inimigo1);
					Console.WriteLine (nome + " matou " + inimigo1);
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine ("Você Ganhou a Batalha");
					Console.WriteLine ("Vida atual: " + vidaTotal);
					Console.ResetColor ();
					Console.WriteLine ("press enter");
					break;

				} else if (dano < vidaInimigo) {
					vidaInimigo = (vidaInimigo - dano);
					Console.WriteLine (nome + " Atacou " + inimigo1);
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine ("vida atual: " + vidaTotal);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
					Console.ResetColor ();
					Console.WriteLine ("press enter");
					Console.ReadKey ();
					}

				}
			Console.ReadKey ();

			if (vidaTotal > 0) {
				int item = 0;
				while (item < 1 || item > 2) {
					Console.WriteLine ("O " + inimigo1 + " deixou cair duas armas voce poderar escolher uma delas");
					Console.WriteLine ("1-espada amaldiçoada");
					Console.WriteLine ("2-Armadura divina");
					Console.Write ("[1-2]: ");
					item = Convert.ToInt32 (Console.ReadLine ());
					if (item == 1) {
						dano = (dano + 100);
					} else if (item == 2) {
						vidaTotal = (vidaTotal + 100);
					}
					Console.WriteLine ("");
				}
				Console.WriteLine ("Você tera o direito a um numero da sorte");
				Console.WriteLine ("Se o numero da sorte for sorteado voce tera direito á");
				Console.WriteLine ("escolha entre 500 de vida ou 200 de atack");
				Console.Write ("Informe o seu numero da sorte [1-6]: ");
				int sorte;
				sorte = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("");

				dados = aleatorio.Next (1, 6);
				Console.WriteLine ("Valor dos dados: " + dados);
				Console.WriteLine ("");
			
				if (dados == sorte) {
					Console.WriteLine ("1-Vida");
					Console.WriteLine ("2-Atack");
					int escolha;
					Console.Write ("[1-2]: ");
					escolha = Convert.ToInt32 (Console.ReadLine ());
					if (escolha == 1) {
						vidaTotal = (vidaTotal + 500);
					} else if (escolha == 2) {
						dano = (dano + 300);
					}
					Console.WriteLine ("");
				}
				Console.WriteLine ("press enter");
				Console.ReadKey ();
				Console.Clear ();
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine ("Sua Vida: " + vidaTotal);
				Console.WriteLine ("Seu Atack: " + dano);
				Console.ReadKey ();
				Console.ResetColor ();

				Console.Write ("jogue os dados: ");
				Console.ReadKey ();
				Console.WriteLine ("");
				dados = aleatorio.Next (1, 6);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine ("O valor dos dados foi: " + dados);
				Console.ResetColor ();
				Console.ReadKey ();

				inimigo2 = "MANEVA";

				if (dados == 1) {
					inimigo2 = "Urialor";
					danoInimigo = 40;
					vidaInimigo = 20;
				} else if (dados ==2){
					inimigo2 = "Peula";
					danoInimigo = 20;
					vidaInimigo = 40;
				} else if (dados == 3){
					inimigo2 = "Vavus";
					danoInimigo = 10;
					vidaInimigo = 60;
				} else if (dados ==4){
					inimigo2 = "Erval";
					danoInimigo = 40;
					vidaInimigo = 5;
				} else if (dados == 5){
					inimigo2 = "Dolhe";
					danoInimigo = 50;
					vidaInimigo = 50;
				} else if (dados == 6){
					inimigo2 = "Dimen";
					danoInimigo = 3;
					vidaInimigo = 100;
				}
		
				Console.WriteLine ("Seu novo inimigo se chama: " + inimigo2);
				Console.WriteLine ("");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine ("=====INIMIGO=====");
				Console.WriteLine ("");
				Console.WriteLine ("Nome: " + inimigo2);
				Console.WriteLine ("Dano: " + danoInimigo);
				Console.WriteLine ("Vida: " + vidaInimigo);
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.ResetColor ();

				Console.Write ("Jogue o dado: ");
				Console.ReadKey ();
				dados = aleatorio.Next (1, 6);
				Console.WriteLine ("");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine ("O valor do dado: " + dados);
				Console.ResetColor ();
				Console.ReadKey ();
				Console.Clear ();

				danoInimigo = (danoInimigo * dados);
				vidaInimigo = (vidaInimigo * dados);

				Console.WriteLine ("=====BATALHA=====");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine ("Valor dos Dados: " + dados);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
				Console.WriteLine ("Dano Inimigo: " + danoInimigo);
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine ("Sua Vida: " + vidaTotal);
				Console.WriteLine ("Seu Atack: " + dano);
				Console.ResetColor ();
				Console.ReadKey ();	


				while (vidaTotal > 0 || vidaInimigo > 0) {

					if (danoInimigo >= vidaTotal) {
						vidaTotal = (vidaTotal - danoInimigo);
						Console.WriteLine (inimigo2 + " Ataca " + nome);
						Console.WriteLine (inimigo2 + " matou " + nome);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine ("vida atual: " + vidaTotal);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine ("GAME OVER");
						Console.ResetColor ();
						break;
					} else if (danoInimigo < vidaTotal) {
						vidaTotal = (vidaTotal - danoInimigo);
						Console.WriteLine (inimigo2 + " ataca " + nome);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine ("vida atual: " + vidaTotal);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
						Console.ResetColor ();
						Console.ReadKey ();
					}

					if (dano >= vidaInimigo) {
						Console.WriteLine (nome + " Atacou " + inimigo2);
						Console.WriteLine (nome + " matou " + inimigo2);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine ("YOU WINS");
						Console.WriteLine ("Vida atual: " + vidaTotal);
						Console.ResetColor ();
						break;

					} else if (dano < vidaInimigo) {
						vidaInimigo = (vidaInimigo - dano);
						Console.WriteLine (nome + " Atacou " + inimigo2);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine ("vida atual: " + vidaTotal);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine ("Vida Inimigo: " + vidaInimigo);
						Console.ResetColor ();
						Console.ReadKey ();
					}

				}
				Console.WriteLine ("isso é um teste");

			}
		}
	}
}
