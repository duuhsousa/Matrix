using System;

namespace Matrix
{
    class Program
    {
        static string[,] Velha = {
                {"_","_","_"},
                {"_","_","_"},
                {" "," "," "},
            };
        static string winner;
        static void Main(string[] args)
        {
            int cont=0;
            int win=0;
            int i,j;
            Console.WriteLine("Bem vindo ao jogo do Novo!\n");
            JogoAgora();

            do{
                Console.Write("É a vez do X!\nDigite a posição Desejada...\n");
                do{
                    Console.Write("Linha: ");
                    i=int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    j=int.Parse(Console.ReadLine()); 
                }while(Velha[i,j]=="X" || Velha[i,j]=="O");
                Velha[i,j]="X";
                cont++;
                JogoAgora();
                win = ValidaJogo();
                if(cont>=9 && win!=1)
                {
                    Console.WriteLine("\n\nDEU VELHA!");
                    winner = "NINGUEM ";
                    break;
                }
                if(win == 0)
                {
                    Console.Write("É a vez do O!\nDigite a posição Desejada...\n");
                    do{
                        Console.Write("Linha: ");
                        i=int.Parse(Console.ReadLine());
                        Console.Write("Coluna: ");
                        j=int.Parse(Console.ReadLine());
                    }while(Velha[i,j]=="X" || Velha[i,j]=="O");
                    Velha[i,j]="O";
                    cont++;
                    JogoAgora();
                    win = ValidaJogo();
                    if(cont>=9 && win!=1)
                    {
                        Console.WriteLine("\n\nDEU VELHA!");
                        winner = "NINGUEM ";
                        break;
                    }
                }
            }while(win==0);
            Console.WriteLine("PARABENS!!!\n\n"+winner+" VENCEU!!!!");
        }
        static void JogoAgora()
        {
            Console.WriteLine("_"+Velha[0,0]+"_|_"+Velha[0,1]+"_|_"+Velha[0,2]+"_");
            Console.WriteLine("_"+Velha[1,0]+"_|_"+Velha[1,1]+"_|_"+Velha[1,2]+"_");
            Console.WriteLine(" "+Velha[2,0]+" | "+Velha[2,1]+" | "+Velha[2,2]+" \n");
        }
        static int ValidaJogo()
        {
            int i=0;
            if(Velha[0,0]=="X" && Velha[0,1]=="X" && Velha[0,2]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[1,0]=="X" && Velha[1,1]=="X" && Velha[1,2]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[2,0]=="X" && Velha[2,1]=="X" && Velha[2,2]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[0,0]=="X" && Velha[1,0]=="X" && Velha[2,0]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[0,1]=="X" && Velha[1,1]=="X" && Velha[2,1]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[0,2]=="X" && Velha[1,2]=="X" && Velha[2,2]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[0,0]=="X" && Velha[1,1]=="X" && Velha[2,2]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[0,2]=="X" && Velha[1,1]=="X" && Velha[2,0]=="X")
            {
                i = 1;
                winner = "X";
            }
            else if(Velha[0,0]=="O" && Velha[0,1]=="O" && Velha[0,2]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[1,0]=="O" && Velha[1,1]=="O" && Velha[1,2]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[2,0]=="O" && Velha[2,1]=="O" && Velha[2,2]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[0,0]=="O" && Velha[1,0]=="O" && Velha[2,0]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[0,1]=="O" && Velha[1,1]=="O" && Velha[2,1]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[0,2]=="O" && Velha[1,2]=="O" && Velha[2,2]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[0,0]=="O" && Velha[1,1]=="O" && Velha[2,2]=="O")
            {
                i = 1;
                winner = "O";
            }
            else if(Velha[0,2]=="O" && Velha[1,1]=="O" && Velha[2,0]=="O")
            {
                i = 1;
                winner = "O";
            }
            return i;
        }
    }
}
