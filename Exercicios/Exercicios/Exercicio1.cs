
namespace Exercicios
{
    internal class Exercicio1
    {
        //Operadores Aritméticos

        //1. Escreva um programa que leia dois números inteiros e exiba a soma deles.
        public static void Soma()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 + numero2);
        }

        //2. Escreva um programa que leia dois números inteiros e mostre a diferença entre o primeiro e o segundo número.
        public static void Subtracao()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 - numero2);
        }

        //3. Escreva um programa que leia dois números inteiros e exiba o produto deles.

        public static void Multiplicacao()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 * numero2);
        }

        //4. Escreva um programa que leia dois números inteiros e mostre o resultado da divisão do primeiro pelo segundo. (Considere a divisão inteira, sem ponto flutuante.).
        public static void Divisao()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 / numero2);
        }

        //5.Escreva um programa que leia dois números inteiros e exiba o resto da divisão do primeiro pelo segundo.

        public static void RestoDivisao()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 % numero2);
        }

        //Operadores de Atribuição

        //1. Escreva um programa que declare uma variável inteira, atribua a ela um valor digitado pelo usuário e exiba esse valor.
        public static void Atribuicao()
        {
            Console.WriteLine("Escreva o valor");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine(valor);
        }

        //2. Escreva um programa que declare uma variável inteira, atribua um valor a ela, depois adicione um valor digitado pelo usuário a essa variável e exiba o resultado.
        public static void DeclaracaoAtribuicao()
        {
            int valor = 1;

            Console.WriteLine("Escreva o valor");
            valor += int.Parse(Console.ReadLine());

            Console.WriteLine(valor);
        }

        //3. Escreva um programa que declare uma variável inteira, atribua um valor inicial, depois subtraia um valor digitado pelo usuário dessa variável e mostre o resultado.

        public static void DeclaracaoSubtracao()
        {
            int valor = 1;

            Console.WriteLine("Escreva o valor");
            valor -= int.Parse(Console.ReadLine());

            Console.WriteLine(valor);
        }

        //4. Escreva um programa que declare uma variável inteira, atribua um valor a ela, multiplique essa variável por um número digitado pelo usuário e exiba o resultado.
        public static void DeclaracaoMultiplicacao()
        {
            int valor = 1;

            Console.WriteLine("Escreva o valor");
            valor *= int.Parse(Console.ReadLine());

            Console.WriteLine(valor);
        }

        //5. Escreva um programa que declare uma variável inteira, atribua um valor inicial, divida essa variável por um número digitado pelo usuário e mostre o resultado da divisão.
        public static void DeclaracaoDivisao()
        {
            int valor = 1;

            Console.WriteLine("Escreva o valor");
            valor /= int.Parse(Console.ReadLine());

            Console.WriteLine(valor);
        }

        //Operadores Relacionais

        //1. Escreva um programa que leia dois números inteiros e exiba se eles são iguais ou não.
        public static void Iguais()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 == numero2);
        }


        //2. Escreva um programa que leia dois números inteiros e exiba se eles são diferentes.
        public static void Difrentes()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 != numero2);
        }

        //3. Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior que o segundo.
        public static void Maior()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 > numero2);
        }

        //4. Escreva um programa que leia dois números inteiros e exiba se o primeiro número é menor que o segundo.
        public static void Menor()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 < numero2);
        }

        //5. Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior ou igual ao segundo.
        public static void MaiorIgual()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 >= numero2);
        }

        //Operadores Lógicos

        //1. Escreva um programa que leia dois números inteiros e verifique se ambos são maiores que zero usando o operador lógico &&.
        public static void AndQueZero()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 > 0 && numero2 > 0);
        }

        //2. Escreva um programa que leia dois números inteiros e verifique se pelo menos um deles é menor que zero usando o operador lógico ||.
        public static void OuMaiorQueZero()
        {
            Console.WriteLine("Escreva o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 < 0 || numero2 < 0);
        }

        //Operadores Ternários

        //1. Escreva um programa que leia a idade de uma pessoa e use o operador ternário para verificar se ela é maior de idade ou não.
        public static void MaiorDeDezoito()
        {
            Console.WriteLine("Escreva sua idade");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 >= 18 ? "Maior de idade" : "Menor de idade");
        }

        //2. Escreva um programa que leia um número inteiro e use o operador ternário para verificar se o número é par ou ímpar.
        public static void ParOuImpar()
        {
            Console.WriteLine("Escreva um número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 % 2 == 0 ? "Par" : "Impar");
        }

        //3. Escreva um programa que leia um número inteiro e use o operador ternário para exibir "Positivo" se o número for maior que zero, "Negativo" se o número for menor que zero, e "Zero" se for exatamente zero.
        public static void PositivoNegativo()
        {
            Console.WriteLine("Escreva um número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine(numero1 > 0 ? "Positivo" : "Negativo");
        }
    }
}
