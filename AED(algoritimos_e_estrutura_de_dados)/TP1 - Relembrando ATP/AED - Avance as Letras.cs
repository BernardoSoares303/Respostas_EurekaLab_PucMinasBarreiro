using System;
public class Program {
    public static void Main() {
        int T = int.Parse(Console.ReadLine());

        for(int i = 0; i < T; i++){
            string[] entrada = Console.ReadLine().Split();

            int soma = 0;    

            for(int j= 0; j < entrada[1].Length; j++){  
                char letra1 = entrada[0][j];
                char letra2 = entrada[1][j];

                int posicao1 = char.ToLower(letra1) - 'a' + 1;
                int posicao2 = char.ToLower(letra2) - 'a' + 1;

                int difenca = (posicao2 - posicao1 + 26) % 26;
                soma += difenca;   
            }

            Console.WriteLine(soma);
        }    
    }
}
