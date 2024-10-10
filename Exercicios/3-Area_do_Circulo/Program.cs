using System;

class URI
{

    static void Main(string[] args)
    {

        //Formula para calcular área do circulo
        //area = π . raio2 
        //π = 3.14159:

        //- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

        //Entrada
        //A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.

        //Saída
        //Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal.
        //Utilize variáveis de dupla precisão (double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

        double raio = double.Parse(Console.ReadLine());

        double doubleRaioQuadrado = Math.Pow(raio, 2);

        double area = doubleRaioQuadrado * 3.14159;

        Console.WriteLine("A=" + area.ToString("F4"));

    }

}