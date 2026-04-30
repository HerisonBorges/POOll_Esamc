namespace BibliotecaValidacoes
{
	public class Validador
	{
		
		public bool ValidarCPF(string cpf)
		{
			return !string.IsNullOrEmpty(cpf);
		}


		public bool ValidarEmail(string email)
		{
			return email.Contains("@");
		}

		public bool ValidarSenha(string senha)
		{
			return senha.Length >= 6;
		}
	}
}