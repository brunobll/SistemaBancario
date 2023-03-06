using System; 

namespace Cadastro{
    public class Cliente {
        private string? nome; 
        private string? sobrenome;
        private long codigoPessoaFisica; //CPF
        private int numeroConta; 
        private long saldoBancario; 

        public Cliente(){
            this.nome = this.sobrenome = " "; 
            this.codigoPessoaFisica = 0; 
            this.numeroConta = 0; 
            this.saldoBancario = 0;

        }

        public void setNome(string? nome) { this.nome = nome; }
        public void setSobrenome(string? sobrenome) { this.sobrenome = sobrenome; }

        public void setCPF(long codigoPessoaFisica) { this.codigoPessoaFisica = codigoPessoaFisica; }

        public void setNumeroConta(int numeroConta) { this.numeroConta = numeroConta; }


        public void setSaldoBancario(long saldoBancario) { this.saldoBancario = saldoBancario; }

        public string getNome() { 
            return (nome is not null ? nome : " "); 
        }
        public string getSobrenome() { 
            return (sobrenome is not null ? sobrenome : " ");
        }

        public string getNomeCompleto() { return ("${getNome()} {getSobrenome()}"); }
        public long getCPF() { return codigoPessoaFisica; }

        public int getNumeroConta() { return numeroConta; }

        public long getSaldoBancario() { return saldoBancario; }




    }
}