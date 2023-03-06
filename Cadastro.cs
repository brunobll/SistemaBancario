using System; 

namespace Cadastro{
    public class Conta {
        private string? nomeCompleto; 
        private long codigoPessoaFisica;
        private decimal saldoBancario;  
        

        public Conta(string? nomeCompleto, int codigoPessoaFisica, int saldoBancario){
            this.nomeCompleto = nomeCompleto; 
            this.codigoPessoaFisica = codigoPessoaFisica;
            this.saldoBancario = saldoBancario;

        }

        //setters
        public void setNomeCompleto(string? nomeCompleto) { this.nomeCompleto = nomeCompleto; }

        public void setCPF(long codigoPessoaFisica) { this.codigoPessoaFisica = codigoPessoaFisica; }

        public void setSaldoBancario(decimal saldoBancario) { this.saldoBancario = saldoBancario; }

        //getters
        public string getNomeCompleto() { 
            return (nomeCompleto is not null ? nomeCompleto : " "); 
        }

        public long getCPF() { return codigoPessoaFisica; }

        public decimal getSaldoBancario() { return saldoBancario; }
 
        //deposito
        public decimal depositarValor(decimal valorInformado){
            
            this.saldoBancario += valorInformado; 
            Console.WriteLine("\nValor depositado com sucesso!");
            Console.WriteLine($"\nSaldo atual: {saldoBancario}");

            return 0; 
        }

        public decimal sacarValor(decimal valorInformado){
            
            Console.WriteLine($"\nSaldo atual: {saldoBancario}");
            this.saldoBancario -= valorInformado; 
            Console.WriteLine($"\nSaldo novo: {saldoBancario}");
            Console.WriteLine("\nValor sacado com sucesso!");
    
            return 0; 
        }

    }
}