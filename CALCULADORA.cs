using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*VITOR FELIPE RAMOS MELLO - GRADUANDO ENGENHARIA DA COMPUTAÇÃO NA UNIVERSIDADE DO VALE DO ITAJAÍ*/


namespace Calculadora
{
    class CALCULADORA
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado = 0;///Declaração das variáveis de inserção de dados na calculadora, e atribuição do resultado (FLOAT)
            int escolha;///Declaração de escolha da operação
            bool controle = true;///Declaração de controle do programa

            Console.WriteLine("***********************CACULADORA******************************");
            Console.WriteLine("**Se os dois números forem iguais a 0 o programa encerra, mas vc pode encerrá-lo no início também**");
            Console.WriteLine("Digite a operação primeiramente\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - sair");
            escolha = int.Parse(Console.ReadLine());/*Comando para poder inserir dados na memória, nesta lógica ela deve ficar posicionada
                                                      logo depois do CWL */
            while (controle)/*Início do controle */
            {
                if(escolha == 5)/*Válido somente no início do programa, se escolher a opção 5 o programa encerra*/
                {
                    controle = false;/*Controle recebe valor false*/
                    break;/*Programa é encerrado*/
                }
                else/*Caso não seja escolhida a opção 5*/
                {
                    Console.WriteLine("Operação atual: " + escolha);
                    Console.WriteLine("Digite um número: ");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    num2 = float.Parse(Console.ReadLine());
                    /*---------------------------------------------------------*/
                    /*A partir desta linha, como estrutura de controle secundária, se o usuário quiser encerrar o programa,
                      deve digitar 0 em num1 e 0 em num2, pois sempre que o programa chegar no resultado ele vai rodar
                      novamente usando a mesma operação escolhida no início, então e controle primário
                      if(escolha == 5)
                      {
                         controle = false;
                         break;
                      }
                      NÃO IRÁ FUNCIONAR*/
                    if (num1 == 0 && num2 == 0)                   
                    {
                        controle = false;
                        break;
                    }

                    switch (escolha)/*Switch de acordo com a operação escolhida*/
                    {
                        case 1:
                            resultado = num1 + num2;
                            break;
                        case 2: 
                            resultado = num1 - num2;
                            break;
                        case 3:
                            resultado = num1 * num2;
                            break;
                        case 4:
                            resultado = num1 / num2;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Resultado da operação: " + escolha + " é: " + resultado);/*É mostrado o resultado na tela*/
                }
            }
        }
    }
}
