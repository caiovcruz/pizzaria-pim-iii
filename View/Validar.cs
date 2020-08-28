using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace View
{
    public class Validar
    {
        private bool _campoValido = false;
        private bool _tamanhoValido = false;
        private bool _letraValida = false;
        private bool _numeroValido = false;
        private DateTime? _dtNascimento = null;
        private bool _valorValido = false;
        private bool _dtNascimentoValido;
        private bool _senhaValida = false;
        private bool _usuarioValido = false;

        public bool CampoValido { get => _campoValido; set => _campoValido = value; }
        public bool TamanhoValido { get => _tamanhoValido; set => _tamanhoValido = value; }
        public bool LetraValida { get => _letraValida; set => _letraValida = value; }
        public bool NumeroValido { get => _numeroValido; set => _numeroValido = value; }
        public DateTime? DtNascimento { get => _dtNascimento; set => _dtNascimento = value; }
        public bool ValorValido { get => _valorValido; set => _valorValido = value; }
        public bool DtNascimentoValido { get => _dtNascimentoValido; set => _dtNascimentoValido = value; }
        public bool SenhaValida { get => _senhaValida; set => _senhaValida = value; }
        public bool UsuarioValido { get => _usuarioValido; set => _usuarioValido = value; }

        public Validar()
        {

        }

        public bool CampoNulo(string campo)
        {
            if (campo == string.Empty)
            {
                CampoValido = false;
            }
            else
            {
                CampoValido = true;
            }

            return CampoValido;
        }

        public bool TamanhoCampo(string campo, int tamanho)
        {
            if (campo.Length > tamanho)
            {
                TamanhoValido = false;
            }
            else
            {
                TamanhoValido = true;
            }

            return TamanhoValido;
        }

        public bool Letra(string campo)
        {
            if (!Regex.IsMatch(campo, @"^[a-zA-Z\s]+$"))
            {
                LetraValida = false;
            }
            else
            {
                LetraValida = true;
            }

            return LetraValida;
        }

        public bool Numero(string campo)
        {
            if (!Regex.IsMatch(campo, @"^[\d]+$"))
            {
                NumeroValido = false;
            }
            else
            {
                NumeroValido = true;
            }

            return NumeroValido;
        }

        public bool Valor(string campo)
        {
            if (!Regex.IsMatch(campo, @"^[1-9]\d{0,2}(\.\d{3})*,\d{2}$"))
            {
                ValorValido = false;
            }
            else
            {
                ValorValido = true;
            }

            return ValorValido;
        }

        public bool ValorComZero(string campo)
        {
            if (!Regex.IsMatch(campo, @"^[\d]\d{0,2}(\.\d{3})*,\d{2}$"))
            {
                ValorValido = false;
            }
            else
            {
                ValorValido = true;
            }

            return ValorValido;
        }

        public void DataNascimento(DateTimePicker campo)
        {
            if (campo.Value >= campo.MaxDate)
            {
                DtNascimento = null;
            }
            else
            {
                DtNascimento = campo.Value;
            }
        }

        public void DataNascimentoObrigatorio(DateTimePicker campo)
        {
            if (campo.Value >= campo.MaxDate)
            {
                DtNascimentoValido = false;
            }
            else
            {
                DtNascimentoValido = true;
            }
        }

        public bool UsuarioVazio(string campo)
        {
            if (campo == "USUÁRIO")
            {
                UsuarioValido = false;
            }
            else
            {
                UsuarioValido = true;
            }

            return UsuarioValido;
        }

        public bool SenhaVazia(string campo)
        {
            if (campo == "SENHA")
            {
                SenhaValida = false;
            }
            else
            {
                SenhaValida = true;
            }

            return SenhaValida;
        }

        public bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || 
                cpf == "00000000000" || 
                cpf == "11111111111" || 
                cpf == "22222222222" || 
                cpf == "33333333333" || 
                cpf == "44444444444" || 
                cpf == "55555555555" || 
                cpf == "66666666666" || 
                cpf == "77777777777" || 
                cpf == "88888888888" || 
                cpf == "99999999999")
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
