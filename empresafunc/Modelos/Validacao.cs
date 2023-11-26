using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Validacao
{
    public static bool CPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        int soma = 0;
        int cont = 0;
        int PNumV = 0;
        int SNumV = 0;
        if (cpf.Length != 11)
        {
            return false;
        }
        else
        {
            cont = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * cont;
                cont--;
            }
            if (soma % 11 < 2)
            {
                PNumV = 0;
            }
            else
            {
                PNumV = 11 - soma % 11;
            }
            soma = 0;
            cont = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * cont;
                cont--;
            }
            if (soma % 11 < 2)
            {
                SNumV = 0;
            }
            else
            {
                SNumV = 11 - soma % 11;
            }
            if (PNumV == Convert.ToInt32(cpf[9].ToString()) && SNumV == Convert.ToInt32(cpf[10].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }



        }

    }

    public static bool Email(string email)
    {
        string padrao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        return Regex.IsMatch(email, padrao);

    }

    public static bool Cnpjval (string cnpj)
    {

        cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

        if (cnpj.Length != 14)
        {
            return false;
        }

        int[] pesos1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma1 = pesos1.Select((t, i) => int.Parse(cnpj[i].ToString()) * t).Sum();
        int digito1 = soma1 % 11 < 2 ? 0 : 11 - soma1 % 11;

        int[] pesos2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma2 = pesos2.Select((t, i) => int.Parse(cnpj[i].ToString()) * t).Sum();
        int digito2 = soma2 % 11 < 2 ? 0 : 11 - soma2 % 11;

        return int.Parse(cnpj[12].ToString()) == digito1 && int.Parse(cnpj[13].ToString()) == digito2;
    }

        /*
    private bool TextBoxVazio()
    {
        foreach (Control c in this.Controls)
        {
           
            if (c is TextBox || c is MaskedTextBox)
            {
                var text = c.Text.Replace(",", "").Replace("-", "").Trim();

                if (text == "")
                {
                    return true;
                }
            }

            return false;
        }
    }*/
}