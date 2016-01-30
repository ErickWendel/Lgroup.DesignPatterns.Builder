using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Builder.Model.Buider
{

    //a calsse vai construir a classe
    //de cliente é a classe CLIENTE BUILDER
    //É uma classe BUILDER para 1 classe de modelo
   public sealed  class ClienteBuilder
    {
       //a classe que vamos construir 
       private ClienteModel _novoCliente = new ClienteModel();

       public ClienteBuilder()
       {
           //Inicializamos as classes dependentes (AGREGADAS)
           _novoCliente.Fotos = new List<FotoModel>();
           _novoCliente.Telefones = new List<TelefoneModel>();

       }

       //Imagina que a tela vai ter quadro abas
       //Informacoes pessoais, endereco, telefones e fotos
       //É o usuario NUNCA vai preencher tudo de cara
       //ele preenche em etapas, simulamos isto no padrao builder
       public ClienteBuilder SetarDadosPessoais(String nome_, String email_, DateTime dataNascimento_)
       {
           //as informacoes que vieram da tela, foram levadas para o objeto de modelo
           _novoCliente.Nome = nome_;
           _novoCliente.Email = email_;
           _novoCliente.DataNascimento = dataNascimento_;
           return this;
       }

       //todas as etapas do BUILDER sempre precisam retornar
       //a propria classe construtora, CLIENTE BUILDER
       //para pegar a propria classe utilizar o THIS = CONTEXTO
       public ClienteBuilder SetarEndereco(String endereco_, String cep_, String numero_)
       {
           _novoCliente.Endereco = endereco_;
           _novoCliente.Cep = cep_;
           _novoCliente.Numero = numero_;
           return this;
       }

       public ClienteBuilder SetarTelefone(String ddd_, String numero_, String operadora_)
       {
           _novoCliente.Telefones.Add(new TelefoneModel
           {
               DDD = ddd_,
               Numero = numero_,
               Operadora = operadora_
           });
           return this;
       }

       public ClienteBuilder SetarFoto(String caminho_, String nome_)
       {
           _novoCliente.Fotos.Add(new FotoModel
           {
               Caminho = caminho_,
               Nome  = nome_
           });
           return this;
       }
       
       //Após o usuários passar pelas etapas que ele guardou informacoes
       //temos que retornar o objeto que montamos
       //A tela acionaria a tela de negocio
       //TELA -> BUSINESS -> CLIENTEBUILDER (CLIENTEMODEL)
       public ClienteModel Gerar()
       {
           //nunca esquecer de no final retornar o objeto construido
           return _novoCliente;
       }

    }
}
