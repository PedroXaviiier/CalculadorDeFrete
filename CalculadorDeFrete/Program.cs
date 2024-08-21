using CalculadorDeFrete;


Encomenda encomenda = new Encomenda();

Console.WriteLine("Informe o tamanho do trajeto de sua encomenda: ");
encomenda.TamanhoTrajetoKM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o peso de sua encomenda: ");
encomenda.Peso = Convert.ToInt32(Console.ReadLine());



Frete frete = new Frete();

double valorFinal = frete.CalcularTaxas(encomenda.TamanhoTrajetoKM, encomenda.Peso);

Console.WriteLine(encomenda.ToString() + "\n" + "Valor com todas as taxas: R$" + valorFinal);



