using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{

    //polimorfismo , muitas formas .
    //definição: 2 ou mais classes derivadas de uma mesma classe base podem invocar metodos
    //com a mesma assinatura porem com comportamentos diferentes especializadas para cada classe derivada usando como referencia
    //objeto superClasse 

    //resumo 
    // um objeto criado com polimorfismo pode ter comportamentos diferentes dependendo de como for instanciado 
    abstract public class Forma
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int altura { get; set; }
        public int largura { get; set; }
        public int raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando para desenhar");
        }
        public virtual void Area()
        {
            int area = largura * largura;
            Console.WriteLine("Area  : " + area);
        }
    }
    public class Circulo : Forma 
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("desenhando um circulo");
        }
        public override void Area()
        {
            double area = 3.14 * (raio * raio);
            Console.WriteLine("area do circulo " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            //code desenhar retangulo
            Console.WriteLine("desenhando retangulo");
            base.Desenhar();
        }
        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            //code desenhar triangulo 
            Console.WriteLine("desenhando triangulo ");
            base.Desenhar();    
        }
        public override void Area()
        {
            int area = (largura * largura) / 2;
            Console.WriteLine("area de tringulo : " + area);
        }
    }

}
