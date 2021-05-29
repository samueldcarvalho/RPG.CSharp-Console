using System;
namespace game.Models
{
    public class Jogador:Personagem
    {
        public Classe classe;
		private Random rand = new Random();
        public Jogador()
        {
            Console.WriteLine("Herói?!.. Herói! Nossa vila está em apuros... Nos ajude, por favor!{0}Logo a frente existe uma torre onde monstros terríveis adentraram e tomaram conta!{0}{0}A torre é a moradia da nossa lider, e ela está la dentro! No ultimo andar!",Environment.NewLine);
				Console.ReadLine();
				Console.WriteLine("Você vai nos ajudar?!");
			
				decisao = Console.ReadLine();
	
				Console.Write("Ah, que maravilha!{0}O meu nome é Samuel, sou o líder do exército da nossa vila, mas perdi inúmeros homens nessa batalha...{0}{0}Mas me diz, Herói. Qual o seu nome? {0}[Digite o seu nome] ",Environment.NewLine);
			
				nome = Console.ReadLine();
			
				if(nome == ""){nome = "Herói";}
					Console.WriteLine();
					Console.Clear();
					Console.WriteLine("{0}! O seu nome será lembrado para sempre! Obrigado por nos apoiar!{1}{1}Agora me diga, qual a sua classe? ",nome,Environment.NewLine);
					Console.WriteLine("");
					Console.WriteLine("[1]Arqueiro [2]Guerreiro [3]Paladino [4]Feiticeiro");
					classeChoose = Console.ReadLine();
			
					//Escolher classe
					switch(classeChoose)
					{
						case "1":
							classe = Classe.arqueiro;
							danoBase = 25;
							defesa = 0.3;
							hpMax = 200;
							break;
						case "2":
							classe = Classe.guerreiro;
							danoBase = 20;
							defesa = 0.5;
							hpMax = 230;
							break;
						case "3":
							danoBase = 17;
							hpMax = 350;
							defesa = 0.8;
							classe = Classe.paladino;
							break;
						case "4":
							danoBase = 24;
							hpMax = 185;
							defesa = 0.2;
							classe = Classe.feiticeiro;
							break;
						default:
							danoBase = 20;
							hpMax = 230;
							Console.WriteLine("Não entendi o que disse, mas acredito que seja um guerreiro! ");
							classe = Classe.guerreiro;
							break;
					}	
					Console.WriteLine("");
					Console.WriteLine("Pressione enter para continuar:");
					Console.ReadLine();
					Console.Clear();
			
					level = 1;
					hp = hpMax;
					xp = 0;
					xpMax = 20;
			
					Console.WriteLine("Incrível! você é um {0} das grandes terras!",classe);
					Console.WriteLine();
					Console.WriteLine("  Nome:..... {0}",nome);
					Console.WriteLine("  Classe:... {0}",this.classe);
					Console.WriteLine("  Level:.....{0}",level);
					Console.WriteLine("  Dano:..... {0}",danoBase);
					Console.WriteLine("  HP:....... {0}",hpMax);
					Console.WriteLine("  Atinja {0} de XP para passar de level!",xpMax);
			
					Console.WriteLine();
					Console.WriteLine("Certo, vamos indo!");
					Console.ReadLine();
					Console.Clear();
        }
    
    ///// Definir HP
		private double setHp (int hpLvl)
		{
			hpMax = Math.Round(hpMax + hpMax*0.10);
			if(hp>=hpMax){hp = hpMax;}
			return hpMax;
		}
		
		//////// Sistema de XP, Level UP e Upgrade de Status;
		public virtual void ReceberXp(int xpCount) 
		{
			Console.WriteLine();
			xp += xpCount;
			Console.WriteLine("Você recebeu {0} de XP!",xpCount);
			
			if(xp<xpMax){
			Console.WriteLine("XP restante para o próximo level: {0}",xpMax-xp);
			}

			while(xp>=xpMax)
			{
				level++;
				xp=xp - xpMax;
				xpMax = xpMax+(xpMax)/2;
				danoBase = danoBase+6/2; 
				setHp(level);
				
				Console.WriteLine("Você upou! Agora você foi para o level {0}! Pressione enter:",level);
				Console.ReadLine();
				Console.WriteLine("Seus Status foram para:");
				Console.WriteLine("Dano: {0}",danoBase);
				Console.WriteLine("HP: {0}",hpMax);
				
				if (xp<=0)
				{ 
					xp=0;
				}
				
				Console.WriteLine("XP: {0}",xp);
				Console.WriteLine("Atinja {0} de XP para passar de nível!",xpMax);
				Console.WriteLine();
				}
			
				Console.WriteLine();
				Console.WriteLine("Pressione enter para continuar:");
				Console.ReadLine();
				}
    }
}