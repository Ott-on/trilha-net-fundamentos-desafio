namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar (sem hífen):");
            // Recebendo qual a placa do usuário e verificando o tamanho da string:
            string placa;
            int tamanhoDaStringPlaca;

            do
            {
                placa = Console.ReadLine().ToUpper(); 
                tamanhoDaStringPlaca = placa.Length;

                if (tamanhoDaStringPlaca != 7)
                {
                    Console.WriteLine("Digite a placa corretamente! Tamanho inválido.");
                }
            }while(tamanhoDaStringPlaca != 7);
            // Adicionando a placa do usuário na lista veiculos:
            foreach(string item in veiculos)
            {
                if(item == placa)
                {
                    Console.WriteLine("Esta placa já existe no sistema.");
                    return;
                }
            }
            veiculos.Add(placa);
            Console.WriteLine("Placa adicionada com sucesso");
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
           
                int horas = 0;
                decimal valorTotal = 0;
                // Pegando a quantidade de horas e o valorTotal:
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                // Removendo a placa da lista veiculos:
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("===========");
                // Lista os veículos estacionados:
                foreach(string item in veiculos)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine("===========");
                // Mostra a quantidade de veiculos:
                int quantidadeDeVeiculos = veiculos.Count;
                      
                Console.WriteLine($"A quantidade de veículos estacionados é igual a: {quantidadeDeVeiculos}");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
