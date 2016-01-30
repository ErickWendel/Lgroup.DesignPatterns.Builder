using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LGroup.Builder.Model
{
    /// <summary>
    /// Um padrão muito utilizado, utilizamos sem saber, é o padrão BUILDER
    /// É um padrão construtor de objetos
    /// Padrão GOF, DO FACTORY = 3
    /// A proposta do padrão é construir os objetos em etapas
    /// As vezes de caras nos nao temos todos os campos da classe
    /// Para esses casos onde vamos preenchendo uma classe em etapas utilizamos o padrão construtor
    /// Encontrou sistemas modais ou com abas, implementar o modelo builder
    /// </summary>
    public sealed class ClienteModel
    {

        #region Informações pessoais

        public Int32 Codigo { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public DateTime DataNascimento { get; set; }

        #endregion

        #region Informações de localização

        public String Endereco { get; set; }

        public String Cep { get; set; }

        public String Numero { get; set; }
        #endregion

        #region Dados complementares

        /// <summary>
        /// As 3 principais coleções no dia a dia são
        /// ILIST -> Lista leitura, gravação e pesquisa
        /// IENUMERABLE -> É uma lista somente de leitura
        /// IQUERYABLE -> 
        /// </summary>
        public ICollection<TelefoneModel> Telefones { get; set; }

        public ICollection<FotoModel> Fotos { get; set; }

        #endregion

    }
}
