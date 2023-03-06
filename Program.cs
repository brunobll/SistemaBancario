global using System; 
using System.Collections;

class Program {
    static void Main(){
        string? sinalSaida = " "; 
        int funcaoEscolhida;
        decimal valorInformado; 

        ArrayList transacoes = new ArrayList();
        Cadastro.Conta conta = new Cadastro.Conta(" ", 0, 0);

        Console.Write("\nNome completo: "); 
        conta.setNomeCompleto(Console.ReadLine());

        Console.Write("\nCPF: ");
        conta.setCPF(Convert.ToInt64(Console.ReadLine()));

        Console.WriteLine($"\nConta criada com sucesso com os dados informados: \nNome {conta.getNomeCompleto()} \nCPF: {conta.getCPF()}");

        while(sinalSaida != "n"){
            
            Console.WriteLine("\nQual operacao deseja realizar?");
            Console.WriteLine("\n1 - Deposito \n2 - Saque \n3 - Emitir extrato \n4 - Encerrar sessao");
            funcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            if(funcaoEscolhida == 1){
                Console.WriteLine("\nInforme o valor a ser depositado: "); 
                valorInformado = Convert.ToDecimal(Console.ReadLine());
                conta.depositarValor(valorInformado);

                transacoes.Add($" +{valorInformado}");
            }

            if(funcaoEscolhida == 2){
                Console.WriteLine("\nInforme o valor a ser sacado: "); 
                valorInformado = Convert.ToDecimal(Console.ReadLine());

                if(valorInformado > conta.getSaldoBancario()){
                    Console.WriteLine("\nNao e possivel sacar este valor, pois e maior que o valor disponivel na conta!!");
                }

                else{
                    conta.sacarValor(valorInformado);

                    transacoes.Add($" -{valorInformado}");
                }

            }

            if(funcaoEscolhida == 3){

                Console.Write($"\nNome: {conta.getNomeCompleto()}");
                Console.Write($"\nCPF: {conta.getCPF()}");
                Console.Write("\n\n");

                foreach(string transacao in transacoes){
                    Console.WriteLine(transacao);
                }
            }

            if(funcaoEscolhida == 4){
                break;
            }

            Console.Write("\nDeseja realizar uma nova operacao? [n == parar] ");
            sinalSaida = Console.ReadLine();
        
        }
        
    }
}