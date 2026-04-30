using System;

public class Conta
{
	public int Numero { get; private set; }
	public string Titular { get; private set; }
	public decimal Saldo { get; private set; }

	private decimal totalSacadoHoje = 0;

	public Conta(int numero, string titular, decimal saldo)
	{
		Numero = numero;
		Titular = titular;
		Saldo = saldo;
	}

	public decimal Depositar(decimal valor)
	{
		if (valor <= 0)
			throw new ArgumentException("Valor do depósito deve ser positivo");

		if (valor > 10000)
			throw new ArgumentException("Valor do depósito não pode ser maior que 10.000");

		Saldo += valor;
		return Saldo;
	}

	public decimal Sacar(decimal valor)
	{
		if (valor <= 0)
			throw new ArgumentException("Valor do saque deve ser positivo");

		if (valor > 500)
			throw new LimiteDiarioException("Saque máximo por operação é 500");

		if (totalSacadoHoje + valor > 1000)
			throw new LimiteDiarioException("Limite diário de saque excedido");

		try
		{
			if (Saldo < valor)
				throw new Exception("Erro interno: saldo insuficiente");

			Saldo -= valor;
			totalSacadoHoje += valor;

			return Saldo;
		}
		catch (Exception ex)
		{
			throw new SaldoInsuficienteException("Erro ao sacar", ex);
		}
	}

	public void Transferir(Conta destino, decimal valor)
	{
		if (destino == null)
			throw new ArgumentException("Conta de destino não pode ser nula");

		if (valor <= 0)
			throw new ArgumentException("Valor da transferência deve ser positivo");

		Sacar(valor);
		destino.Depositar(valor);
	}

	public override string ToString()
	{
		return $"Conta: {Numero} - {Titular} - Saldo: {Saldo}";
	}
}