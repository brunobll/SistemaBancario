
namespace Funcionalidades {

    public class Funcoes : Cadastro.Cliente {
        public void sacarDinheiro(){
            Console.WriteLine($"\nDeseja sacar {getSaldoBancario()}");
        }
    }
}