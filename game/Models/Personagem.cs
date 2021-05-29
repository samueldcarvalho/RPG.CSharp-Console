using System;
namespace game.Models
{
    public abstract class Personagem
    {
        	
		public string nome;
		public string classeChoose;
		public string decisao;
		public bool vivo = true;
		
		public  double danoBase;
		public double defesa;
		public double hp, hpMax; 
		public bool defender;
				
		public int xp, xpMax;
		public int level, levelMax;
		
		
		public double getDano
		{
			get{return danoBase;}
			set{danoBase=value;}
		}	
		
		/////// Ataque com GetDano
		public double iflingirDano()
		{
			getDano = this.getDano;
			return getDano;	
		}
		
		/////// Recebendo Dano
		public double receberDano(double dano)
		{
			hp = hp - dano;
				
			if(hp < 0){hp=0;}
				
			Console.WriteLine("{0} levou {1} de dano! ",nome, dano);
			Console.WriteLine("HP: {0}",hp);
			
			Console.WriteLine(Console.ReadLine());
			return dano;
		}
		
    }
}