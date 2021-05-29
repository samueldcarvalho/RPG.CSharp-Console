using System;
using game.Models;

namespace game
{
				
public class Program
{

	public static void Main()
	{
		/// Instancias e ciclos:
		Jogador player = new Jogador();
		
		/// Sistema de Combate:
		int vezPlayer, vezEnemy = 0;
		string vezDeQuem;
		string playerDecisao;
		
		/// Sistema da torre:
		if(entrarTorre()==true)
		{
			Console.Clear();
			Console.WriteLine("Você entrou na torre.{0}Agora é com você, precisa resgatar a nossa líder! Mate, evolua e salve-a!",Environment.NewLine);
			Console.ReadLine();
			Console.Clear();
			
			while(player.hp > 0)
			{	
				Inimigo enemy = new Inimigo(player.level);
				vezPlayer=1;
				vezDeQuem = player.nome;
				Console.Clear();
			
				for(int turno = 1;enemy.hp>0;turno++)
				{	
					enemy.MostrarStatus();
					Console.WriteLine("	{0}º Turno", turno,turno);
					Console.WriteLine("Vez de {0}",vezDeQuem);
					Console.ReadLine();
					
					if(turno == 1){vezPlayer = 1;}
					
					/////// Vez do Player
					if(vezPlayer == 1)
					{
						Console.WriteLine("Escolha uma ação:{0}[1] Atacar! {0}[2] Defender {0}[3] Especial!", Environment.NewLine);
						playerDecisao = Console.ReadLine();
						Console.WriteLine();
						
						switch(playerDecisao)
						{
							case "1":
								enemy.receberDano(player.iflingirDano());
								break;
							case "2":
								player.defender = true;
								Console.WriteLine("Você vai tentar defender! {0}", Environment.NewLine);
								Console.ReadLine();
								break;
							case "3":
								enemy.receberDano(Math.Round(player.iflingirDano()+player.iflingirDano()*0.5));
								break;
							default:
								Console.WriteLine("Você pulou a vez. {0}", Environment.NewLine);
								break;		
						}	
					}
					////// Vez do Enemy
					if(vezEnemy == 1)
					{
						if(player.defender == false)
						{
							player.receberDano(enemy.iflingirDano());
						}
						else
						{
							player.receberDano(Math.Round(enemy.iflingirDano()-enemy.iflingirDano()*player.defesa));
							player.defender = false;
						}
					}
					
					////// Definição de Ciclo
					if(vezPlayer ==1)
					{
						vezEnemy = 1;
						vezPlayer = 0;
						vezDeQuem = enemy.nome;
					}else if(vezEnemy == 1)
					{
						vezEnemy = 0;
						vezPlayer = 1;
						vezDeQuem = player.nome;
					}
					Console.Clear();
				}
				player.ReceberXp(enemy.inimigoMorrer());
				Console.Clear();
			}
		}
		Console.WriteLine("");
		Console.WriteLine("Que vergonha... Você matou todos.");
		Console.ReadLine();
	}
	
	
	public static bool entrarTorre()
	{
		string decisao;
		
		////// Textos
		Console.WriteLine("A torre é logo à frente.");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Já estou vendo a parte mais alta! ");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Estamos chegando.");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Calma! É logo ali. ");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Acalme-se, já sinto o cheiro daqueles malditos. ");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Um pouco mais.");
		Console.ReadLine();
		Console.Clear();
		Console.WriteLine("Lá está! ");
		Console.WriteLine();
		Console.WriteLine("A torre da nossa líder... Precisamos resgatá-la!{0}A torre possui 20 andares, é bem provável que ela esteja no ultimo andar.{0}",Environment.NewLine);
	
		Console.WriteLine("Você vai entrar lá, não vai? {0}[S] Claro! Eu sou o herói! {0}[N] Nem a pau! ",Environment.NewLine);
		decisao = Console.ReadLine();
		
		switch(decisao)
		{
			case "S":
				return true;
				break;
			case "s":
				return true;
				break;
			case "N":
				return false;
				break;
			case "n":
				return false;
				break;
			default:
				Console.WriteLine("Acho que você disse que vai, então vai Po%#@!!!");
				return true;
				break;
		}
		Console.ReadLine();
	}	


}
}
