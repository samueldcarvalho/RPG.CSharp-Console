using System;
namespace game.Models
{
    public class Inimigo: Personagem
    {
        	public Inimigo(int lvlPlayer)
			{
				if(level<5)
				{	
					nome = "Troll";
				}
			
				vivo = true;
				Random rdn = new Random();
				this.level = lvlPlayer;
				hpMax = 50;
	
				danoBase = 5;
			
				if(this.level<=0)
				{
					level=1;
				}
			
				Console.WriteLine("Você encontrou um {0} level {1}. Vença-o!",nome, level);
				Console.WriteLine();
				hpMax = (hpMax + (level * (hpMax*0.10))/2);
			
				danoBase = danoBase + (level *(danoBase*0.90)/1.2);
				hp = hpMax;
			
				Console.WriteLine();
				Console.ReadLine();
			}
			
			public void MostrarStatus()
			{
				Console.WriteLine("Status do inimigo: {0} LVL: {1}{0} DANO: {2}{0} HP: {3}{0}",Environment.NewLine,level,danoBase,hpMax);
			}
			
			public int getXp 
			{
				get
				{
					this.xp = this.xp + (20 * this.level);
					return this.xp;
				}
			}
			
			public int inimigoMorrer()
			{
				if(hp >0)
				{
					return 0;
				}
				
				if(hp<=0)
				{
					this.vivo=false;
					Console.WriteLine();
					Console.WriteLine("Você venceu a batalha contra o {0}, level {1}!", nome, level);
				}
				return this.getXp;
			}
 		}
    }
